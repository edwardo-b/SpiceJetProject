using BoDi;
using OpenQA.Selenium;
using SpiceJetProject.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpiceJetProject.StepDefinitions
{
    [Binding]
    public class BookingTripStepDefinitions
    {
        IWebDriver driver;
        IObjectContainer objectcontainer;
        ScenarioContext scenarioContext;
        HomePage homePage;
        FlightsPage flightsPage;
        PassengerPage passengerPage;
        AddonsPage addonsPage;
        PaymentPage paymentPage;
        public BookingTripStepDefinitions(IWebDriver driver, ScenarioContext scenarioContext, IObjectContainer objectcontainer)
        {
            this.driver = driver;
            this.scenarioContext = scenarioContext;
            this.objectcontainer = objectcontainer;
            homePage=objectcontainer.Resolve<HomePage>();
            flightsPage=objectcontainer.Resolve<FlightsPage>();
            passengerPage=objectcontainer.Resolve<PassengerPage>(); 
            addonsPage =objectcontainer.Resolve<AddonsPage>();
            passengerPage =objectcontainer.Resolve<PassengerPage>();
        }
        [Given(@"I launch the app url")]
        public void GivenILaunchTheAppUrl()
        {
            Thread.Sleep(5000);
        }

        [When(@"Ensure one way trip and round trips are selectable")]
        public void WhenEnsureOneWayTripAndRoundTripsAreSelectable()
        {
            homePage.ClickRound();
            
        }

        
        [When(@"I Select oneway trips")]
        public void WhenISelectOnewayTrips()
        {
            homePage.ClickOneway();
        }


        [When(@"I fill in the depature ""([^""]*)"" and arrival ""([^""]*)"" locations")]
        public void WhenIFillInTheDepatureAndArrivalLocations(string mum, string del)
        {
            homePage.enterDepature(mum);
         
            homePage.enterDestination(del);
        }
        [When(@"I click the depature date field")]
        public void WhenIClickTheDepatureDateField()
        {
            Thread.Sleep(1000);
        }

        [When(@"I select the depature date")]
        public void WhenISelectTheDepatureDate()
        {

            homePage.selectDate();
        }


        [When(@"I select the number of passengers eg (.*) adults, (.*) child, (.*) infants")]
        public void WhenISelectTheNumberOfPassengersEgAdultsChildInfants(int p0, int p1, int p2)
        {
            homePage.selectPassengers();
        }
        [When(@"I select currency eg pounds")]
        public void WhenISelectCurrencyEgPounds()
        {
            homePage.selectCurrency();
        }


        [When(@"Click search flight button")]
        public void WhenClickSearchFlightButton()
        {
            homePage.ClickSearchBtn();

        }

        [Then(@"I am redirected to the flights page\.")]
        public void ThenIAmRedirectedToTheFlightsPage_()
        {
            flightsPage.flightPageIsDisplayed();
        }

        [Given(@"I Ensure prices are displayed and I select a price")]
        public void GivenIEnsurePricesAreDisplayedAndISelectAPrice()
        {
          /*  flightsPage.pricesAreSelectable();
            flightsPage.flightDetails_2_Navigation();
            flightsPage.flightDetails_1_Navigation(); */
        }

        [When(@"I click on the continue button")]
        public void WhenIClickOnTheContinueButton()
        {
            flightsPage.clickContinueBtn();
        }

        [When(@"I fill all contact details by providing Title, FirstName/MiddleName ""([^""]*)"", Lastname ""([^""]*)"" contactPrefix ""([^""]*)""  contact no ""([^""]*)"", Email address ""([^""]*)"", Country ""([^""]*)"",Town or city ""([^""]*)""")]
        public void WhenIFillAllContactDetailsByProvidingTitleFirstNameMiddleNameLastnameContactPrefixContactNoEmailAddressCountryTownOrCity(string fname, string lname, string unite, string p3, string p4, string p5, string manchester)
        {   

            passengerPage.selectTitle();
            passengerPage.fillFnameLname(fname, lname);
            passengerPage.fillContactDetails(unite, p3);
            Thread.Sleep(2000);
            passengerPage.fillemail(p4);
            passengerPage.fillCountryAndCity(p5,manchester); 
        }

        
       

        [When(@"I ensure I tick I am flying as a passenger cleckbox")]
        public void WhenIEnsureITickIAmFlyingAsAPassengerCleckbox()
        {
            passengerPage.tickPrimaryPassengerBtn();

            passengerPage.clickNextOnPassenger1();
        }

        [When(@"I enter all passenger details, by selecting title and filling in the  FirstName/MiddleName ""([^""]*)"", Lastname ""([^""]*)"" Country ""([^""]*)"" contact no ""([^""]*)"", Email address ""([^""]*)""")]
        public void WhenIEnterAllPassengerDetailsBySelectingTitleAndFillingInTheFirstNameMiddleNameLastnameCountryContactNoEmailAddress(string fname, string lname, string unite, string p3, string p4)
        

        {
            passengerPage.FirstPassengerInfo(fname, lname, unite,p3);
            passengerPage.clickNextOnPassenger2();
            Thread.Sleep(5000);
            passengerPage.ChildPassengerInfo(fname, lname);
            passengerPage.clickNextOnPassenger3();
            passengerPage.InfantInfo(fname, lname);
            passengerPage.infantTravelWithAdult1();
            passengerPage.clickNextOnPassenger2();
            passengerPage.Infant2Info(fname, lname);
            passengerPage.infantTravelWithAdult2();
            passengerPage.clickContinueButton();
        }
        [Given(@"I add no addons")]
        public void GivenIAddNoAddons()
        {
         
            addonsPage.clickContinueBtn();
            Thread.Sleep(4000);
            
        }

        [When(@"I enter card details by filling card number ""([^""]*)"" , card Holder name ""([^""]*)"", expiry date ""([^""]*)"", ""([^""]*)"", ""([^""]*)""")]
        public void WhenIEnterCardDetailsByFillingCardNumberCardHolderNameExpiryDate(string p0, string testEd, string jan, string p3, string p4)
        {
            
            paymentPage.EnterCardDetails(p0,testEd,jan,p3,p4);
        }

        
        [When(@"I tick T&C checkbox")]
        public void WhenITickTCCheckbox()
        {
            paymentPage.tickTnCBox();
        }

        [When(@"Click on proceed to pay button")]
        public void WhenClickOnProceedToPayButton()
        {
            paymentPage.clickPayBtn();
        }
    }
}
