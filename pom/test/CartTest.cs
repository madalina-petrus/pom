using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pom.helpers;

namespace pom.test
{
    [TestFixture]
    public class CartTest: BaseTest
    {
        [Test]
        public void addProductToCart()
        {
            //Pages.AccountPage.AccountList();
            //Pages.AccountPage.GoToLogIn();

            Pages.HeaderPage.NavigateToTopsAndBlouses();
            Pages.ProductDetailsPage.AddFirstProductToCart();
            Assert.That(Pages.HeaderPage.GetProductCount(), Is.EqualTo("1"));
        }
    }
}
