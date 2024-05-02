using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Support
{
    [Binding]
    public sealed class CST_LoginPageSteps
    {
        CST_LoginPage cST_LoginPage;
        IWebDriver driver;
        public CST_LoginPageSteps(IWebDriver driver)
        {
            this.driver = driver;
            this.cST_LoginPage = new CST_LoginPage(driver);
        }
        
        [Given(@"A user navigates to the CST salesforce portal")]
        public void GivenAUserNavigatesToTheCSTSalesforcePortal()
        {
            cST_LoginPage.GivenAUserNavigatesToTheCSTPortal();
        }

        [When(@"a user logs in as a CST user")]
        public void WhenAUserLogsInAsACSTUser()
        {
            cST_LoginPage.WhenTheyEnterCSTDetails();
        }

    }
}
