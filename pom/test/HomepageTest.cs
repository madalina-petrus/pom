using pom.helpers;

namespace pom.test
{
    [TestFixture]
    public class HomepageTest:BaseTest
    {
        [Test]
        public void HomepageNavigation()
        {

            Pages.Homepage.ClickLogo();
            Pages.Homepage.NavigateToWomen();
            Pages.Homepage.NavigateBack();
            Pages.Homepage.NavigateForward();
            Pages.Homepage.Refresh();
            Pages.Homepage.CorrectPageAfterNavigation();
           
        }

    }
}
