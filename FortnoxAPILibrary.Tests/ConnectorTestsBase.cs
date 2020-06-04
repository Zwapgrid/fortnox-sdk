using System;

namespace FortnoxAPILibrary.Tests
{
    public abstract class ConnectorTestsBase
    {
        //Enter these values to override test credentials and environment variable credentials.
        //DO NOT CHECK THESE CREDENTIALS IN. Also make sure this is not production account, these tests will make changes to the data.
        protected static string AccessToken = "";
        protected static string ClientSecret = "";
        
        protected ConnectorTestsBase()
        {
            //Set from env variables
            if (string.IsNullOrEmpty(AccessToken))
                AccessToken = Environment.GetEnvironmentVariable("Fortnox_AccessToken");
            if (string.IsNullOrEmpty(ClientSecret))
                ClientSecret = Environment.GetEnvironmentVariable("Fortnox_ClientSecret");
            
            //Set from test credentials
            if (string.IsNullOrEmpty(AccessToken))
                AccessToken = TestCredentials.Access_Token;
            if (string.IsNullOrEmpty(ClientSecret))
                ClientSecret = TestCredentials.Client_Secret;
            
            if (string.IsNullOrEmpty(AccessToken) || string.IsNullOrEmpty(ClientSecret))
                throw new ArgumentException("You have to add access token and client secret to be able to run these tests");
        }

        protected static void CheckForError<TE>(IEntityConnector<TE> connector)
        {
            if (connector.HasError)
                throw new Exception($"{connector.Error.Message} ({connector.Error.Code})");
        }
    }
}