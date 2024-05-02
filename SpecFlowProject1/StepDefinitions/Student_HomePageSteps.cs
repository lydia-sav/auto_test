using cdafn_base.AzDOIntegration.Support;
using OpenQA.Selenium;
using SpecFlowProject1.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class Student_HomePageSteps
    {
        private IWebDriver driver;
        SharedData sharedData;
        Student_HomePage homePage;
        public Student_HomePageSteps(IWebDriver driver, SharedData sharedData)
        {
            this.sharedData = sharedData;
            homePage = new Student_HomePage(driver);
        }
        [When(@"a user fills in appointment details")]
        public void WhenAUserFillsInAppointmentDetails()
        {
            homePage.WhenTheyScheduleAnAppointment();
        }
    }
}
