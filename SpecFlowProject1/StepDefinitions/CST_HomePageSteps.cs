using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BoDi;
using SpecFlowProject1.Support;
using cdafn_base.AzDOIntegration.Support;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CST_HomePageSteps
    {
        private IWebDriver driver;
        SharedData sharedData;
        CST_HomePage homePage;
        CST_HomePageSteps(IWebDriver driver, SharedData sharedData)
        {
            this.driver = driver;
            this.sharedData = sharedData;
            this.homePage = new CST_HomePage(driver);
        }
        [When(@"a user adds a note to account '([^']*)'")]
        public void WhenAUserAddsANoteToAccount(string accountName)
        {
            homePage.WhenTheyAddNoteCST(accountName);
        }

        [When(@"a user fills in that note '([^']*)', '([^']*)'")]
        public void WhenAUserFillsInThatNote(string title, string body)
        {
            homePage.WhenTheyEnterNoteDetails(title, body);
        }


        [Then(@"a user can add that note to records")]
        public void ThenAUserCanAddThatNoteToRecords()
        {
            homePage.ThenTheySubmitNote();
        }
    }
}

