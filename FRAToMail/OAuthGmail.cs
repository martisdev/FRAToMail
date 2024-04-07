using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.IO;
using System.Threading;
using static Google.Apis.Gmail.v1.GmailService;

namespace FRAToMail
{
    public class OAuthGmail
    {
        #region FIELDS
        string _ApplicationName;


        #endregion

        #region PROPERTIES

        public GmailService Service { get; }

        #endregion

        #region CONSTRUCTOR
        public OAuthGmail(string clientID, string clientSecret, string[] scopes ,string credentialPath, string AppName)
        {
            _ApplicationName = AppName;
            Service = Authenticate(clientID, clientSecret, scopes, credentialPath);
        }

        #endregion

        #region PRIVATE METHODS
        private GmailService Authenticate(string clientId, string clientSecret, string[] scopes, string credPath)
        {
            // Create OAuth 2.0 authorization flow
            var flow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
            {
                ClientSecrets = new ClientSecrets
                {
                    ClientId = clientId,
                    ClientSecret = clientSecret
                },
                Scopes = scopes,
                DataStore = new FileDataStore(credPath, true),
            });

            // Authorize the application
            var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                flow.ClientSecrets,
                new[] { GmailService.Scope.GmailSend },
                "user",
                CancellationToken.None,
                new FileDataStore(credPath, true)).Result;

            // Create Gmail service
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = _ApplicationName ,
            });

            return service;
        }

        #endregion

    }
}
