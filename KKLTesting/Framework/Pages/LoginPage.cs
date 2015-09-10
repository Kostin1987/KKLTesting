using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace KKLTesting.Framework.Pages
{
    class LoginPage:BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
            
        }

        public override void Open()
        {
            if (Driver != null)
            {
                Driver.Url = Settings.Default.url;
            }
        }
    }
}
