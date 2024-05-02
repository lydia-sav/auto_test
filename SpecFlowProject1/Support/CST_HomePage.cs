using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Support
{
    
    internal class CST_HomePage
    {
        private IWebDriver driver;
        public CST_HomePage(IWebDriver driver)
        {

            this.driver = driver;
        }
        public void WhenTheyAddNoteCST(string accountName)
        {
            Thread.Sleep(2000);
            //driver.FindElement(By.XPath("//lightning-icon[@icon-name='utility:note']")).Click();
            driver.FindElement(By.XPath("//button[@aria-label='Search']")).Click();  //"//span[@title='John Smith']"
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[contains(@placeholder,'Search')]")).SendKeys(accountName);
            Thread.Sleep(2000);
            driver.FindElements(By.XPath($"//span[@title='{accountName}']")).ToArray()[0].Click();
            Thread.Sleep(2000);

            IWebElement element = driver.FindElements(By.XPath("//span[@title='Notes']")).ToArray()[0];
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", element);
            Thread.Sleep(2000);
            element = driver.FindElements(By.XPath("//a[@title= 'New']")).ToArray()[1];
            executor.ExecuteScript("arguments[0].click();", element);
            Thread.Sleep(2000);
        }
        public void WhenTheyEnterNoteDetails(string title, string body)
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@class='slds-input']")).SendKeys(title);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@role='textbox']")).SendKeys(body);
        }
        public void ThenTheySubmitNote()
        {
            driver.FindElement(By.XPath("//button[contains(text(), 'Add to Records')]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//span[contains(text(), 'Done')]")).Click();
        }
    }
}
