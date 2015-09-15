using KKLTesting.Framework.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KKLTesting.Framework.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement FieldUserName;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement FieldPassword;

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement ButtonLogin;
              
        public HomePage LoginAs(UserData user)
        {
            Type(FieldUserName, user.Name);
            Type(FieldPassword, user.Password);
            ButtonLogin.Click();
            return PageFactory.InitElements<HomePage>(Driver);
        }

        public override void Open()
        {
            Driver.Navigate().GoToUrl(Settings.Default.url);
        }
    }
}

