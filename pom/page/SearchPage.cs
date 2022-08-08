using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using pom.helpers;

namespace pom.page
{
    public class SearchPage
    {
        #region Selectors
        private readonly By _searchBar = By.CssSelector("#search");
        private readonly By _searchPageTitle = By.CssSelector(".page-title");
        #endregion

        public void EnterTextInSearchBar(string text)
        {
            Driver.WebDriver.FindElement(_searchBar).Clear();
            Driver.WebDriver.FindElement(_searchBar).SendKeys(text);
            Driver.WebDriver.FindElement(_searchBar).Submit();
        }

        public void CorrectPageForSearch(string text)
        {
            Assert.That(Driver.WebDriver.Url, Is.EqualTo("http://qa2magento.dev.evozon.com/catalogsearch/result/?q=" + text));
        }

        public void CorrectTitleForSearch(string text)
        {
            ;
            Assert.That(Driver.WebDriver.FindElement(_searchPageTitle).Text, Is.EqualTo("SEARCH RESULTS FOR '"+text.ToUpper()+"'"));

        }
    }
}
