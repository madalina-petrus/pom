using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace pom.helpers
{
    public  class BaseTest
    {
        
        [SetUp]
        public void Setup()
        {
            Driver.WebDriver = new ChromeDriver("D://internship//TestSeleniumNunit//TestSeleniumNunit//driver");
            Driver.WebDriver.Navigate().GoToUrl("http://qa2magento.dev.evozon.com");
            Driver.WebDriver.Manage().Window.Maximize();
        }

        [TearDown]
        public void finish()
        {
            Driver.WebDriver.Quit();
        }

    }
}
