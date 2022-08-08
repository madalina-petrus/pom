using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using pom.helpers;

namespace pom.page
{
    public class HeaderPage
    {
        #region Selectors
        private readonly By _languageCombobox = By.CssSelector("#select-language");
        #endregion

        public void ChangeDefaultLanguageInFrance()
        {
            SelectElement select = new SelectElement(Driver.WebDriver.FindElement(_languageCombobox));
            select.SelectByIndex(1);
        }

        public void LanguageSetForFrance()
        {
            SelectElement select = new SelectElement(Driver.WebDriver.FindElement(By.CssSelector("#select-language")));
            Assert.That(select.SelectedOption.Text, Is.EqualTo("French"));
        }
    }
}
