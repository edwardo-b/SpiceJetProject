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
    

    internal class LoginPage
    {
        IWebDriver driver;
       
        public By LoginBtn = By.XPath("//*[@data-testid=\"login-cta\"]");
        public By MobileNumberRadio = By.XPath("(//*[@class=\"css-1dbjc4n r-1awozwy r-1loqt21 r-18u37iz r-117bsoe r-1otgn73\"])[3]");
        public By emailRadioBtn = By.XPath("(//*[@class=\"css-1dbjc4n r-1awozwy r-1loqt21 r-18u37iz r-117bsoe r-1otgn73\"])[4]");
        public By countryCode = By.XPath("//*[@data-testid=\"user-country-code-selection\"]");
        public By countryCodeSearch = By.XPath("//*[@placeholder=\"Search\"]");
        public By countryCodeSelect = By.XPath("(//*[@class=\"css-76zvg2 r-homxoj r-1b43r93 r-193dp3\"])[5]");
        public By mobileNumberField = By.XPath("//*[@data-testid=\"user-mobileno-input-box\"]");
        public By passwordField = By.XPath("//*[@data-testid=\"password-input-box-cta\"]");
        public By emailField = By.XPath("//*[@data-testid=\"user-mobileno-input-box\"]");  
        public By loginBtn = By.XPath("//*[@data-testid=\"login-cta\"]");
        public LoginPage(IWebDriver driver) 
        {
            this.driver = driver;
            
        }
       
        public void selectMobileOption()

        {
            driver.FindElement(MobileNumberRadio).Click();

        }
        public void selectEmailOption()

        {
            driver.FindElement(emailField).Click();

        }


        public void selectCountry(string prefix)
        {
            Thread.Sleep(2000);
            driver.FindElement(countryCode).Click();
            driver.FindElement(countryCodeSearch).Clear();
            driver.FindElement(countryCodeSearch).SendKeys(prefix);
            driver.FindElement(countryCodeSelect).Click();
            
        }
        public void enterPhonenumber(string phoneNo)
        {
            Thread.Sleep(2000);
            
            
            driver.FindElement(mobileNumberField).SendKeys(phoneNo);
        }
        public void enterEmail(string email)
        {
            driver.FindElement(emailField).SendKeys(email);
        }
        public void enterPassword( string password)
        {
            driver.FindElement(passwordField).SendKeys(password);
        }
        public void clickLoginBtn()
        {
            driver.FindElement(loginBtn).Click();
        }
    }
}
