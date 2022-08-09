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
        public void LoginValidAccount(string email,string password)
        {
            Pages.AccountPage.AccountList();
            Pages.AccountPage.GoToLogIn();
            Pages.LoginPage.EnterEmailForLogIn(email);
            Pages.LoginPage.EnterPasswordForLogIn(password);
            Pages.LoginPage.ClickLogInButton();
            Assert.IsTrue(Pages.LoginPage.VerifyEmailFromContactInformation(email));

        }

        [Test]
        [TestCase(Constants.VALID_EMAIL, "ertyuio", "Invalid login or password.")]
        [TestCase(Constants.VALID_EMAIL, "", "Login and password are required.")]
        [TestCase("q@yahoo.com", "parola", "Invalid login or password.")]
        public void LoginInvalidAccount(string email, string password,string msg)
        {
            Pages.AccountPage.AccountList();
            Pages.AccountPage.GoToLogIn();
            Pages.LoginPage.EnterEmailForLogIn(email);
            Pages.LoginPage.EnterPasswordForLogIn(password);
            Pages.LoginPage.ClickLogInButton();
            Assert.IsTrue(Pages.LoginPage.ErrorMessageForInvalidData(msg));
        }
    }
}
