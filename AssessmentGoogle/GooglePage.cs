using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AssessmentGoogle
{
    public class GooglePage
    {
        public IWebDriver driver;
        
        public void InitGooglePage()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            options.AddArguments("--lang=en-GB");
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public void SetSearchVaue(string searchName)
        {
            IWebElement searchField = driver.FindElement(By.XPath("//input[@title='Search']"));
            searchField.SendKeys(searchName);
            searchField.Submit();
        }

        public bool IsResultPresent(string resultName)
        {
            return driver.FindElement(By.XPath($"//*[text()='{resultName}']")).Displayed;
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }
    }
}
