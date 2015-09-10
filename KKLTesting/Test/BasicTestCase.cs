using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace KKLTesting.Test
{
    [TestClass]
    public class  BasicTestCase
    {

        protected static IWebDriver Driver;
        public void TestLoginLogout()
        {
        }

        [ClassCleanup]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
