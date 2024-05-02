using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V120.Overlay;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenQA.Selenium.Interactions;
using System.Xml.Linq;
using FluentAssertions.Execution;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
namespace SpecFlowProject1.Support
{
    internal class Student_LoginPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        TimeSpan timespan = new TimeSpan(0,0,60);
        public Student_LoginPage(IWebDriver driver) {

            this.driver = driver;
            wait = new WebDriverWait(driver, timespan);
        }
        public void GivenAUserNavigatesToTheirEmail()
        {
            driver.Navigate().GoToUrl("https://mail.google.com/mail/u/0/#inbox");//"//*[contains(text(),'lydiacapita+834@gmail.com')]"
            driver.FindElement(By.XPath("//*[contains(text(),'lydiacapita+834@gmail.com')]")).Click();// "//*[contains(text(),'register here')]"
            driver.FindElement(By.XPath("//a[contains(text(),'register')]")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            //switch to //body frame
            IWebElement element = driver.FindElement(By.XPath("//button"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", element);
            //FindElement(By.XPath("//button"));
            //driver.SwitchTo().Frame(element);
            //driver.FindElement(By.ClassName("slds-button flow-button__NEXT"));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.FindElements(By.XPath("//div[@class='navigation-bar__right-align']"))[0].Click();
            driver.FindElement(By.Name("First_word_phrase")).SendKeys("get");
            driver.FindElement(By.Name("Second_word_phrase")).SendKeys("over");
            driver.FindElement(By.Name("Third_word_phrase")).SendKeys("here");
            driver.FindElement(By.Name("Date_Of_Birth")).SendKeys("1 Apr 2000");
            driver.FindElement(By.XPath("//button[text()='Next']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[contains(text(),'Next')]")).Click();
        }
        public void GivenAUserOpensTheirConfirmationEmail()
        {
            
            driver.Navigate().GoToUrl("https://portal.dsa.capita.com/");
        }
        public void GivenAUserNavigatesToTheDSAPortal()
        {
            
            driver.Navigate().GoToUrl("https://portal.dsa.capita.com/");
        }

        
        public void GivenAUserNavigatesToTheStudentPortal()
        {
            driver.Navigate().GoToUrl("https://capita9--uat.sandbox.my.site.com/studentPortal/login");
        }
        
        public void WhenTheyEnterStudentDetails()
        {
            driver.FindElement(By.Id("username")).SendKeys("");
            string username = Environment.GetEnvironmentVariable("enter_student_username");
            string password = Environment.GetEnvironmentVariable("enter_student_password");
            driver.FindElement(By.Id("username")).SendKeys(username);//"lydiacapita+123@gmail.com"
            driver.FindElement(By.Id("password")).SendKeys(password);//"Capita@1234"
            driver.FindElement(By.Id("Login")).Click();
        }
        
          
        public void WhenTheyLogIn()
        {
            driver.FindElement(By.Id("fld_identification")).SendKeys("");
            string username = Environment.GetEnvironmentVariable("dsa_student_username");
            string password = Environment.GetEnvironmentVariable("dsa_student_password");
            driver.FindElement(By.Id("fld_identification")).SendKeys(username);//"lydiacapita@gmail.com"
            driver.FindElement(By.Id("fld_password")).SendKeys(password);//"Password1234#"
        }


        public void ThenTheyCanAccessTheirAccount()
        {
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
            driver.FindElement(By.XPath("//span[text()='Appointment Confirm']")).Click();
        }
       
        public void ChangeLanguage(string language) {
            driver.FindElement(By.XPath($"//a[contains(text(), '{language}')]")).Click();
        }
        public void CheckWelsh(string language)
        {
            try {
                driver.FindElement(By.XPath($"//p[contains(text(), '{language}')]")).Click();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }   
            
        }
    }
}
