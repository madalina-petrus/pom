
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
        private readonly By _addToCartButton = By.CssSelector(".add-to-cart-buttons");
       
        #endregion
        public void getRandomProduct()
        {
            var list = Driver.WebDriver.FindElements(_productsList);
            Random rnd = new Random();
            int randIndex = rnd.Next(list.Count-1);
            IWebElement random = list[randIndex];
            random.Click();
        }

        public void addProductToCart()
        {
            Driver.WebDriver.FindElement(_addToCartButton).Click();
;        }


    }
}
