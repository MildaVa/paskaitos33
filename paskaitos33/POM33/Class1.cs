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

namespace paskaitos33.POM33
{
    internal class Class1
    {

        IWebDriver driver;
        //generalMethods32 genmethods;
        public Class1(IWebDriver driver)
        {
            this.driver = driver;
           // genmethods = new generalMethods32(driver);
        }
    }
}
