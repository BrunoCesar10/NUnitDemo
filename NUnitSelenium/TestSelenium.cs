using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace NUnitSelenium
{
    [TestFixture]
    public class UnitTest1
    {
        IWebDriver driver;

        [SetUp]
        public void iniciaBrowser()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            driver = new ChromeDriver(chromeOptions);
        }
        [Test]
        public void TestMethodLogin()
        {
            string paginaInicial = "https://stackoverflow.com/";
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(paginaInicial);
            driver.FindElement(By.XPath("/html/body/header/div/ol[2]/li[2]/a[1]")).Click();
            //System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.Id("email")).SendKeys("bcesar97.bc@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("testeselenium1");
            driver.FindElement(By.XPath("//*[@id=\"submit-button\"]")).Click();
            string paginaAtual = driver.Url.ToString();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"mainbar\"]/div[1]/h1")));
        }
        
        [TearDown]
        public void fechaBrowser()
        {
            driver.Close();
        }
    }
}
