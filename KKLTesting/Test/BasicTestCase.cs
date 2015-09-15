using System;
using KKLTesting.Framework.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace KKLTesting.Test
{

    public class BasicTestCase
    {
        public UserData paxa1887 = new UserData(Settings.Default.user, Settings.Default.password);

        protected static IWebDriver Driver { get; set; }

        protected static IWebDriver GetWebDriver()
        {
            if (Driver == null)
            {
                Driver = new ChromeDriver();
                Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(Settings.Default.time));
            }
            return Driver;
        }

       
        [ClassCleanup]
        protected static void TearDown()
        {
            Driver.Quit();
        }
    }
}
