using System;
using System.Threading;
using KKLTesting.Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace KKLTesting.Test
{

    public class TestCase1 : BasicTestCase
    {
        private readonly LoginPage _loginPage = PageFactory.InitElements<LoginPage>(GetWebDriver());
        private HomePage _homePage;

        [Test,Timeout(20000)]
        public void LoginTest()
        {
            _loginPage.Open();
            _homePage = _loginPage.LoginAs(paxa1887);
            Assert.IsTrue(_homePage.IsLoggedIn());               
            _homePage.Logout();
            Assert.IsTrue(_homePage.IsLoggedOut());           

        }

    }
}
