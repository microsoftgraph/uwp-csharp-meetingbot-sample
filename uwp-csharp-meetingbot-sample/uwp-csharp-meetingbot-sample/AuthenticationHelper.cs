//Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license.
//See LICENSE in the project root for license information.

using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;
using Windows.Security.Authentication.Web;
using Windows.Security.Authentication.Web.Core;
using Windows.Security.Credentials;
using Windows.Storage;
using Microsoft.Graph;
using Microsoft.Identity.Client;
using System.Collections.Generic;

namespace uwp_csharp_meetingbot_sample
{
    public class AuthenticationHelper
    {
        // The Client ID is used by the application to uniquely identify itself to the v2.0 authentication endpoint.
        static string clientId = App.Current.Resources["ida:ClientID"].ToString();
        public static string[] Scopes = { "User.Read", "Mail.Send", "Calendars.Read", "Mail.ReadWrite" };

        public static PublicClientApplication IdentityClientApp = new PublicClientApplication(clientId);

        private static GraphServiceClient graphClient = null;

        // Get an access token for the given context and resourceId. An attempt is first made to 
        // acquire the token silently. If that fails, then we try to acquire the token by prompting the user.
        public static GraphServiceClient GetAuthenticatedClient()
        {
            if (graphClient == null)
            {
                // Create Microsoft Graph client.
                try
                {
                    graphClient = new GraphServiceClient(
                        "https://graph.microsoft.com/v1.0",
                        new DelegateAuthenticationProvider(
                            async (requestMessage) =>
                            {
                                var token = await GetTokenForUserAsync();
                                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", token);
                                // This header has been added to identify our sample in the Microsoft Graph service.  If extracting this code for your project please remove.
                                requestMessage.Headers.Add("SampleID", "uwp-csharp-connect-sample");
                            }));
                    return graphClient;
                }

                catch (Exception ex)
                {
                    Debug.WriteLine("Could not create a graph client: " + ex.Message);
                }
            }

            return graphClient;
        }

        /// <summary>
        /// Get Token for User.
        /// </summary>
        /// <returns>Token for user.</returns>
        public static async Task<string> GetTokenForUserAsync()
        {
            AuthenticationResult authResult;
            IEnumerable<IAccount> accounts = await IdentityClientApp.GetAccountsAsync();
            IAccount firstAccount = accounts.FirstOrDefault();
            try
            {
                authResult = await IdentityClientApp.AcquireTokenSilentAsync(Scopes, firstAccount);
            }
            catch (MsalUiRequiredException)
            {
                authResult = await IdentityClientApp.AcquireTokenAsync(Scopes);
            }

            return authResult.AccessToken;
        }

        /// <summary>
        /// Signs the user out of the service.
        /// </summary>
        public static async void SignOut()
        {
            IEnumerable<IAccount> accounts = await IdentityClientApp.GetAccountsAsync();

            foreach (var account in accounts.ToArray())
            {
                await IdentityClientApp.RemoveAsync(account);
            }

            graphClient = null;
        }

    }
}
