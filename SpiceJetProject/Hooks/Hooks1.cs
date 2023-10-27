using BoDi;
using Docker.DotNet.Models;
using SpiceJetProject.Variable;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Firefox;


namespace SpiceJetProject.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
       IWebDriver driver;
        private readonly IObjectContainer _container;
        public Hooks1(IObjectContainer container)
        {
            _container = container;
           
        }
        MySetting config = new MySetting();

        [BeforeScenario("@UI_test")]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("testing with hooks");
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            if (config.BrowserType == "Chrome")
            {
                
                driver = new ChromeDriver(); 
            }
            else if (config.BrowserType == "ie")
            {
                driver = new InternetExplorerDriver();
            }
            else if (config.BrowserType == "EE")
            {
                driver = new EdgeDriver();
            }
            else if(config.BrowserType=="FF")
            {
                FirefoxOptions options=new FirefoxOptions();
                options.AddArguments("--headless");
                driver = new FirefoxDriver(options);
            }
            else if (config.BrowserType == "Grid")
            {
                EdgeOptions options = new EdgeOptions();
                options.AddArguments("--headless");
                driver= new EdgeDriver(options);

            }

            driver.Manage().Window.Maximize();
            driver.Url = config.AppUrl;


            _container.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var driver=_container.Resolve<IWebDriver>();
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}