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
            var searchbar = Driver.WebDriver.FindElement(_searchBar);
            searchbar.Clear();
            searchbar.SendKeys(text);
            searchbar.Submit();
        }

        public void CorrectPageForSearch(string text)
        {
            Assert.That("http://qa2magento.dev.evozon.com/catalogsearch/result/?q=" + text, Is.EqualTo(Driver.WebDriver.Url));
            Assert.That("SEARCH RESULTS FOR '" + text.ToUpper() + "'", Is.EqualTo(Driver.WebDriver.FindElement(_searchPageTitle).Text));
        }

    }
}
