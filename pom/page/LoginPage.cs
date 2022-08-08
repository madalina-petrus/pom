using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using pom.helpers;

namespace pom.page
{
    public class LoginPage
    {
        #region Selectors
        private readonly By _emailImputField = By.CssSelector("#email");
        private readonly By _passwordImputField = By.CssSelector("#pass");
        private readonly By _logInButton = By.CssSelector("#send2");
        #endregion

        public void EnterDataForLogIn(string email,string password)
        {
            var emailField = Driver.WebDriver.FindElement(_emailImputField);
            emailField.Clear();
            emailField.SendKeys(email);
            var passwordField = Driver.WebDriver.FindElement(_passwordImputField);
            passwordField.Clear();
            passwordField.SendKeys(email);
            Driver.WebDriver.FindElement(_logInButton).Submit();
        }
    }
}
