using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace KKLTesting.Framework.Pages
{
    public abstract class BasePage
    {
        public IWebDriver Driver;

        protected BasePage(IWebDriver driver)
        {
            this.Driver = driver;
        }

        protected void Type(IWebElement webElement, string text)
        {
            webElement.Clear();
            webElement.SendKeys(text);
        }

        public abstract void Open();
       

        public bool IsElementPresent(IWebElement element)
        {
            return element.Displayed;
        }
    }
}
