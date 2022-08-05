using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using pom.helpers;

namespace pom.page
{
    public class Homepage
    {
        private readonly By _logo = By.CssSelector(".logo");
        private readonly By _page = By.CssSelector(".nav-primary li.level0");

        public void clickLogo()
        {
            Driver.WebDriver.FindElement(_logo).Click();
        }

        public void navigateToWomen()
        {
            Driver.WebDriver.FindElement(_page).Click();
        }

        public void navigateBack()
        {
            Driver.WebDriver.Navigate().Back();
        }

        public void navigateForward()
        {
            Driver.WebDriver.Navigate().Forward();
        }

        public void refresh()
        {
            Driver.WebDriver.Navigate().Refresh();
        }


    }
}
