using Bytescout.Spreadsheet;
using NPOI.XWPF.UserModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiceJetProject.Pages

{
    public static class WebDriverExtensionsRegistrationPage
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
    internal class RegistrationPage
    {
        IWebDriver driver;

        public By TitleDropDown = By.XPath("//*[@class=\"form-control form-select \"]");
        public By FirstNameField = By.XPath("//*[@id=\"first_name\"]");
        public By LastNameField = By.XPath("//*[@id=\"last_name\"]");
        public By CountrySelect = By.XPath("//*[@class=\"form-control form-select\"]");
        public By DOB = By.XPath("//*[@id=\"dobDate\"]");
        public By MonthSelector = By.XPath("//*[@class=\"react-datepicker__month-select\"]");
        public By YearSelector = By.XPath("//*[@class=\"react-datepicker__year-select\"]");
        public By DaySelector = By.XPath("//*[@class=\"react-datepicker__day react-datepicker__day--012\"]");
        public By PhoneNumber = By.XPath("//*[@type=\"tel\"]");
        public By EmailField = By.XPath("//*[@id=\"email_id\"]");
        public By PasswordField = By.XPath("//*[@id=\"new-password\"]");
        public By ConfirmPasswordField = By.XPath("//*[@id=\"c-password\"]");
        public By TnCbox = By.XPath("//*[@id=\"defaultCheck1\"]");
        public By SubmitBtn = By.XPath("//*[@class=\"btn btn-red\"]");
        public By ShowPasswordIcon = By.XPath("(//*[@class=\"position-absolute top-50 end-0 translate-middle-y me-3\"])[2]");



        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void selectTitle()
        {
           Console.WriteLine(driver.FindElement(TitleDropDown).Text);
            driver.FindElement(TitleDropDown).Click();
            Thread.Sleep(1000);

            for (int i = 0; i < 3; i++)
            {
                driver.FindElement(TitleDropDown).SendKeys(Keys.ArrowDown);
            }
            driver.FindElement(TitleDropDown).SendKeys(Keys.Enter); 
        }

        public void enterFirstName(string firstname) 
        {
           var fname= driver.FindElement(FirstNameField);
            Console.WriteLine(fname.Text);
            fname.Clear();
            fname.SendKeys("firstname");
        }
        public void enterLastName(string lastName)
        {
            var lname= driver.FindElement(LastNameField);
            Console.WriteLine(lname.Text);
            lname.Clear();
            lname.SendKeys("lastName");
        }
        public void selectCountry()
        {
            Thread.Sleep(1000);
            driver.FindElement(CountrySelect).Click();
            Thread.Sleep(1000);
            for (int i = 0; i < 4; i++)
            {
                driver.FindElement(CountrySelect).SendKeys("u");
            }
            driver.FindElement(CountrySelect).SendKeys(Keys.Enter);
        }
        public void selectDOB() 
        {
          var dobClick=  driver.FindElement(DOB);
            Console.WriteLine(dobClick.Text);
            dobClick.Click();

            Thread.Sleep(1000);

            driver.FindElement(MonthSelector).Click();
            for (int i = 0; i < 7; i++)
            {
                driver.FindElement(MonthSelector).SendKeys(Keys.ArrowDown);
            }
            driver.FindElement(MonthSelector).SendKeys(Keys.Enter);


            Thread.Sleep(2000);
            driver.FindElement(YearSelector).Click();
            for (int i = 0; i < 4; i++)
            {
                driver.FindElement(YearSelector).SendKeys(Keys.ArrowUp);
            }
            driver.FindElement(MonthSelector).SendKeys(Keys.Enter);

            Thread.Sleep(2000);
            driver.FindElement(DaySelector).Click();
        }
        public void mobilePhoneNumber()
        {
            
           
            Thread.Sleep(2000);
            var number=  driver.FindElement(PhoneNumber);
            Console.WriteLine(number.Text);
            number.SendKeys(Keys.Backspace);
            number.SendKeys(Keys.Backspace);
            string path = @"C:\Users\Edward.Osei-Bonsu\Documents\SpiceJetExcel.xlsx";
            Spreadsheet document = new Spreadsheet();
            document.LoadFromFile(path);
            Worksheet worksheet = document.Workbook.Worksheets[1];
            var value = Convert.ToString(worksheet.Cell(0, 2));
            Console.WriteLine(value);
            try
            {
                number.SendKeys(value);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
           
        }
        public void enterEmail()
        {
            Thread.Sleep(3000);
            var email = driver.FindElement(EmailField);
            Console.WriteLine(email.Text);
            email.SendKeys(Keys.Backspace);
            Thread.Sleep(2000);
            try {
                string path = @"C:\Users\Edward.Osei-Bonsu\Documents\SpiceJetExcel.xlsx";
                Spreadsheet document = new Spreadsheet();
                document.LoadFromFile(path);
                Worksheet worksheet = document.Workbook.Worksheets[1];
                var value = Convert.ToString(worksheet.Cell(1, 1));
                Console.WriteLine(value);
                email.SendKeys(value);

            }
            catch (Exception e) { Console.WriteLine(e.Message); }
}
        public void enterPassword(string password)
        {
            Thread.Sleep(1000);
           
            IWebElement element=  driver.FindElement(PasswordField);
           
            element.Click();
            element.SendKeys(Keys.Backspace);
            element.SendKeys("Password123!");
            
           
        }
        public void confirmPassword(string password) 
        {
            Thread.Sleep(2000);
            var PWC=driver.FindElement(ConfirmPasswordField);
            PWC.SendKeys(Keys.Backspace);
            PWC.SendKeys("Password123!");
        }
        public void tickTnC()
        {
            Thread.Sleep(2000);
           
            
            IWebElement  TnC = driver.FindElement(TnCbox);
           
            TnC.Click();
        }
        public void clickSubmitBtn()
        {
            Thread.Sleep(2000);
            Console.WriteLine(driver.FindElement(SubmitBtn).Text);
            driver.FindElement(SubmitBtn).Click();
            
        }
        public void scrollToBottom()
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
        }


    }

    
}
