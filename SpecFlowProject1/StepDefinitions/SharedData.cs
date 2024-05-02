//using BrowserStack;
//using cdafn_base.AzDOIntegration.StubData;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace cdafn_base.AzDOIntegration.Support
{
    public class SharedData
    {
        public IWebDriver TestDriver { get; set; }
        public IWebDriver browserStackDriver { get; set; }
        //public Local browserStackLocal { get; set; }

        public string Step { get; set; }
        public string UID { get; private set; }
        public DateTime CurrentDate { get; private set; }

        public string DateTimeStamp { get { return DateTime.Now.ToString("yyyyMMddHHmmss"); } }

        public string Id { get; set; }
        public string correlationId { get; set; }
        public static string scenarioName { get; set; }

        public string Type4 { get; set; }

        public string TypeOfApplication { get; set; }
        public static ScenarioStepContext scenarioStepContext { get; set; }
        public string customernumber { get; set; }
        public string productfee1 { get; set; }
        public static int testScenarioCount { get; set; }

        public string productCode1 { get; set; }
        public string productCode2 { get; set; }

        public string browserName { get; set; }
        public string browserversion { get; set; }
        public string productfee2 { get; set; }

        public string MainWindowId { get; set; }

        public Dictionary<string, string> TestData { get; set; }

        public Dictionary<string, string> DropdownOptionTestData { get; set; }

        public static string Account_Number { get; set; }
        public Dictionary<string,string> Base64ScreenshotData { get; set; }

        public void AddToBase64ScreenshotData(string title, string codedImage) {
            string timestamp = " timestamp - " + DateTime.Now.ToString("HH:mm:ss");
            Base64ScreenshotData.Add(title+timestamp, codedImage);
        }
        public IWebDriver NewDriver { get; set; }
        public static IWebDriver NewDriverTest { get; set; }

        public string email { get; set; }
        public string mobile { get; set; }
        public Dictionary<string, string> scenarioTestName { get; set; }
        public string[] tags { get; set; }

        public string current_Browser { get; set; }
        public string current_user { get; set; }
        public string current_pword { get; set; }
        public string current_url{ get; set; }
        public string currentAppNum_fromBroker { get; set; }
        public int countNumber { get; set; }

        public string new_pword { get; set; }

        public string AddressGUIDInString { get; set; }

        public Byte[] AccountGuid { get; set; }

        public string loanType { get; set; }

        public string password { get; set; }

        public string productfee { get; set; }

        public string customerName { get; set; }

        public bool addedtomortgagebalance { get; set; }

        public string applicationType { get; set; }

        public string firstProductId { get; set; }

        public string secondProductId { get; set; }
        public string accessType { get; set; }

        public string loanAmount { get; set; }

        public string headerDeal_1 { get; set; }
        public string headerDeal_2 { get; set; }
        public string headerDeal_3 { get; set; }
        public string headerDeal_4 { get; set; }
        public string headerDeal_5 { get; set; }
        public string repayTypeDeal_1 { get; set; }
        public string repayTypeDeal_2 { get; set; }
        public string repayTypeDeal_3 { get; set; }
        public string repayTypeDeal_4 { get; set; }
        public string repayTypeDeal_5 { get; set; }
        public string loanAmountDeal_1 { get; set; }
        public string loanAmountDeal_2 { get; set; }
        public string loanAmountDeal_3 { get; set; }
        public string loanAmountDeal_4 { get; set; }
        public string loanAmountDeal_5 { get; set; }
        public string productCodeDeal_1 { get; set; }
        public string productCodeDeal_2 { get; set; }
        public string productCodeDeal_3 { get; set; }
        public string productCodeDeal_4 { get; set; }
        public string productCodeDeal_5 { get; set; }
        public string productFeeDeal_1 { get; set; }
        public string productFeeDeal_2 { get; set; }
        public string productFeeDeal_3 { get; set; }
        public string productFeeDeal_4 { get; set; }
        public string productFeeDeal_5 { get; set; }
        public string monthlyPaymentsDeal_1 { get; set; }
        public string monthlyPaymentsDeal_2 { get; set; }
        public string monthlyPaymentsDeal_3 { get; set; }
        public string monthlyPaymentsDeal_4 { get; set; }
        public string monthlyPaymentsDeal_5 { get; set; }
        public string mortgageTermDeal_1 { get; set; }
        public string mortgageTermDeal_2 { get; set; }
        public string mortgageTermDeal_3 { get; set; }
        public string mortgageTermDeal_4 { get; set; }
        public string mortgageTermDeal_5 { get; set; }

        public SharedData()
        {
            UID = DateTime.Now.ToString("yyyyMMddHHmmss");
            CurrentDate = DateTime.Now;
            Base64ScreenshotData = new Dictionary<string, string>();
            scenarioTestName = new Dictionary<string, string>();
        }
    }
}
