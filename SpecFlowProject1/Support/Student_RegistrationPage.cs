using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Support
{
    internal class Student_RegistrationPage
    {
        IWebDriver driver;
        public Student_RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void WhenTheySelectRegister()
        {
            driver.FindElement(By.Id("register")).Click();
        }
        public void WhenTheyEnterTheirPostcode(string postcode)
        {
            driver.FindElement(By.Id("fld_p")).SendKeys(postcode);
            driver.FindElement(By.XPath("//input[@value='Search']")).Click();
            driver.FindElement(By.XPath("//ol[@id='results']//li[1]//span")).Click();

        }
        public void WhenTheyEnterTheirName(string firstname, string surname)
        {
            driver.FindElement(By.Id("fld_first_name")).SendKeys(firstname);
            driver.FindElement(By.Id("fld_last_name")).SendKeys(surname);
        }

        public void WhenTheyEnterTheirEmail(string email)
        {


            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int length = 10;
            Random random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());

            driver.FindElement(By.Id("fld_identification")).SendKeys($"{randomString}@gmail.com");

            // Create a string array with the lines of text
            string[] lines = { $"{randomString}@gmail.com" };

            // Set a variable to the Documents path.
            //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//
            string docPath = Path.GetDirectoryName("C:\\DSA AUTO\\SpecFlowProject1\\SpecFlowProject1\\usernames\\");

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }
        public void WhenTheyEnterTheirDOB(string dob)
        {
            string[] dobArray = dob.Split('/');
            driver.FindElement(By.Id("fld_date_of_birth_D")).SendKeys(dobArray[0]);
            driver.FindElement(By.Id("fld_date_of_birth_M")).SendKeys(dobArray[1]);
            driver.FindElement(By.Id("fld_date_of_birth_Y")).SendKeys(dobArray[2]);
        }
        public void WhenTheyEnterTheirPhone(string phone)
        {
            driver.FindElement(By.Id("fld_mobile")).SendKeys(phone);
        }
        public void WhenTheyEnterHowDidYouHearAboutUs(string text)
        {
            SelectElement select = new SelectElement(driver.FindElement(By.Id("fld_hdyhau")));
            select.SelectByText(text);

            //driver.FindElement(By.Id("fld_mobile")).SendKeys(phone);
        }
        public void WhenTheyEnterTheirAddress(string address)
        {
            driver.FindElement(By.Id("fld_address_line_1")).SendKeys(address);
        }
        public void WhenTheyEnterPassword(string password)
        {
            driver.FindElement(By.Id("fld_password")).SendKeys(password);
            driver.FindElement(By.Id("fld_password_repeat")).SendKeys(password);
        }
        public void WhenTheyPressSubmit()
        {
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
            Thread.Sleep(2000);
        }
        public void WhenTheyPressTownOrCity(string towncity)
        {
            driver.FindElement(By.Id("fld_town_or_city")).SendKeys(towncity);
        }
        public void WhenTheyEnterFundingBody(string body)
        {
            SelectElement select = new SelectElement(driver.FindElement(By.Id("fld_funding_body")));
            select.SelectByText(body);

        }
        public void WhenTheyEnterCourseSubject(string subject)
        {
            driver.FindElement(By.Id("fld_course_subject")).SendKeys(subject);
        }
        public void WhenTheyEnterCourseLevel(string level)
        {
            SelectElement select = new SelectElement(driver.FindElement(By.Id("fld_course_level")));
            select.SelectByText(level);

        }
        public void WhenTheyEnterFullOrPartTime(string time)
        {
            SelectElement select = new SelectElement(driver.FindElement(By.Id("fld_full_or_part_time")));
            select.SelectByText(time);

        }
        public void WhenTheyEnterUniversity(string uni)
        {
            SelectElement select = new SelectElement(driver.FindElement(By.Id("fld_institution")));
            select.SelectByText(uni);
            SelectElement select2 = new SelectElement(driver.FindElement(By.Id("fld_may_we_share_your_assessment_i")));
            select2.SelectByText("Yes");

        }
        public void WhenComminicationSelected(string truefalse)
        {
            if (truefalse.Contains("Yes") || truefalse.Contains("yes"))
            {
                driver.FindElement(By.Id("fld_communication_true")).Click();
            }
            else
            {
                driver.FindElement(By.Id("fld_communication_false")).Click();
            }

        }
        public void WhenDisabilitySelected(string disability)
        {
            driver.FindElement(By.XPath($"//span[contains(text(), '{disability}')]")).Click();
        }
        public void WhenDifficultySelected(string difficulty)
        {
            driver.FindElement(By.XPath($"//span[contains(text(), '{difficulty}')]")).Click();
        }
        public void WhenExtraDisabilityDetailsSelected(string truefalse)
        {
            if (truefalse.Contains("Yes") || truefalse.Contains("yes"))
            {
                driver.FindElement(By.Id("fld_disability_extra_true")).Click();
            }
            else
            {
                driver.FindElement(By.Id("fld_disability_extra_false")).Click();
            }

        }
        public void WhenRequirementSelected(string requirement)
        {
            driver.FindElement(By.XPath($"//span[contains(text(), '{requirement}')]")).Click();
        }
        public void WhenReceivedPreviousSupport(string truefalse)
        {
            if (truefalse.Contains("Yes") || truefalse.Contains("yes"))
            {
                driver.FindElement(By.Id("fld_support_true")).Click();
            }
            else
            {
                driver.FindElement(By.Id("fld_support_false")).Click();
            }

        }
        public void WhenDidYouHaveEducationHealthCarePlan(string truefalse)
        {
            if (truefalse.Contains("Yes") || truefalse.Contains("yes"))
            {
                driver.FindElement(By.Id("fld_ehc_plan_true")).Click();
            }
            else
            {
                driver.FindElement(By.Id("fld_ehc_plan_false")).Click();
            }

        }
        public void WhenDeviceOwnedSelected(string device)
        {
            driver.FindElement(By.XPath($"//span[contains(text(), '{device}')]")).Click();
        }
        public void WhenDoYouUseAssistiveTools(string truefalse)
        {
            if (truefalse.Contains("Yes") || truefalse.Contains("yes"))
            {
                driver.FindElement(By.Id("fld_software_true")).Click();
            }
            else
            {
                driver.FindElement(By.Id("fld_software_false")).Click();
            }

        }
        public void WhenPreviouslyAssessed(string truefalse)
        {
            if (truefalse.Contains("Yes") || truefalse.Contains("yes"))
            {
                driver.FindElement(By.Id("fld_previous_true")).Click();
            }
            else
            {
                driver.FindElement(By.Id("fld_previous_false")).Click();
            }

        }
        public void WhenFillInFundingDetailsLater()
        {

            driver.FindElement(By.Id("fld_funding_letter_method_later")).Click();

        }
        public void WhenFillInMEDetailsLater()
        {

            driver.FindElement(By.Id("fld_medical_evidence_method_later")).Click();

        }
        public void WhenTheySubmitStudentAccount()
        {
            driver.FindElement(By.XPath("//button[text()='Save']")).Click();
        }
    }
}
