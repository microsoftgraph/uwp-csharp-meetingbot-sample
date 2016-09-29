//Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license.
//See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Graph;

namespace uwp_csharp_meetingbot_sample
{
    public static class CalendarHelper
    {

        public static async Task<bool> SendReplyAllMessageAsync(string body, string subject, bool? isOrganizer)
        {
            bool emailSent = false;

            try
            {
                GraphServiceClient graphClient = AuthenticationHelper.GetAuthenticatedClient();
                // Get meeting message from user's Sent Items folder or Inbox
                IMailFolderMessagesCollectionPage eventMessages;

                if (isOrganizer.GetValueOrDefault())
                {
                    eventMessages = await graphClient.Me.MailFolders.SentItems.Messages.Request().Filter("Subject eq '" + subject + "'").GetAsync();
                }
                else
                {
                    eventMessages = await graphClient.Me.MailFolders.Inbox.Messages.Request().Filter("Subject eq '" + subject + "'").GetAsync();
                }

                if (eventMessages.Count > 0)
                {
                    Message messageToReplyAll = eventMessages[0];

                    // Reply all to message
                    Message replyMessage = await graphClient.Me.Messages[messageToReplyAll.Id].CreateReplyAll().Request().PostAsync();

                    if (!String.IsNullOrEmpty(body))
                    {
                        ItemBody replyMessageBody = new ItemBody { ContentType = BodyType.Text, Content = body };
                        replyMessage.Body = replyMessageBody;
                        await graphClient.Me.Messages[replyMessage.Id].Request().UpdateAsync(replyMessage);
                    }
                    await graphClient.Me.Messages[replyMessage.Id].Send().Request().PostAsync();
                    emailSent = true;
                }

            }

            catch (ServiceException e)
            {
                Debug.WriteLine("Failed to send message" + e.Error.Message);
                emailSent = false;
            }

            return emailSent;
        }



        public static async Task<IUserCalendarViewCollectionPage> GetDayEventsAsync(string startDateTime, string endDateTime)
        {
            IUserCalendarViewCollectionPage events = null;

            try
            {
                GraphServiceClient graphClient = AuthenticationHelper.GetAuthenticatedClient();
                string localTimeZone = TimeZoneInfo.Local.Id;

                List<Option> options = new List<Option>();
                options.Add(new QueryOption("StartDateTime", startDateTime));
                options.Add(new QueryOption("EndDateTime", endDateTime));
                options.Add(new HeaderOption("Prefer", "outlook.timezone=\"" + localTimeZone + "\""));

                events = await graphClient.Me.CalendarView.Request(options).OrderBy("start/DateTime").GetAsync();
            }

            catch (ServiceException e)
            {
                Debug.WriteLine("Get events failed: " + e.Error.Message);
                return null;
            }

            return events;
        }

    }
}
