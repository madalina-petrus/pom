using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pom.helpers;

namespace pom.test
{
    [TestFixture]
    public class ProductDetailsTest:BaseTest
    {
        [Test]
        public void OutOfStockAddButton()
        {
            Pages.HeaderPage.NavigateToTopsAndBlouses();
            Pages.ProductDetailsPage.SelectUnavailableProduct();
            Assert.IsFalse(Pages.ProductDetailsPage.DisabledAddToCartButton());

        }

    }
}
