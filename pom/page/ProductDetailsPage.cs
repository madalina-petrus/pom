
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using pom.helpers;
using System.Collections.Generic;

namespace pom.page
{
    public class ProductDetailsPage
    {
        #region Selectors
        private readonly By _productsList = By.CssSelector(".products-grid .item");
        private readonly By _addToCartButton = By.CssSelector(".add-to-cart-buttons .button");
        private readonly By _colorList = By.CssSelector("#configurable_swatch_color li");
        private readonly By _sizeList = By.CssSelector("#configurable_swatch_size li");
        private readonly By _stockLabel = By.CssSelector("span.value");


        #endregion
        public void GetRandomProduct()
        {
            var list = Driver.WebDriver.FindElements(_productsList);
            Random rnd = new Random();
            int randIndex = rnd.Next(list.Count - 1);
            IWebElement random = list[randIndex];
            random.Click();
        }


        public void SelectRandomColor()
        {
            var list = Driver.WebDriver.FindElements(_colorList);
            Random rnd = new Random();
            int randIndex = rnd.Next(list.Count - 1);
            IWebElement random = list[randIndex];
            random.Click();
            ; }

        public void SelectRandomSize()
        {
            var list = Driver.WebDriver.FindElements(_sizeList);
            Random rnd = new Random();
            int randIndex = rnd.Next(list.Count - 1);
            IWebElement random = list[randIndex];
            random.Click();
        }

        public void SelectAvailableProduct()
        {
            Driver.WebDriver.FindElements(_productsList)[0].Click();
            Driver.WebDriver.FindElements(_colorList)[0].Click();
            Driver.WebDriver.FindElements(_sizeList)[1].Click();

        }

        public void SelectUnavailableProduct()
        {
            Driver.WebDriver.FindElements(_productsList)[0].Click();
            Driver.WebDriver.FindElements(_colorList)[0].Click();
            Driver.WebDriver.FindElements(_sizeList)[0].Click();

        }

        public bool DisabledAddToCartButton()
        {
           return Driver.WebDriver.FindElement(_addToCartButton).Enabled;
        }

        public void AddToCart()
        {
            if (Driver.WebDriver.FindElement(_stockLabel).Text.Equals(Constants.PRODUCT_IN_STOCK));
            Driver.WebDriver.FindElement(_addToCartButton).Click();

        }

        public void AddProductToCart()
        {
            
        }



        


    }
}
