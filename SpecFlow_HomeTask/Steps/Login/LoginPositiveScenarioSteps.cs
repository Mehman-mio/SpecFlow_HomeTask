using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlow_HomeTask.Steps
{
    [Binding, Scope(Feature = "LoginPositiveScenario")]
    public class LoginPositiveScenarioSteps
    {
        public IWebDriver driver = new ChromeDriver("D:\\webdrivers");

        [Given(@"My account login page is opened")]
        public void GivenMyAccountLoginPageIsOpened()
        {
            Login_Page openPage = new Login_Page(driver);
            openPage.Open_Page();
        }

        [When(@"I have entered (.*)")]
        public void WhenIHaveEnteredLoginBakukievteamMail_Ru(string login)
        {
            Login_Page loginPage = new Login_Page(driver);
            loginPage.EnterLogin(login);
        }

        [When(@"I have also entered (.*)")]
        public void WhenIHaveAlsoEnteredPassword(string password)
        {
            Login_Page loginPage = new Login_Page(driver);
            loginPage.EnterPassword(password);
        }

        [When(@"I press login button")]
        public void WhenIPressLoginButton()
        {
            Login_Page loginPage = new Login_Page(driver);
            loginPage.SubmitButtonValid();
        }

        [Then(@"the browser redirected me to my account page")]
        public void ThenTheBrowserRedirectedMeToMyAccountPage()
        {
            new Personal_Account(driver);
        }
        [Then(@"display the (.*) that I am in my account page")]
        public void ThenDisplayTheMənimHesabımThatIAmInMyAccountPage(string expected)
        {
            Personal_Account accountPage = new Personal_Account(driver);
            string actual = accountPage.ActualPersonalPage();

            Assert.AreEqual(expected, actual);

            accountPage.TearDown();
        }
    }
}