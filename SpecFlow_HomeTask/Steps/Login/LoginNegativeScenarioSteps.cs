using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow_HomeTask.Steps.LoginNegativeScenario
{
    [Binding, Scope(Feature = "LoginNegativeScenario")]
    public class LoginNegativeScenarioSteps
    {
        public IWebDriver driver = new ChromeDriver("D:\\webdrivers");

        [Given(@"My account login page is opened")]
        public void GivenMyAccountLoginPageIsOpened()
        {
            Login_Page openPage = new Login_Page(driver);
            openPage.Open_Page();
        }

        [When(@"I have entered login (.*)")]
        public void WhenIHaveEnteredLoginInvalid(string login)
        {
            Login_Page loginPage = new Login_Page(driver);
            loginPage.EnterLogin(login);
        }

        [When(@"I have also entered password (.*)")]
        public void WhenIHaveAlsoEnteredPasswordInvalid(string password)
        {
            Login_Page loginPage = new Login_Page(driver);
            loginPage.EnterPassword(password);
        }

        [When(@"I have clicked login button")]
        public void WhenIHaveClickedLoginButton()
        {
            Login_Page loginPage = new Login_Page(driver);
            loginPage.SubmitButtonInvalid();
        }
        [Then(@"Error message (.*) is displayed")]
        public void ThenErrorMessageIsDisplayed(string errorMessage)
        {
            string expected = errorMessage;
            Login_Page loginPage = new Login_Page(driver);
            string actual = loginPage.ActualResultIvnalid();

            Assert.AreEqual(expected, actual);

            loginPage.TearDown();
        }
    }
}
