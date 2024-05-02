using cdafn_base.AzDOIntegration.Support;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Support
{
    [Binding]
    internal class CST_RegistrationPageSteps
    {
        IWebDriver driver;
        CST_RegistrationPage registrationPage;
        public CST_RegistrationPageSteps(IWebDriver driver, SharedData sharedData)
        {
            this.driver = driver;
            this.registrationPage = new CST_RegistrationPage(driver);
        }
        [When(@"a user selects add a new student account")]
        public void WhenAUserSelectsAddANewStudentAccount()
        {
            registrationPage.WhenTheySelectAddNewStudentAccount();
        }
        [When(@"a user fills in student account details")]
        public void WhenAUserFillsInStudentAccountDetails()
        {
            registrationPage.WhenTheyEnterStudentAccountDetails();
        }
    }
}
