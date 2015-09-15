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
                    System.Threading.Thread.Sleep(5000);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
