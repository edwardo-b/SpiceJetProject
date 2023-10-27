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
    public static class WebDriverExtensions
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }
    }

    internal class AddonsPage
    {
        IWebDriver driver;
       
        public By continueBtn = By.XPath("(//*[@data-testid=\"add-ons-continue-footer-button\"])[3]");
        public By AddOnsPagePopUp = By.XPath("//*[@class=\"at_addon_modal_content\"]");
        public By closeAddOnsPopUp = By.XPath("//*[@class=\"at_addon_close\"]");
        public By addOnPopUpBooknow = By.XPath("//*[@class=\"at_addon_booknowbtn\"]");
        public By addBtn = By.XPath("//*[@data-testid=\"bookingFlow-blueRibbonBag-add-cta\"]");
        public AddonsPage(IWebDriver driver) 
        {
            this.driver = driver;
            
        }

        public void clickContinueBtn()

        {
            

            var btn = driver.FindElement(continueBtn);
            for (int i = 0; i < 2; i++) { btn.Click(); }
        }
        public void AddOnPagePopUpIsDisplayed()
        {
            Assert.IsTrue(driver.FindElement(AddOnsPagePopUp).Displayed);
        }
        public void clearAddOnsPagePopUp()
        {
            var btn = driver.FindElement(closeAddOnsPopUp);
            btn.Click();
        }
        public void clickBookNow()
        {
            driver.FindElement(addOnPopUpBooknow).Click();
        }
        public void clickAddOnBtn()
        {
            var button = driver.FindElement(addBtn);
            button.Click();
        }
        
    }
}
