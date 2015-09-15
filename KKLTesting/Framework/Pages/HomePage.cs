using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace KKLTesting.Framework.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        [FindsBy(How = How.Id, Using = "logout-dropdown")]
        public IWebElement DropLogOut;

        [FindsBy(How = How.CssSelector, Using = "a[href*='login']")]
        public IWebElement LinkLogIn;

        [FindsBy(How = How.LinkText, Using = "Log Out")]
        public IWebElement LinkLogOut;

        [FindsBy(How = How.LinkText, Using = "Test")]
        public IWebElement LinkTest;

        [FindsBy(How = How.LinkText, Using = "EDITOR")]
        public IWebElement LinkEditor;

        [FindsBy(How = How.LinkText, Using = "ANALYZER")]
        public IWebElement LinkAnalyzer;

        [FindsBy(How = How.LinkText, Using = "REPORT EDITOR")]
        public IWebElement LinkReport;

        [FindsBy(How = How.LinkText, Using = "Document Editor")]
        public IWebElement LinkPageEditor;

        [FindsBy(How = How.LinkText, Using = "Analyzer")]
        public IWebElement LinkPageAnalyzer;

        [FindsBy(How = How.LinkText, Using = "Test")]
        public IWebElement LinkPageReportEditor;

        public override void Open()
        {

        }

        public bool IsLoggedOut()
        {
            WaitRenderElement(LinkLogIn);
            return IsElementPresent(LinkLogIn);

        }

        public bool IsLoggedIn()
        {
            WaitRenderElement(DropLogOut);
            return IsElementPresent(DropLogOut);

        }

        public void Logout()
        {
            WaitRenderElement(DropLogOut);
            DropLogOut.Click();
            WaitRenderElement(LinkLogOut);
            LinkLogOut.Click();
        }

        public void ChooseProject()
        {
            WaitRenderElement(LinkTest);
            LinkTest.Click();

        }

        public bool IsChooseProject()
        {
            WaitRenderElement(LinkPageReportEditor);
            return IsElementPresent(LinkPageReportEditor);
        }

        public void ChooseEditor()
        {
            WaitRenderElement(LinkEditor);
            LinkEditor.Click();
        }


        public bool IsEditor()
        {
            WaitRenderElement(LinkEditor);
            return IsElementPresent(LinkEditor);
        }

        public void ChooseAnalyzer()
        {
            WaitRenderElement(LinkAnalyzer);
            LinkAnalyzer.Click();
        }


        public bool IsPageAnalyzer()
        {
            WaitRenderElement(LinkPageAnalyzer);
            return IsElementPresent(LinkPageAnalyzer);
        }

        public void ChooseReportEditor()
        {
            WaitRenderElement(LinkReport);
            LinkReport.Click();
        }


        public bool IsPageReportEditor()
        {
            WaitRenderElement(LinkPageReportEditor);
            return IsElementPresent(LinkPageReportEditor);
        }

    }
}
