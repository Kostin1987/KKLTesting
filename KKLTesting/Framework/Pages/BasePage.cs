using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace KKLTesting.Framework.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver Driver;

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


        protected bool IsElementPresent(IWebElement element)
        {
            return element.Displayed;
        }

       
        protected void WaitRenderElement(IWebElement element)
        {
            while (true)
            {
                if (!element.Displayed)
                {
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
