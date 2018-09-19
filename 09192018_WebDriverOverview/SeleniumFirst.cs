using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace _09192018_WebDriverOverview
{
    [TestFixture]
    class SeleniumFirst
    {
        private IWebDriver driver;
        [OneTimeSetUp] //Strt one time before all methods
        public void BeforeAllMethods()
        {
            driver = new ChromeDriver();
            //driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [SetUp] //Performong before every method
        public void SetUp()
        {
            driver.Navigate().GoToUrl("https://www.google.com.ua/");
        }

        [OneTimeTearDown] //Strt one time after all methods
        public void AfterAllMethods()
        {
            driver.Quit(); //Close browser and stop server   
        }

        [Test]
        public void TheATest()
        {
            //private IWebDriver driver;
            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.Navigate().GoToUrl("https://www.google.com.ua/");
            //
            driver.FindElement(By.Id("lst-ib")).Click();
            driver.FindElement(By.Id("lst-ib")).Clear();
            driver.FindElement(By.Id("lst-ib")).SendKeys("selenium ide" + Keys.Enter);
            Thread.Sleep(2000);
            //
            //driver.FindElement(By.Id("mKlEF")).Click();
            driver.FindElement(By.LinkText("Selenium IDE")).Click();
            driver.FindElement(By.LinkText("Download")).Click();
            Thread.Sleep(2000);
            //
            Assert.AreEqual("Selenium IDE is a Chrome and Firefox plugin which records and plays back user interactions with the browser. Use this to either create simple scripts or assist in exploratory testing.",
                driver.FindElement(By.CssSelector("a[name=\"selenium_ide\"] > p")).Text);
            //driver.Quit(); //Close browser and stop server
            //driver.Close(); //Close just brovser
        }
    }
}
