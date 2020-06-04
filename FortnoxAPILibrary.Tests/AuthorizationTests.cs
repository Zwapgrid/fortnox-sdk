using FortnoxAPILibrary.Connectors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FortnoxAPILibrary.Tests
{
    [TestClass]
    public class AuthorizationTests : ConnectorTestsBase
    {
        private readonly AuthorizationConnector _connector;

        public AuthorizationTests()
        {
            _connector = new AuthorizationConnector();
        }

        [TestMethod]
        [Ignore("Needs a new authorization code each time")]
        public void GetAccessToken()
        {
            //Set auth code here to test
            const string authorizationCode = "";

            var accessToken = _connector.GetAccessToken(authorizationCode, ClientSecret);

            MyAssert.HasNoError(_connector);
            
            Assert.IsNotNull(accessToken);
        }
    }
}