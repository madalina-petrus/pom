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
        private readonly By _emailAdress = By.CssSelector(".col2-set .col-1 .box-content");
        #endregion

        public void ClickLogInButton()
        {


            Driver.WebDriver.FindElement(_logInButton).Submit();
        }

        public void EnterEmailForLogIn(string email)
        {
            var emailField = Driver.WebDriver.FindElement(_emailImputField);
            emailField.Clear();
            emailField.SendKeys(email);
        }

        public void EnterPasswordForLogIn(string password)
        {
            var passwordField = Driver.WebDriver.FindElement(_passwordImputField);
            passwordField.Clear();
            passwordField.SendKeys(password);
        }

        public void VerifyEmailFromContactInformation(string email)
        {
            var text = Driver.WebDriver.FindElements(_emailAdress)[0].Text;
            string[] subs = text.Split("\r\n");
            Assert.That(subs[1], Is.EqualTo(email));
        }
    }
}
