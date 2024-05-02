using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Support
{
    
    internal class Student_HomePage
    {
        private IWebDriver driver;
        public Student_HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WhenTheyScheduleAnAppointment()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@title='Schedule Assessment']")).Click();
            driver.FindElement(By.XPath("//button[text()='Next']")).Click();
        }
    }
}
