using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pom.helpers;


namespace pom.test
{
    [TestFixture]
    public class SearchTest:BaseTest
    {
        [Test]

        public void SearchItem()
        {
            string text = "shirt";
            Pages.SearchPage.EnterTextInSearchBar(text);
            Pages.SearchPage.CorrectPageForSearch(text);
            Pages.SearchPage.CorrectTitleForSearch(text);
            
        }
    }
}
