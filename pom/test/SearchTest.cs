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
        [TestCase("Ford")]
        [TestCase("ShIrt")]
        public void SearchItem(string text)
        {
            
            Pages.SearchPage.EnterTextInSearchBar(text);
            Pages.SearchPage.CorrectPageForSearch(text);
            
            
        }
    }
}
