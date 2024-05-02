using BoDi;
using cdafn_base.AzDOIntegration.Support;
//using Microsoft.Edge.SeleniumTools;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using TechTalk.SpecFlow;
namespace cdafn_base.StepDefinitions
{
    [Binding]
    public class Hooks
    {
        private static string SCREENSHOT_FOLDER_PATH = @"C:\screenshots";
        [ThreadStatic]
        public BrowserDriver driver;
        RemoteWebDriver rd_driver;
        public readonly IObjectContainer objectContainer;
        public ScenarioContext scenarioContext;
        public static FeatureContext featureContext;
        public static int count = 0;
        public static int count1 = 0;
        public Hooks(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            this.objectContainer = objectContainer;
            this.scenarioContext = scenarioContext;
        }
        [BeforeScenario]
        public void CreateWebDriver()
        {
            string username = "P50008343";
            // Create and configure a concrete instance of IWebDriver
            
            ChromeOptions option = new ChromeOptions();

            //option.AddArguments("incognito");
            option.AddArguments($@"user-data-dir=c:\Users\{username}\AppData\Local\Google\Chrome\User Data\");
            //option.AddArguments("disable-extensions");
            //option.AddArguments("disable-popup-blocking");
            //option.AddArgument("no-sandbox");
            //option.AddArguments("--ignore-ssl-errors=yes");
            //option.AddArguments("--ignore-certificate-errors");
            //option.AddArgument("--ignore-certificate-errors-spki-list");
            //option.AddArguments("start-maximized");
            //option.AddArgument("--ignore-certificate-errors-spki-list");
            //option.AddArgument("--enable-features=AllowSyncXHRInPageDismissal");
            //option.AddArgument("disable-gpu");
            //option.AddArgument("window-size=1042,786");
            IWebDriver driver = new ChromeDriver(Directory.GetCurrentDirectory(), option);
            {

            };
            driver.Url = "https://accounts.google.com/";
            //Console.ReadKey();
            Console.WriteLine("Headless not allowed and incognito mode not allowed");

            // Make this instance available to all other step definitions
            objectContainer.RegisterInstanceAs(driver);
        }

        [AfterScenario]
        public void DestroyWebDriver()
        {
            IWebDriver driver = objectContainer.Resolve<IWebDriver>();

            driver.Close();
            driver.Dispose();
            
        }

        #region Miscellaneous support methods 


        public class BrowserDriver
        {
            //private RemoteWebDriver driver;
            private ChromeDriver driver;
            private ScenarioContext scenarioContext;
            SharedData sharedData;

            public BrowserDriver(ScenarioContext scenarioContext, SharedData sharedData)
            {
                this.scenarioContext = scenarioContext;
                this.sharedData = sharedData;
            }
            [BeforeTestRun]
            public IWebDriver SelectBrowser(string browserType)
            {
                string debug = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string authPath = Path.Combine(debug, "../../auth.crx");
                if (browserType.Contains("Chrome"))
                {
                    browserType = "Chrome";
                }
                else if (browserType.Contains("Edge"))
                {
                    browserType = "Edge";
                }
                string isPipeline = Environment.GetEnvironmentVariable("IsPipeline");
                Console.WriteLine("BROWSER RUNNING ON PIPELINE: " + isPipeline + "");

                switch (browserType)
                {
                    case "Chrome":

                        ChromeOptions option = new ChromeOptions();

                        option.AddArguments("incognito");
                        option.AddArguments("disable-extensions");
                        option.AddArguments("disable-popup-blocking");
                        option.AddArgument("no-sandbox");
                        option.AddArguments("--ignore-ssl-errors=yes");
                        option.AddArguments("--ignore-certificate-errors");
                        option.AddArgument("--ignore-certificate-errors-spki-list");
                        option.AddArguments("start-maximized");
                        //option.AddArgument("window-size=1042,786");
                        option.AddArgument("--ignore-certificate-errors-spki-list");
                        option.AddArgument("--enable-features=AllowSyncXHRInPageDismissal");
                        option.AddArgument("disable-gpu");

                        this.driver = new ChromeDriver(option);
                        this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                        Console.WriteLine("Headless not allowed and incognito mode not allowed");

                        break;
                //    case "Firefox":
                //        FirefoxOptions optionsff = new FirefoxOptions();
                //        this.driver = new FirefoxDriver(optionsff);

                //        break;
                //    case "IE":
                //        InternetExplorerOptions ieOptions = new InternetExplorerOptions();
                //        ieOptions.PageLoadStrategy = PageLoadStrategy.Eager;
                //        ieOptions.EnsureCleanSession = true;
                //        ieOptions.UnhandledPromptBehavior = UnhandledPromptBehavior.Accept;
                //        ieOptions.RequireWindowFocus = false;
                //        ieOptions.EnableNativeEvents = false;
                //        ieOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                //        ieOptions.IgnoreZoomLevel = true;
                //        ieOptions.BrowserCommandLineArguments = "-private";
                //        this.driver = new InternetExplorerDriver(ieOptions);
                //        driver.Manage().Window.Size = new Size(1042, 786);

                //    break;
                //case "Edge":
                //    var options = new Microsoft.Edge.SeleniumTools.EdgeOptions();
                //    options.UseChromium = true;
                //    options.AcceptInsecureCertificates = true;
                //    options.UnhandledPromptBehavior = UnhandledPromptBehavior.Accept;
                //    options.AddArgument("window-size=1042,786");
                //    options.AddArguments("--ignore-ssl-errors=yes");
                //    options.AddArguments("--ignore-certificate-errors");
                //    options.AddArguments("--ignore-certificate-errors-spki-list");
                //    options.AddArguments("--InPrivate");
                //    options.AddArguments("--ignore-certificate-errors-spki-list");
                //    options.AddArgument("--enable-features=AllowSyncXHRInPageDismissal");
                //    options.AddArgument("no-sandbox");
                //    //var driveredgePath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                //    var driveredgePath = @"C:\AutomationSupportings";
                //    EdgeDriverService eds = EdgeDriverService.CreateDefaultService(driveredgePath, "msedgedriver.exe");
                //    driver = new Microsoft.Edge.SeleniumTools.EdgeDriver(driveredgePath, options);
                //    this.driver.Manage().Timeouts().AsynchronousJavaScript.Add(TimeSpan.FromSeconds(300));
                //    this.driver.Manage().Timeouts().PageLoad.Add(TimeSpan.FromSeconds(300));
                //    this.driver.Manage().Window.Maximize();

                //        break;
                //    default:
                //        break;
                }
                ICapabilities cap = driver.Capabilities;
                string bName = cap.GetCapability("browserName").ToString();
                string bVersion = cap.GetCapability("browserVersion").ToString();
                sharedData.browserName = bName;
                sharedData.browserversion = bVersion;
                sharedData.TestDriver = driver;
                sharedData.MainWindowId = driver.CurrentWindowHandle;
                SharedData.NewDriverTest = driver;
                return this.driver;
            }

            //public RemoteWebDriver SelectBSBrowser(string browser)
            //{
            //    string browsertype = browser;
            //    string browserVersion = "";

            //    switch (browsertype)
            //    {
            //        case "Edge_latest":
            //            browsertype = "Edge";
            //            browserVersion = "latest";
            //            break;
            //        case "Edge_latestMinusOne":
            //            browsertype = "Edge";
            //            browserVersion = "latest-1";
            //            break;
            //        case "Edge_beta":
            //            browsertype = "Edge";
            //            browserVersion = "beta";
            //            break;
            //        case "Firefox_latest":
            //            browsertype = "Firefox";
            //            browserVersion = "latest";
            //            break;
            //        case "Firefox_latestMinusOne":
            //            browsertype = "Firefox";
            //            browserVersion = "latest-1";
            //            break;
            //        case "Firefox_beta":
            //            browsertype = "Firefox";
            //            browserVersion = "beta";
            //            break;
            //        case "Chrome_latest":
            //            browsertype = "Chrome";
            //            browserVersion = "latest";
            //            break;
            //        case "Chrome_latestMinusOne":
            //            browsertype = "Chrome";
            //            browserVersion = "latest-1";
            //            break;
            //        case "Chrome_beta":
            //            browsertype = "Chrome";
            //            browserVersion = "beta";
            //            break;
            //        case "Android":
            //            browsertype = "Android";
            //            //browserVersion = "latest";
            //            break;
            //        case "iPhone":
            //            browsertype = "iPhone";
            //            //browserVersion = "latest";
            //            break;
            //        case "iPad":
            //            browsertype = "iPad";
            //            //browserVersion = "latest";
            //            break;
            //        case "macOS":
            //            browsertype = "macOS";
            //            //browserVersion = "latest";
            //            break;
            //        default:
            //            browsertype = "Edge";
            //            browserVersion = "latest";
            //            break;
            //    }
            //    string buildName = Environment.GetEnvironmentVariable("BROWSERSTACK_BUILD_NAME");
            //    //string buildName = ConfigurationManager.AppSettings["BROWSERSTACK_BUILD_NAME"];
            //    BrowserType browserName = (BrowserType)Enum.Parse(typeof(BrowserType), browsertype);
            //    DriverOptions options = BrowserStackDriver.SelectBrowserOptions((global::BrowserType)browserName, browserVersion, buildName, scenarioContext.ScenarioInfo.Title);
                
            //    BrowserStackDriver bs_driver = new BrowserStackDriver(scenarioContext, sharedData);
            //    //scenarioContext.Add("driver", bs_driver);
            //    RemoteWebDriver rd_driver = bs_driver.Init(options);
            //    Assert.IsTrue(rd_driver != null, "Browserstack driver failed to start");
            //    sharedData.TestDriver = rd_driver;

            //    return rd_driver;
            //}

            public void Cleanup()
            {
                Console.WriteLine("Test Should stop");
                try
                {
                    this.driver.Quit();
                }
                catch (Exception Ex)
                {
                    Console.WriteLine("Cleanup: Driver not found");
                }
            }
        }

        #endregion


    }

}

public enum BrowserType
{
    Chrome,
    Firefox,
    IE,
    Edge,
    Safari,
    Chrome_latest,
    Chrome_latestMinusOne,
    Chrome_beta,
    Firefox_latest,
    Firefox_latestMinusOne,
    Firefox_beta,
    Edge_latest,
    Edge_latestMinusOne,
    Edge_beta,
    Android,
    iPhone,
    iPad,
    macOS
}