using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiceJetProject.Pages
{
    internal class PaymentPage
    {
        IWebDriver driver;
        public By CardNumber = By.XPath("//*[@placeholder=\"Enter Card Number Here\"]");
        public By CardName = By.XPath("//*[@id=\"name_on_card\"]");
        public By CardExpMonth = By.XPath("//*[@placeholder=\"MM\"]");
        public By CardExpYear = By.XPath("//*[@placeholder=\"YY\"]");
        public By CardCVV = By.XPath("//*[@id=\"security_code\"]");
        public By TnCcheckBox=By.XPath("data-testid=\"svg-img\"");
        public By ClickProceedToPayBtn = By.XPath("data-testid=\"common-proceed-to-pay\"");





        public PaymentPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterCardDetails(string number, string name, string expMonth, string expYear, string CVV)
        {
            Thread.Sleep(10000);
            driver.FindElement(CardNumber).SendKeys(number);
            driver.FindElement(CardName).SendKeys(name);
            driver.FindElement(CardExpMonth).SendKeys(expMonth);
            driver.FindElement(CardExpYear).SendKeys(expYear);
            driver.FindElement(CardCVV).SendKeys(CVV);
            
            ;
        }

        public void tickTnCBox()
        {
            driver.FindElement(TnCcheckBox).Click();
        }

        public void clickPayBtn()
        {
            Thread.Sleep(2000);
            driver.FindElement(ClickProceedToPayBtn).Click();
        }
    }
}
