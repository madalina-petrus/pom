using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pom.helpers;

namespace pom.test
{
    [TestFixture]
    public class HeaderTest:BaseTest
    {
        [Test]
        public void SetLanguageInFrance()
        {
            Pages.HeaderPage.ChangeDefaultLanguageInFrance();
            Pages.HeaderPage.LanguageSetForFrance();
        }

    }
}
