using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pom.helpers;

namespace pom.test
{
    [TestFixture]
    public class LoginTest: BaseTest
    {
        [Test]
        [TestCase(Constants.VALID_EMAIL, Constants.VALID_PASSWORD)]
        [TestCase("q@yahoo.com", "ceva")]
        public void LoginAccount(string email,string password)
        {
            Pages.AccountPage.AccountList();
            Pages.AccountPage.GoToLogIn();
            Pages.LoginPage.EnterDataForLogIn(email, password);
            Pages.LoginPage.VerifyEmailFromContactInformation(email);

        }
    }
}
