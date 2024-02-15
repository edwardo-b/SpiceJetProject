using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpiceJetProject.Pages;

namespace SpiceJetProject.StepDefinitions
{
    [Binding]
    public sealed class RegistrationStepDefinitions
    {
        IWebDriver driver;
        IObjectContainer objectcontainer;
        ScenarioContext scenarioContext;
        RegistrationPage  registrationPage;
        HomePage homePage;
        
        public RegistrationStepDefinitions(IWebDriver driver, ScenarioContext scenarioContext, IObjectContainer objectcontainer)
        {
            this.driver = driver;
            this.scenarioContext = scenarioContext;
            this.objectcontainer = objectcontainer;
            homePage = objectcontainer.Resolve<HomePage>();
           registrationPage = objectcontainer.Resolve<RegistrationPage>();
        }
        [Given(@"I launch the registration url")]
        public void GivenILaunchTheRegistrationUrl()
        {
           
            driver.Url = "https://spiceclub.spicejet.com/signup";
        }

        [When(@"I click on the sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            Thread.Sleep(3000);
          // homePage.clickSignUpBtn();
        }

        [When(@"I select  title")]
        public void WhenISelectTitle()
        {
            registrationPage.selectTitle();
        }

        [When(@"I enter FirstName'([^']*)' and LastName '([^']*)'")]
        public void WhenIEnterFirstNameAndLastName(string p0, string p1)
        {
            

        registrationPage.enterFirstName("");
            registrationPage.enterLastName("");

        }

        [When(@"Select country/teritory of residence")]
        public void WhenSelectCountryTeritoryOfResidence()
        {
            registrationPage.selectCountry();
        }

        [When(@"select DOB")]
        public void WhenSelectDOB()
        {
            registrationPage.selectDOB();
        }

        [When(@"I select phone country code")]
        public void WhenISelectPhoneCountryCode()
        {
           
        }

        [When(@"I enter phone number")]
        public void WhenIEnterPhoneNumber()
        {
            registrationPage.mobilePhoneNumber();
        }

        [When(@"I enter email address '([^']*)'")]
        public void WhenIEnterEmailAddress(string p0)
        {
            registrationPage.enterEmail();
            registrationPage.scrollToBottom();
        }

        [When(@"I enter my password '([^']*)'")]
        public void WhenIEnterMyPassword(string p0)
        {
           
            registrationPage.enterPassword("");
            registrationPage.enterPassword("");
        }

        [When(@"I reenter password '([^']*)'")]
        public void WhenIReenterPassword(string p0)
        {
            registrationPage.confirmPassword("");

           
        }
        [When(@"I accept terms and conditions")]
        public void WhenIAcceptTermsAndConditions()
        {
            registrationPage.tickTnC();
        }


        [Then(@"I will successfully register a player")]
        public void ThenIWillSuccessfullyRegisterAPlayer()

        {
           
            registrationPage.clickSubmitBtn();
        }



    }
}