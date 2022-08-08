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
        #region Selectors
        private readonly By _logo = By.CssSelector(".logo");
        private readonly By _womenPage = By.CssSelector(".nav-primary li.level0");
        #endregion

        public void ClickLogo()
        {
            Driver.WebDriver.FindElement(_logo).Click();
        }
        public void NavigateToWomen()
        {
            Driver.WebDriver.FindElement(_womenPage).Click();
        }

        public void NavigateBack()
        {
            Driver.WebDriver.Navigate().Back();
        }

        public void NavigateForward()
        {
            Driver.WebDriver.Navigate().Forward();
        }

        public void Refresh()
        {
            Driver.WebDriver.Navigate().Refresh();
        }

        public void CorrectPageAfterNavigation ()
        {
             Assert.That(Driver.WebDriver.Url, Is.EqualTo("http://qa2magento.dev.evozon.com/women.html"));
        }


}
}
