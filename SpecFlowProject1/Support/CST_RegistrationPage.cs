using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Support
{
    internal class CST_RegistrationPage
    {
        IWebDriver driver;
        public CST_RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void JavaScriptClick(IWebElement element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", element);
        }
        public void SendKeysToInput(string input, string value)
        {
            driver.FindElement(By.XPath($"//input[@name='{input}']")).SendKeys(value);
        }
        public void WhenTheySelectAddNewStudentAccount()
        {
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//div[@class='slds-icon-waffle']")).Click();//"//button[@class='slds-button slds-show']"
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@placeholder='Search apps and items...']")).SendKeys("Accounts");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//b[text()='Accounts']")).Click();
            Thread.Sleep(5000);
            //driver.FindElement(By.XPath("//span[contains(text(), 'Accounts')]")).Click();
            // Thread.Sleep(5000);
            driver.FindElements(By.XPath("//a[@title='New']")).ToArray()[0].Click();
            Thread.Sleep(5000);
            IWebElement element = driver.FindElement(By.XPath("//input[@value='0122z000002W1qgAAC']"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click();", element);
            driver.FindElement(By.XPath("//span[text()='Next']")).Click();
            //driver.FindElement(By.XPath("//div[@class='tooltipTrigger tooltip-trigger uiTooltip']")).Click();
            // driver.FindElement(By.XPath("//div[@part='input-container']//input[contains(@placeholder, 'Search apps')]")).SendKeys("Accounts");
            //
        }
        public void SelectDropdown(string arialabel, string option)
        {
            IWebElement element;
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            element = driver.FindElement(By.XPath($"//button[@aria-label='{arialabel} - Current Selection: --None--']"));
            executor.ExecuteScript("arguments[0].click();", element);
            element = driver.FindElement(By.XPath($"//lightning-base-combobox-item[@data-value='{option}']"));
            executor.ExecuteScript("arguments[0].click();", element);
            Thread.Sleep(1000);
        }
        public string GenerateRandomNumber(int length)
        {
            const string chars = "0123456789";
            Random random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }
        public void WhenTheyEnterStudentAccountDetails()
        {
            Thread.Sleep(2000);
            IWebElement element;
            Actions actions = new Actions(driver);
            driver.FindElement(By.XPath("//textarea")).SendKeys("autism");
            element = driver.FindElement(By.XPath("//span[@title='AUTISM']"));//AUTISM
            actions.MoveToElement(element);
            //actions.Click(element);
            JavaScriptClick(element);

            IWebElement[] elementsArr = driver.FindElements(By.XPath("//button[@title='Move selection to Chosen']")).ToArray();
            actions.MoveToElement(elementsArr[0]);
            //actions.Click(elementsArr[0]);
            JavaScriptClick(elementsArr[0]);
            element = driver.FindElement(By.XPath("//div[@data-value='SMS']"));
            actions.MoveToElement(element);
            actions.Click(element);
            actions.MoveToElement(elementsArr[1]);
            actions.Click(elementsArr[1]);

            //IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            SendKeysToInput("firstName", "John");
            SendKeysToInput("lastName", "Smith");
            SendKeysToInput("PersonEmail", $"lydiacapita+{GenerateRandomNumber(3)}@gmail.com");
            SendKeysToInput("Phone", "07812345678");
            SendKeysToInput("City__c", "London");
            SendKeysToInput("Postcode__c", "E1 6AN");
            SendKeysToInput("AddressLine1__c", "123 Fake Street");
            SendKeysToInput("County__c", "North");
            SendKeysToInput("CRN__c", GenerateRandomNumber(10));
            SendKeysToInput("Territory__c", "UK");

            //element = driver.FindElement(By.XPath("//input[@name='firstName']"));
            //element.SendKeys("John");
            //element = driver.FindElement(By.XPath("//input[@name='lastName']"));
            //element.SendKeys("Smith");
            //element = driver.FindElement(By.XPath("//input[@name='PersonEmail']"));
            //element.SendKeys("lydiacapita@gmail.com");
            //Select salutation
            SelectDropdown("Salutation", "Mr.");
            //select funding body
            SelectDropdown("Funding Body", "SFE");
            //select sex
            //SelectDropdown("Sex", "M"); 
            //mode of study
            SelectDropdown("Mode of Study", "Full time");
            SelectDropdown("Assessment Type", "Full Assessment");
            SelectDropdown("Zone", "Zone 1");//
            SelectDropdown("Preferred Language", "GB");
            SelectDropdown("Preferred Contact Method", "E");
            SelectDropdown("Contact Preference", "N");
        }
    }
}
