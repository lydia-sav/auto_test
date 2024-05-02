using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Support
{
    internal class CST_LoginPage
    {
 
        IWebDriver driver;
        public CST_LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GivenAUserNavigatesToTheCSTPortal()
        {
            driver.Navigate().GoToUrl("https://capita9--uat.sandbox.my.salesforce.com/");
        }
        public void WhenTheyEnterCSTDetails()
        {
            driver.FindElement(By.Id("username")).SendKeys("");
            string username = Environment.GetEnvironmentVariable("cst_username");
            string password = Environment.GetEnvironmentVariable("cst_password");
            driver.FindElement(By.Id("username")).SendKeys(username);//"centralsupportteam@cst.com"
            driver.FindElement(By.Id("password")).SendKeys(password);//"Capita@1234"
            driver.FindElement(By.Id("Login")).Click();
        }
    }
}
