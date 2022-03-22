using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow_HomeTask.Steps.Registration
{
    [Binding, Scope(Feature = "RegistrationPosittiveScenario")]
    public class RegistrationPosittiveScenarioSteps
    {
        public IWebDriver driver = new ChromeDriver("D:\\webdrivers");

        [Given(@"My registration page is opened")]
        public void GivenMyRegistrationPageIsOpened()
        {
            Registration_Page openPage = new Registration_Page(driver);
            openPage.OpenPage();
        }

        [When(@"I have entered my first name (.*)")]
        public void WhenIHaveEnteredMyFirstNameTaras(string firstName)
        {
            Registration_Page regPage = new Registration_Page(driver);
            regPage.EnterFirstName(firstName);
        }

        [When(@"I have entered my second name (.*)")]
        public void WhenIHaveEnteredMySecondNameKerbut(string secondName)
        {
            Registration_Page regPage = new Registration_Page(driver);
            regPage.EnterSecondName(secondName);
        }

        [When(@"I have entered my email (.*)")]
        public void WhenIHaveEnteredMyEmailBakukievteamMail_Ru(string email)
        {
            Registration_Page regPage = new Registration_Page(driver);
            regPage.EnterEmail(email);
        }

        [When(@"I have entered my phone number (.*)")]
        public void WhenIHaveEnteredMyPhoneNumber(string phone)
        {
            Registration_Page regPage = new Registration_Page(driver);
            regPage.EnterPhone(phone);
        }

        [When(@"I have entered my adress (.*)")]
        public void WhenIHaveEnteredMyAdressDevEducationStr(string adress)
        {
            Registration_Page regPage = new Registration_Page(driver);
            regPage.EnterAdress(adress);
        }

        [When(@"I have entered my city (.*)")]
        public void WhenIHaveEnteredMyCityBaku(string city)
        {
            Registration_Page regPage = new Registration_Page(driver);
            regPage.EnterCity(city);
        }

        [When(@"I have selected my region")]
        public void WhenIHaveSelectedMyRegion()
        {
            Registration_Page regPage = new Registration_Page(driver);
            regPage.EnterRegion();
        }

        [When(@"I have entered my password (.*)")]
        public void WhenIHaveEnteredMyPassword(string regPassw)
        {
            Registration_Page regPage = new Registration_Page(driver);
            regPage.EnterPassword(regPassw);
        }

        [When(@"I have confirmed password (.*)")]
        public void WhenIHaveConfirmedPassword(string confRegPassw)
        {
            Registration_Page regPage = new Registration_Page(driver);
            regPage.EnterConfirmPassword(confRegPassw);
        }

        [When(@"I have clicked the confirm button")]
        public void WhenIHaveClickedTheConfirmButton()
        {
            Registration_Page regPage = new Registration_Page(driver);
            regPage.SubmitButtonValid();
        }

        [Then(@"the browser redirected me to my account page")]
        public void ThenTheBrowserRedirectedMeToMyAccountPage()
        {
            new Personal_Account(driver);
        }
        [Then(@"displayed the message (.*)")]
        public void ThenDisplayedTheMessageSizinSəxsiHesabınızYaradıldı(string expected)
        {
            Personal_Account accountPage = new Personal_Account(driver);
            string actual = accountPage.ActualPersonalNew();

            Assert.AreEqual(expected, actual);

            accountPage.TearDown();
        }
    }
}
