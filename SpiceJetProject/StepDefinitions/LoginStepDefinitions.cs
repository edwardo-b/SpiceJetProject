using BoDi;
using OpenQA.Selenium;
using SpiceJetProject.Pages;

namespace SpiceJetProject.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        IWebDriver driver;
        IObjectContainer objectcontainer;
        ScenarioContext scenarioContext;
        LoginPage loginPage;
        HomePage homePage;
        
        public LoginStepDefinitions(IWebDriver driver, ScenarioContext scenarioContext, IObjectContainer objectcontainer)
        {
            this.driver = driver;
            this.scenarioContext = scenarioContext;
            this.objectcontainer = objectcontainer;
            homePage = objectcontainer.Resolve<HomePage>();
           loginPage = objectcontainer.Resolve<LoginPage>();
        }
        [When(@"I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            homePage.clickLoginBtn();
        }

        [When(@"Tick by mobile number")]
        public void WhenTickByMobileNumber()
        {
           loginPage.selectMobileOption();
        }

        [When(@"I select country code eg \+(.*) ""([^""]*)""")]
        public void WhenISelectCountryCodeEg(int p0, string unite)
        {
            loginPage.selectCountry( unite);
        }

        [When(@"I enter address '([^']*)'")]
        public void WhenIEnterAddress(string p0)
        {
            loginPage.enterPhonenumber(p0);
        }

        [When(@"I enter password '([^']*)'")]
        public void WhenIEnterPassword(string p0)
        {
           loginPage.enterPassword(p0);
        }

        [Then(@"I will logged in successfully")]
        public void ThenIWillLoggedInSuccessfully()
        {
            loginPage.clickLoginBtn();
        }

        [When(@"Tick email login option")]
        public void WhenTickEmailLoginOption()
        {
            loginPage.selectEmailOption();
        }



    }
}