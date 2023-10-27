using Docker.DotNet.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SpiceJetProject.Pages
{
    internal class HomePage
    {
        IWebDriver driver;
        public By LoginBtn = By.XPath("(//*[@class=\"css-76zvg2 r-jwli3a r-ubezar\"])[1]");
        public By Oneway = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-ubezar r-1ozqkpa\"])[1]");
        public By Round = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-ubezar r-1ozqkpa\"])[2]");
        public By Depature = By.XPath("(//*[@class=\"css-1cwyjr8 r-homxoj r-ubezar r-10paoce r-13qz1uu\"])[1]");
        public By Arrival = By.XPath("(//*[@class=\"css-1cwyjr8 r-homxoj r-ubezar r-10paoce r-13qz1uu\"])[2]");
        public By depatureDate = By.XPath("(//*[@class=\"css-1dbjc4n r-14lw9ot r-11u4nky r-z2wwpe r-1phboty r-rs99b7 r-1loqt21 r-13awgt0 r-ymttw5 r-5njf8e r-1otgn73\"])[1]");
        public By arrivalDate = By.XPath("(//*[@class=\"css-76zvg2 css-bfa6kz r-homxoj r-ubezar\"])[2]");
        public By depatureDateSelect = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-ubezar r-16dba41\"])[46]");
        public By NumberPassengers = By.XPath("(//*[@class=\"css-1dbjc4n r-1awozwy r-18u37iz r-1wtj0ep\"])[5]");
        public By No_of_Adult = By.XPath("//*[@data-testid=\"Adult-testID-plus-one-cta\"]");
        public By No_of_children = By.XPath("//*[@data-testid=\"Children-testID-plus-one-cta\"]");
        public By No_of_infants = By.XPath("//*[@data-testid=\"Infant-testID-plus-one-cta\"]");
        public By DoneBtn = By.XPath("(//*[@class=\"css-1dbjc4n r-1awozwy r-19m6qjp r-z2wwpe r-1loqt21 r-18u37iz r-1777fci r-d9fdf6 r-1w50u8q r-ah5dr5 r-1otgn73\"])");
        public By Currency = By.XPath("(//*[@class=\"css-1dbjc4n r-1awozwy r-18u37iz r-1wtj0ep\"])[6]");
        public By Currency_pounds = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-ubezar\"])[33]");
        public By searchBtn = By.XPath("(//*[@class=\"css-1dbjc4n r-1awozwy r-z2wwpe r-1loqt21 r-18u37iz r-1777fci r-1g94qm0 r-d9fdf6 r-1w50u8q r-ah5dr5 r-1otgn73\"])");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickOneway()
        {
            driver.FindElement(Oneway).Click();
        }
        public void ClickRound()
        {
            driver.FindElement(Round).Click();
        }
        public void enterDepature(string depature)
        {
            driver.FindElement(Depature).Clear();
            driver.FindElement(Depature).SendKeys(depature);
        }
        public void enterDestination(string destination)
        {
            Thread.Sleep(2000);
            driver.FindElement(Arrival).Clear();
            driver.FindElement(Arrival).SendKeys(destination);
        }
        public void selectDepatureDate()
        {
            Thread.Sleep(2000);
            driver.FindElement(depatureDate).Click();
            driver.FindElement(depatureDateSelect).Click();
        }
        public void selectPassengers()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(NumberPassengers).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(No_of_Adult).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(No_of_children).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            for (int i = 0; i < 2; i++) { driver.FindElement(No_of_infants).Click(); }
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(DoneBtn).Click();
        }
        public void selectCurrency()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(Currency).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(Currency_pounds).Click();
        }
        public void ClickSearchBtn()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(searchBtn).Click();
            
        }
        public void clickDepatureDateField()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(depatureDate).Click();
           
        }
        public void selectDate()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(depatureDateSelect).Click();
        }
     public void clickLoginBtn()
        {
            driver.FindElement(LoginBtn).Click();
        }
        
    }
}
