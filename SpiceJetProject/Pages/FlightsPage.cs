using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiceJetProject.Pages
{
    internal class FlightsPage
    {
        IWebDriver driver;


        public By flightsPageTitle = By.XPath("//*[@class=\"css-1dbjc4n r-1awozwy r-19m6qjp r-1xfd6ze r-1loqt21 r-18u37iz r-1777fci r-ymp9ed r-1j3t67a r-1w50u8q r-ah5dr5 r-1otgn73 r-1n20pny\"]");
        public By spiceSaver1 = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-1i10wst r-1kfrs79\"])[10]");
        public By spiceFlex1 = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-1i10wst r-1kfrs79\"])[11]");
        public By spiceMax1 = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-1i10wst r-1kfrs79\"])[12]");
        public By spiceSaver2 = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-1i10wst r-1kfrs79\"])[15]");
        public By spiceFlex2 = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-1i10wst r-1kfrs79\"])[16]");
        public By spiceMax2 = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-1i10wst r-1kfrs79\"])[17]");
        public By flightDetails1 = By.XPath("(//*[@class=\"css-1dbjc4n r-1awozwy r-1ah4tor r-3395yf\"])[1]");
        public By flightDetails2 = By.XPath("(//*[@class=\"css-1dbjc4n r-1awozwy r-1ah4tor r-3395yf\"])[2]");
        public By baggageInfo1 = By.XPath("(//*[@class=\"css-76zvg2 r-cqee49 r-ubezar r-16dba41\"])[2]");
        public By CancelationInfo1 = By.XPath("(//*[@class=\"css-76zvg2 r-cqee49 r-ubezar r-16dba41\"])[3]");
        public By baggageInfo2 = By.XPath("(//*[@class=\"css-76zvg2 r-cqee49 r-ubezar r-16dba41\"])[2]");
        public By CancelationInfo2 = By.XPath("(//*[@class=\"css-76zvg2 r-cqee49 r-ubezar r-16dba41\"])[3]");
        public By continueBtn = By.XPath("(//*[@data-testid=\"continue-search-page-cta\"])");
        public By holdPriceBtn = By.XPath("//*[@data-testid=\"hold-now-search-page-desktop\"]");

        public FlightsPage(IWebDriver driver) 
        { 
            this.driver = driver;
           
        }
        public void flightPageIsDisplayed() 
        {

            Thread.Sleep(2000);
            Assert.IsTrue(driver.FindElement(flightsPageTitle).Displayed);
            Thread.Sleep(5000);
            
        }
        public void pricesAreSelectable() 
        {
            
            driver.FindElement(spiceFlex1).Click();
            Thread.Sleep(5000);
            driver.FindElement(spiceMax1).Click();
            Thread.Sleep(5000);
            driver.FindElement(spiceSaver2).Click();
            Thread.Sleep(5000);
            driver.FindElement(spiceFlex2).Click();
            Thread.Sleep(5000);
            driver.FindElement(spiceMax2).Click();
            
         /*   Thread.Sleep(5000);
            driver.FindElement(spiceSaver1).Click(); */
        }
        public void flightDetails_1_Navigation()
        {
            Thread.Sleep(5000);
            driver.FindElement(flightDetails1).Click();
            Thread.Sleep(1000);
            driver.FindElement(baggageInfo1).Click();
            Thread.Sleep(1000);
            driver.FindElement(CancelationInfo1).Click();
           
        }

        public void flightDetails_2_Navigation()
        {
            Thread.Sleep(10000);
            driver.FindElement(flightDetails2).Click();
            Thread.Sleep(2000);
            driver.FindElement(baggageInfo2).Click();
            Thread.Sleep(2000);
            driver.FindElement(CancelationInfo2).Click();
            Thread.Sleep(2000);
        }

        public void clickContinueBtn()

        {
            Thread.Sleep(2000);
            driver.FindElement(continueBtn).Click();
        }
    }
    
}
