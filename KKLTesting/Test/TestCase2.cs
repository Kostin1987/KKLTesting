using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KKLTesting.Framework.Pages;
using NUnit.Core;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace KKLTesting.Test
{
    public class TestCase2 : BasicTestCase
    {
        private readonly LoginPage _loginPage = PageFactory.InitElements<LoginPage>(GetWebDriver());
        private HomePage _homePage;

        [Test]
        public void ChooseLinks()
        {

            _loginPage.Open();
            _homePage = _loginPage.LoginAs(paxa1887);
            Assert.IsTrue(_homePage.IsLoggedIn());
            _homePage.ChooseProject();
            Assert.IsTrue(_homePage.IsChooseProject());
            _homePage.ChooseEditor();
            Assert.IsTrue(_homePage.IsEditor());
            //_homePage.ChooseAnalyzer();
            //Assert.IsTrue(_homePage.IsPageAnalyzer());
            //_homePage.ChooseReportEditor();
            //Assert.IsTrue(_homePage.IsPageReportEditor());
            TearDown();

        }
    }
}
