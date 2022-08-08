using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using pom.helpers;

namespace pom.page
{
    public class AccountPage
    {
        #region
        private readonly By _accountList = By.CssSelector(".account-cart-wrapper");
        private readonly By _logInButton = By.CssSelector(".skip-content .links .last");
        #endregion
        public void AccountList()
        {

            IWebElement account = Driver.WebDriver.FindElement(_accountList);
            account.Click();

        }

        public void GoToLogIn()
        {

            IWebElement logIn = Driver.WebDriver.FindElement(_logInButton);
            logIn.Click();
        }
    }
}
