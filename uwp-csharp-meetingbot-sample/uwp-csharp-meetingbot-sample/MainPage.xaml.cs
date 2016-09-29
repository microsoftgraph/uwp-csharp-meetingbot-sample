//Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license.
//See LICENSE in the project root for license information.

using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;
using Windows.ApplicationModel.Resources.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using Windows.Media.SpeechRecognition;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace uwp_csharp_meetingbot_sample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {

            // Developer code - if you haven't registered the app yet, we warn you. 
            if (!App.Current.Resources.ContainsKey("ida:ClientID"))
            {
                Debug.WriteLine(ResourceLoader.GetForCurrentView().GetString("NoClientIdMessage"));

            }

            string parameter = (string)e.Parameter;

            await ConnectUser();

            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now.AddDays(1).AddTicks(-1);

            if (parameter == "showNextMeeting")
            {
                IUserCalendarViewCollectionPage events = await CalendarHelper.GetDayEventsAsync(startDate.ToString("o"), endDate.ToString("o"));
                if (events.Count > 0)
                {
                    Message.Text = ResourceLoader.GetForCurrentView().GetString("NextMeetingIntro");
                    MeetingTitle.Text = events[0].Subject;
                    MeetingTimes.Text = events[0].Start.DateTime.Substring(0, 16) + " - " + events[0].End.DateTime.Substring(0, 16);
                    Participants.ItemsSource = events[0].Attendees;
                    Participants.Header = ResourceLoader.GetForCurrentView().GetString("ParticipantsText");
                    Participants.Visibility = Visibility.Visible;
                }

                else
                {
                    Salutation.Text = ResourceLoader.GetForCurrentView().GetString("NoMeetingsFound");
                }
            }

            else if (parameter == "lateMeeting")
            {
                IUserCalendarViewCollectionPage events = await CalendarHelper.GetDayEventsAsync(startDate.ToString("o"), endDate.ToString("o"));

                if (events.Count > 0)
                {
                    bool emailSent = await CalendarHelper.SendReplyAllMessageAsync(ResourceLoader.GetForCurrentView().GetString("RunningLateMessage"), events[0].Subject, events[0].IsOrganizer);

                    if (emailSent)
                    {
                        Message.Text = ResourceLoader.GetForCurrentView().GetString("RunningLateConfirmation");
                        MeetingTitle.Text = events[0].Subject;
                        MeetingTimes.Text = events[0].Start.DateTime + " - " + events[0].End.DateTime;
                        Participants.ItemsSource = events[0].Attendees;
                        Participants.Header = ResourceLoader.GetForCurrentView().GetString("RecipientsText");
                        Participants.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        Message.Text = ResourceLoader.GetForCurrentView().GetString("ReplyAllFailed");
                    }

                }

                else
                {
                    Message.Text = ResourceLoader.GetForCurrentView().GetString("NoMeetingsFound");
                }

            }

        }

        private async void Connect_Click(object sender, RoutedEventArgs e)
        {
            await ConnectUser();
        }

        private async Task ConnectUser()
        {
            GraphServiceClient graphClient = AuthenticationHelper.GetAuthenticatedClient();
            User currentUserObject = await graphClient.Me.Request().GetAsync();
            Salutation.Text = ResourceLoader.GetForCurrentView().GetString("SalutationText") + currentUserObject.DisplayName;
            DisconnectButton.IsEnabled = true;
            ConnectButton.IsEnabled = false;
        }

        private void Disconnect_Click(object sender, RoutedEventArgs e)
        {
            AuthenticationHelper.SignOut();
            MeetingTitle.Text = "";
            MeetingTimes.Text = "";
            Salutation.Text = "";
            DisconnectButton.IsEnabled = false;
            ConnectButton.IsEnabled = true;
        }
    }
}
