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
    internal class Student_RegistrationPageSteps
    {
        IWebDriver driver;
        Student_RegistrationPage registrationPage;
        public Student_RegistrationPageSteps(IWebDriver driver)
        {
            this.driver = driver;
            this.registrationPage = new Student_RegistrationPage(driver);
        }
        [When(@"a user saves the student account")]
        public void WhenAUserSavesTheStudentAccount()
        {
            registrationPage.WhenTheySubmitStudentAccount();
        }
        [When(@"they select register")]
        public void WhenTheySelectRegister()
        {
            registrationPage.WhenTheySelectRegister();
        }

        [When(@"they enter their postcode '([^']*)'")]
        public void WhenTheyEnterTheirPostcode(string postcode)
        {
            registrationPage.WhenTheyEnterTheirPostcode(postcode);
        }

        [When(@"they fill in the registration form: name '([^']*)', '([^']*)'")]
        public void WhenTheyFillInTheRegistrationFormName(string firstname, string lastname)
        {
            registrationPage.WhenTheyEnterTheirName(firstname, lastname);
        }
        [When(@"they fill in the registration form: email '([^']*)'")]
        public void WhenTheyFillInTheRegistrationFormEmail(string email)
        {
            registrationPage.WhenTheyEnterTheirEmail(email);
        }

        [When(@"they fill in the registration form: DOB '([^']*)'")]
        public void WhenTheyFillInTheRegistrationFormDOB(string dob)
        {
            registrationPage.WhenTheyEnterTheirDOB(dob);
        }

        [When(@"they fill in the registration form: phone number '([^']*)'")]
        public void WhenTheyFillInTheRegistrationFormPhoneNumber(string phone)
        {
            registrationPage.WhenTheyEnterTheirPhone(phone);
        }
        [When(@"they fill in the registration form: select how did you hear about us\? '([^']*)'")]
        public void WhenTheyFillInTheRegistrationFormSelectHowDidYouHearAboutUs(string source)
        {
            registrationPage.WhenTheyEnterHowDidYouHearAboutUs(source);
        }

        [When(@"they fill in the registration form: enter address '([^']*)'")]
        public void WhenTheyFillInTheRegistrationFormEnterAddress(string address)
        {
            registrationPage.WhenTheyEnterTheirAddress(address);
        }

        [When(@"they fill in the registration form: enter password '([^']*)'")]
        public void WhenTheyFillInTheRegistrationFormEnterPassword(string password)
        {
            registrationPage.WhenTheyEnterPassword(password);
        }
        [When(@"they fill in the registration form: Click submit")]
        public void WhenTheyFillInTheRegistrationFormClickSubmit()
        {
            registrationPage.WhenTheyPressSubmit();
        }


        [When(@"they fill in the registration form: town or city '([^']*)'")]
        public void WhenTheyFillInTheRegistrationFormTownOrCity(string towncity)
        {
            registrationPage.WhenTheyPressTownOrCity(towncity);
        }
        [When(@"they fill in the assessment details: Funding body '([^']*)'")]
        public void WhenTheyFillInTheAssessmentDetailsFundingBody(string body)
        {
            registrationPage.WhenTheyEnterFundingBody(body);
        }

        [When(@"they fill in the assessment details: Course '([^']*)'")]
        public void WhenTheyFillInTheAssessmentDetailsCourse(string course)
        {
            registrationPage.WhenTheyEnterCourseSubject(course);
        }

        [When(@"they fill in the assessment details: course code '([^']*)'")]
        public void WhenTheyFillInTheAssessmentDetailsCourseCode(string p0)
        {
        }

        [When(@"they fill in the assessment details: course level '([^']*)'")]
        public void WhenTheyFillInTheAssessmentDetailsCourseLevel(string level)
        {
            registrationPage.WhenTheyEnterCourseLevel(level);
        }

        [When(@"they fill in the assessment details: course start date '([^']*)'")]
        public void WhenTheyFillInTheAssessmentDetailsCourseStartDate(string p0)
        {
        }

        [When(@"they fill in the assessment details: Select university '([^']*)'")]
        public void WhenTheyFillInTheAssessmentDetailsSelectUniversity(string uni)
        {
            registrationPage.WhenTheyEnterUniversity(uni);
        }
        [When(@"they fill in the assessment details: full or part time '([^']*)'")]
        public void WhenTheyFillInTheAssessmentDetailsFullOrPartTime(string time)
        {
            registrationPage.WhenTheyEnterFullOrPartTime(time);
        }
        [When(@"they click continue")]
        public void WhenTheyClickContinue()
        {
            registrationPage.WhenTheyPressSubmit();
        }
        [When(@"they fill in assessment details: Select communication preferences '([^']*)'")]
        public void WhenTheyFillInAssessmentDetailsSelectCommunicationPreferences(string yesno)
        {
            registrationPage.WhenComminicationSelected(yesno);
        }

        [When(@"they fill in assessment details: Select disability '([^']*)'")]
        public void WhenTheyFillInAssessmentDetailsSelectDisability(string disability)
        {
            registrationPage.WhenDisabilitySelected(disability);
        }

        [When(@"they fill in assessment details: Select difficulty areas '([^']*)'")]
        public void WhenTheyFillInAssessmentDetailsSelectDifficultyAreas(string difficulty)
        {
            registrationPage.WhenDifficultySelected(difficulty);
        }

        [When(@"they fill in assessment details: Select requirements '([^']*)'")]
        public void WhenTheyFillInAssessmentDetailsSelectRequirements(string requirement)
        {
            registrationPage.WhenRequirementSelected(requirement);
        }

        [When(@"they fill in assessment details: Use assisting technology '([^']*)'")]
        public void WhenTheyFillInAssessmentDetailsUseAssistingTechnology(string yesno)
        {
            registrationPage.WhenDoYouUseAssistiveTools(yesno);
        }

        [When(@"they fill in assessment details: Select previous DSA assessment '([^']*)'")]
        public void WhenTheyFillInAssessmentDetailsSelectPreviousDSAAssessment(string yesno)
        {
            registrationPage.WhenPreviouslyAssessed(yesno);
        }

        [When(@"they fill in assessment details: Extra disability '([^']*)'")]
        public void WhenTheyFillInAssessmentDetailsExtraDisability(string yesno)
        {
            registrationPage.WhenExtraDisabilityDetailsSelected(yesno);
        }
        [When(@"they fill in assessment details: Received past support '([^']*)'")]
        public void WhenTheyFillInAssessmentDetailsReceivedPastSupport(string no)
        {
            registrationPage.WhenReceivedPreviousSupport(no);
        }

        [When(@"they fill in assessment details: Has education, health and care plan in past '([^']*)'")]
        public void WhenTheyFillInAssessmentDetailsHasEducationHealthAndCarePlanInPast(string no)
        {
            registrationPage.WhenDidYouHaveEducationHealthCarePlan(no);
        }
        [When(@"they fill in assessment files: Fill in funding letter later")]
        public void WhenTheyFillInAssessmentFilesFillInFundingLetterLater()
        {
            registrationPage.WhenFillInFundingDetailsLater();
        }

        [When(@"they fill in assessment files: Fill in ME later")]
        public void WhenTheyFillInAssessmentFilesFillInMELater()
        {
            registrationPage.WhenFillInMEDetailsLater();
        }
    }
}
