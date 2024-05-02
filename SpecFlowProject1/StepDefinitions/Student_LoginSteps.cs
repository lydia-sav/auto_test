using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BoDi;
using SpecFlowProject1.Support;
using cdafn_base.AzDOIntegration.Support;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class Student_LoginSteps
    {
        private IWebDriver driver;
        SharedData sharedData;
        Student_LoginPage loginPage;
        public Student_LoginSteps(IWebDriver driver, SharedData sharedData)
        {
            this.sharedData = sharedData;
            loginPage = new Student_LoginPage(driver);
        }


        [When(@"a student navigates to their email account")]
        public void WhenAStudentNavigatesToTheirEmailAccount()
        {
            loginPage.GivenAUserNavigatesToTheirEmail();
        }
        [Given(@"a student navigates to their email account")]
        public void GivenAStudentNavigatesToTheirEmailAccount()
        {
            loginPage.GivenAUserNavigatesToTheirEmail();
        }


        [When(@"a user adds an account")]
        public void WhenAUserAddsAnAccount()
        {
            throw new PendingStepException();
        }

        [Given(@"A user navigates to the student salesforce portal")]
        public void GivenAUserNavigatesToTheStudentSalesforcePortal()
        {
            loginPage.GivenAUserNavigatesToTheStudentPortal();
        }
        [When(@"a user logs into the student portal")]
        public void WhenAUserLogsIntoTheStudentPortal()
        {
            loginPage.WhenTheyEnterStudentDetails();
        }
        

        [Given(@"A user navigates to the DSA portal")]
        public void GivenAUserNavigatesToTheDSAPortal()
        {
            loginPage.GivenAUserNavigatesToTheDSAPortal();
        }

        [When(@"they log in")]
        public void WhenTheyLogIn()
        {
            loginPage.WhenTheyLogIn();

        }

        [Then(@"they can access their account")]
        public void ThenTheyCanAccessTheirAccount()
        {
            loginPage.ThenTheyCanAccessTheirAccount();

        }
        
        [When(@"they select their prefered language '([^']*)'")]
        public void WhenTheySelectTheirPreferedLanguage(string cymraeg)
        {
            loginPage.ChangeLanguage(cymraeg);
        }

        [Then(@"they can see the welcome screen in Welsh '([^']*)'")]
        public void ThenTheyCanSeeTheWelcomeScreenInWelsh(string text)
        {
            loginPage.CheckWelsh(text);   
        }


    }
}
