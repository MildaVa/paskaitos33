using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V108.CSS;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Data;

namespace paskaitos33
{
    internal class paskaita33
    {
        static IWebDriver driver;
        [SetUp]
        public static void SETUP()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications"); // to disable notification
            driver = new ChromeDriver(options);

            driver.Manage().Window.Maximize();
            driver.Url = "https://www.1a.lt/";
            //laukimas kol elementai uzsikraus:
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//a[@class='c-button']")).Click();
        }
        [TearDown]
        public static void TearDown()
        {
            //driver.Quit();
        }
    }
}
