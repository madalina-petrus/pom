using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using pom.helpers;

namespace pom.page
{
    public class HeaderPage
    {
        #region Selectors
        private readonly By _languageCombobox = By.CssSelector("#select-language");
        private readonly By _womenPage = By.CssSelector(".nav-primary li.level0");
        private readonly By _topsAndBlouses = By.CssSelector(".level1.nav-1-2");
        private readonly By _minicartCount = By.CssSelector(".count");
        #endregion

        public void ChangeDefaultLanguageInFrance()
        {
            SelectElement select = new SelectElement(Driver.WebDriver.FindElement(_languageCombobox));
            select.SelectByIndex(1);
        }

        public void LanguageSetForFrance()
        {
            SelectElement select = new SelectElement(Driver.WebDriver.FindElement(_languageCombobox));
            Assert.That(select.SelectedOption.Text, Is.EqualTo("French"));
        }

        public void NavigateToTopsAndBlouses()
        {
            Actions actions = new Actions(Driver.WebDriver);
            actions.MoveToElement(Driver.WebDriver.FindElement(_womenPage));
            actions.MoveToElement(Driver.WebDriver.FindElement(_topsAndBlouses));
            actions.Click().Build().Perform();

        }

        public string GetProductCount()
        {
            return Driver.WebDriver.FindElement(_minicartCount).Text;
        }
    }
}
