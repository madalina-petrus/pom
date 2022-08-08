using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pom.helpers;
using pom.page;
using SeleniumExtras.PageObjects;

namespace pom.test
{
    public static class Pages
    {
        public static Homepage Homepage => InitPage(new Homepage());
        public static SearchPage SearchPage => InitPage(new SearchPage());
        public static HeaderPage HeaderPage => InitPage(new HeaderPage());
        public static T InitPage<T>(T page)
        {
            PageFactory.InitElements(Driver.WebDriver, page);
            return page;
        }
    }
}
