using Microsoft.VisualStudio.TestPlatform.CoreUtilities.Extensions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiceJetProject.Pages
{
    internal class PassengerPage
    {
        IWebDriver driver;

        public By TitleDropdown = By.XPath("(//*[@class=\"css-1dbjc4n r-1awozwy r-18u37iz r-1wtj0ep\"])[1]");
        public By phoneCode = By.XPath("(//*[@class=\"css-76zvg2 css-bfa6kz r-homxoj r-poiln3 r-ubezar\"])[1]");
        public By phoneCodeSearch = By.XPath("(//*[@placeholder=\"Search\"])[1]");
        public By phoneCodeSelect = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-poiln3 r-1b43r93 r-193dp3\"])[5]");
        public By phoneNumber = By.XPath("(//*[@data-testid=\"contact-number-input-box\"])");
        public By countryDropDown = By.XPath("(//*[@class=\"css-1dbjc4n r-1awozwy r-18u37iz r-1wtj0ep\"])[3]");
        public By countrySearch = By.XPath("//*[@class=\"css-1dbjc4n r-1awozwy r-11u4nky r-116j6us r-1yadl64 r-13awgt0 r-18u37iz\"]");
        public By selectCountry = By.XPath("//*[@class=\"css-76zvg2 r-qsz3a2 r-poiln3 r-n6v787 r-1e081e0 r-oyd9sg\"]");
        public By titleMr = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-poiln3 r-ubezar\"])[1]");
        public By titleMrs = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-poiln3 r-ubezar\"])[2]");
        public By titleMiss = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-poiln3 r-ubezar\"])[3]");

        public By fname = By.XPath("(//*[@class=\"css-1cwyjr8 r-homxoj r-poiln3 r-ubezar r-1eimq0t r-1e081e0 r-xfkzu9 r-lnhwgy\"])[1]");
        public By lname = By.XPath("//*[@data-testid=\"last-inputbox-contact-details\"]");
        public By email = By.XPath("(//*[@data-testid=\"emailAddress-inputbox-contact-details\"])");
        public By towncity = By.XPath("(//*[@class=\"css-1cwyjr8 r-homxoj r-poiln3 r-ubezar r-1eimq0t r-1e081e0 r-xfkzu9 r-lnhwgy\"])[3]");
        public By tickPrimaryPassenger = By.XPath("(//*[@class=\"css-1dbjc4n r-zso239\"])[5]");
        public By nextOnPassenger1 = By.XPath("(//*[@data-testid=\"traveller-0-travel-info-cta\"])");
        public By Passenger1title = By.XPath("(//*[@class=\"css-76zvg2 css-bfa6kz r-homxoj r-poiln3 r-ubezar r-j2kj52\"])[2]");

        public By Passenger1FirstName = By.XPath("//*[@data-testid=\"traveller-1-first-traveller-info-input-box\"]");
        public By Passenger1LastName = By.XPath("//*[@data-testid=\"traveller-1-last-traveller-info-input-box\"]");
        public By Passenger1phonePrefix = By.XPath("(//*[@class=\"css-1dbjc4n r-1awozwy r-18u37iz r-1wtj0ep\"])[5]");
        public By Passenger1phonePrefixSearch = By.XPath("//*[@placeholder=\"Search\"]");
        public By Passenger1phonePrefixSelect = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-poiln3 r-1b43r93 r-193dp3\"])[5]");
        public By Passenger1PhoneNumber = By.XPath("//*[@data-testid=\"sc-member-mobile-number-input-box\"]");
        public By Passenger2Title = By.XPath("(//*[@class=\"css-76zvg2 css-bfa6kz r-homxoj r-poiln3 r-ubezar r-j2kj52\"])[2]");
        public By nextOnPassenger2page = By.XPath("//*[@class=\"css-76zvg2 r-jwli3a r-poiln3 r-ubezar r-1kfrs79\"]");

        public By Passenger3Title = By.XPath("//*[@data-testid=\"traveller-2-title-field\"]");
        public By Passenger3TitleMiss = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-poiln3 r-ubezar\"])[1]");
        public By Passenger3TitleMaster = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-poiln3 r-ubezar\"])[2]");
        public By Passenger3FirstName = By.XPath("//*[@data-testid=\"traveller-2-first-traveller-info-input-box\"]");
        public By Passenger3LastName = By.XPath("//*[@data-testid=\"traveller-2-last-traveller-info-input-box\"]");
        public By Passenger3NextBtn = By.XPath("//*[@data-testid=\"traveller-2-travel-info-cta\"]");

        public By InfantTitle = By.XPath("(//*[@data-testid=\"title-traveller-0-infant-information\"])[1]");
        public By InfantTravelWithDropdown = By.XPath("(//*[@data-testid=\"title-traveller-0-infant-information\"])[2]");
        public By InfantTravelWithAdult1 = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-poiln3 r-ubezar\"])[1]");
        public By InfantTravelWithAdult2 = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-poiln3 r-ubezar\"])[2]");
        public By Infant1FirstName = By.XPath("//*[@data-testid=\"first-traveller-0-infant-information\"]");
        public By Infant1LastName = By.XPath("//*[@data-testid=\"last-traveller-0-infant-information\"]");
        public By Infant1PageNextBtn = By.XPath("//*[@data-testid=\"traveller-0-travel-info-view\"]");

        public By InfantDOB = By.XPath("//*[@data-testid=\"date-of-birth-traveller-0-infant-information\"]");
        public By InfantYearOfBirth = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-poiln3 r-edyy15 r-q4m81j\"])[2]");
        public By InfantMonthOfBirth = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-poiln3 r-edyy15 r-q4m81j\"])[7]");
        public By InfantDayOfBirth = By.XPath("(//*[@class=\"css-76zvg2 r-1awozwy r-14lw9ot r-qsz3a2 r-6koalj r-poiln3 r-1r8g8re r-1777fci r-1acpoxo\"])[20]");


        public By Infant2Title = By.XPath("//*[@data-testid=\"title-traveller-1-infant-information\"]");
        public By Infant2FirstName = By.XPath("//*[@data-testid=\"first-traveller-1-infant-information\"]");
        public By Infant2LastName = By.XPath("//*[@data-testid=\"last-traveller-1-infant-information\"]");
        public By Infant2DOB = By.XPath("//*[@data-testid=\"date-of-birth-traveller-1-infant-information\"]");
        public By Infant2YearOfBirth = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-poiln3 r-edyy15 r-q4m81j\"])[2]");
        public By Infant2MonthOfBirth = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-poiln3 r-edyy15 r-q4m81j\"])[7]");
        public By Infant2DayOfBirth = By.XPath("(//*[@class=\"css-76zvg2 r-1awozwy r-14lw9ot r-qsz3a2 r-6koalj r-poiln3 r-1r8g8re r-1777fci r-1acpoxo\"])[20]");
        public By Infant2TravelWithDropdown = By.XPath("(//*[@data-testid=\"title-traveller-1-infant-information\"])[2]");

        public By ContinueBtn = By.XPath("//*[@class=\"css-1dbjc4n r-1awozwy r-19m6qjp r-z2wwpe r-1loqt21 r-18u37iz r-1777fci r-6ity3w r-d9fdf6 r-9qu9m4 r-ah5dr5 r-1otgn73\"]");



        public PassengerPage(IWebDriver driver) 
        {
            this.driver = driver;
        }
        public void selectTitle()

        {
            Thread.Sleep(5000);
            driver.FindElement(TitleDropdown).Click();
            driver.FindElement(titleMiss).Click();
            driver.FindElement(TitleDropdown).Click();
            driver.FindElement(titleMrs).Click();
            driver.FindElement(TitleDropdown).Click();
            driver.FindElement(titleMr).Click();
        }

        public void fillFnameLname(string firstname, string lastname)
        {
            Thread.Sleep(2000);
           driver.FindElement(fname).Clear();
           driver.FindElement(fname).SendKeys(firstname);
            driver.FindElement(lname).Clear(); 
           driver.FindElement(lname).SendKeys(lastname); 
        }
        public void fillContactDetails(string prefix, string  phoneNo)
        {
            Thread.Sleep(2000);
            driver.FindElement(phoneCode).Click();
            driver.FindElement(phoneCodeSearch).Clear();
            driver.FindElement(phoneCodeSearch).SendKeys(prefix);
            driver.FindElement(phoneCodeSelect).Click();
            driver.FindElement(phoneNumber).SendKeys(phoneNo);
        }

        public void fillemail(string Email)
        {
            driver.FindElement(email).SendKeys(Email)   ;
        }
        public void fillCountryAndCity(string Country, string city) 
        {
           // driver.FindElement(countryDropDown).Click();
           // driver.FindElement(countrySearch).Clear();
            //driver.FindElement(countrySearch).SendKeys(Country);
            //driver.FindElement(selectCountry).Click();
            driver.FindElement(towncity).SendKeys(city);
        }
        public void tickPrimaryPassengerBtn() 
        {
            driver.FindElement(tickPrimaryPassenger).Click();
        }
        public void AddRandonTxt()
        {
            Random ran = new Random();
            String b = "abcdefghijklmnopqrstuvwxyz";
            int length = 6;
            String random = "";
            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(26);
                random=random+b.ElementAt(a);
            }
          

        }
        public void FirstPassengerInfo( string firstname, string lastname, string country, string phoneNo)
        {
            Random ran = new Random();
            String b = "abcdefghijklmnopqrstuvwxyz";
            int length = 6;
            String random = "";
            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(26);
                random = random + b.ElementAt(a);
            }

            driver.FindElement(Passenger2Title).Click();
            driver.FindElement(titleMrs).Click();
            driver.FindElement(Passenger2Title).Click();
            driver.FindElement(titleMiss).Click();
            driver.FindElement(Passenger2Title).Click();
            driver.FindElement(titleMr).Click();
            driver.FindElement(Passenger1FirstName).SendKeys(firstname + random);
            driver.FindElement(Passenger1LastName).SendKeys(lastname);
            driver.FindElement(Passenger1phonePrefix).Click();
            Thread.Sleep(3000);
            driver.FindElement(Passenger1phonePrefixSearch).SendKeys(country);
            Thread.Sleep(3000);
            driver.FindElement(Passenger1phonePrefixSelect).Click();
            Thread.Sleep(3000);
            driver.FindElement(Passenger1PhoneNumber).SendKeys(phoneNo);

        }
        public void ChildPassengerInfo(string firstname, string lastname)
        {
            Random ran = new Random();
            String b = "abcdefghijklmnopqrstuvwxyz";
            int length = 6;
            String random = "";
            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(26);
                random = random + b.ElementAt(a);
            }

            driver.FindElement(Passenger3Title).Click();
            driver.FindElement(Passenger3TitleMiss).Click();
            driver.FindElement(Passenger3Title).Click();
            driver.FindElement(Passenger3TitleMaster).Click();
            Thread.Sleep(2000);
            driver.FindElement(Passenger3FirstName).SendKeys(firstname+random);
            driver.FindElement(Passenger3LastName).SendKeys(lastname);
            Thread.Sleep(2000);
        }

        public void InfantInfo(string firstname, string lastname) 
        {
            Random ran = new Random();
            String b = "abcdefghijklmnopqrstuvwxyz";
            int length = 6;
            String random = "";
            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(26);
                random = random + b.ElementAt(a);
            }
            Thread.Sleep(2000);
            driver.FindElement(InfantTitle).Click();
            driver.FindElement(Passenger3TitleMaster).Click();
            driver.FindElement(InfantTitle).Click();
            driver.FindElement(Passenger3TitleMiss).Click();
            driver.FindElement(Infant1FirstName).SendKeys(firstname+random);
            driver.FindElement (Infant1LastName).SendKeys(lastname);
            driver.FindElement (InfantDOB).Click();
            driver.FindElement(InfantYearOfBirth).Click();
            driver.FindElement(InfantMonthOfBirth).Click();
            driver.FindElement(InfantDayOfBirth).Click();
            driver.FindElement(InfantTravelWithDropdown).Click();
            

        }
        public void Infant2Info(string firstname, string lastname)
        {
            Random ran = new Random();
            String b = "abcdefghijklmnopqrstuvwxyz";
            int length = 6;
            String random = "";
            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(26);
                random = random + b.ElementAt(a);
            }

            Thread.Sleep(2000);
            driver.FindElement(Infant2Title).Click();
            driver.FindElement(Passenger3TitleMaster).Click();
            driver.FindElement(Infant2Title).Click();
            driver.FindElement(Passenger3TitleMiss).Click();
            driver.FindElement(Infant2FirstName).SendKeys(firstname+random);
            driver.FindElement(Infant2LastName).SendKeys(lastname);
            driver.FindElement(Infant2DOB).Click();
            driver.FindElement(InfantYearOfBirth).Click();
            driver.FindElement(InfantMonthOfBirth).Click();
            driver.FindElement(InfantDayOfBirth).Click();
            driver.FindElement(Infant2TravelWithDropdown).Click();


        }

        public void clickNextOnPassenger1()
        {
            driver.FindElement(nextOnPassenger1).Click();
        }

        public void clickNextOnPassenger2()
        {
            driver.FindElement(nextOnPassenger2page).Click();
        }
        public void clickNextOnPassenger3()
        {
            driver.FindElement(Passenger3NextBtn).Click();
        }
        public void clickNextOnInfant1Page()
        {
            driver.FindElement(Infant1PageNextBtn).Click();
        }
        public void clickContinueButton()
        { driver.FindElement(ContinueBtn).Click(); 
            Thread.Sleep(5000);
        }


        public void infantTravelWithAdult1()
        {
            driver.FindElement(InfantTravelWithAdult1).Click();
          
        }
        public void infantTravelWithAdult2()
        {
            driver.FindElement(InfantTravelWithAdult2).Click();
        }
    }
}
