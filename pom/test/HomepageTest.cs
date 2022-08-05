using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using pom.helpers;

namespace pom.test
{
    [TestFixture]
    public class HomepageTest:BaseTest
    {
        [Test]
        public void homepage()
        {

            Pages.Homepage.clickLogo();
           
           
       
            
            Assert.That("http://qa1magento.dev.evozon.com/women.html", Is.EqualTo(Driver.WebDriver.Url));



            //Assert.That("http://qa2magento.dev.evozon.com/women.html", Is.EqualTo("http://qa2magento.dev.evozon.com/women.html"));
        }

    }
}
