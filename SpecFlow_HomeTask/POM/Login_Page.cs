using OpenQA.Selenium;
using System;

namespace SpecFlow_HomeTask.Steps
{
    class Login_Page
    {
        private IWebDriver driver;
        private string urlLogin;
        private By loginField = By.XPath("//div/input[@type='text']");
        private By passwordField = By.XPath("//div/input[@type='password']");
        private By submitButton = By.XPath("//div/input[@type='submit']");
        private By actualResult = By.XPath("//div[@class='warning']");

        public Login_Page(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Open_Page()
        {
            urlLogin = "https://anadolu.az/index.php?route=account/login";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(urlLogin);

            if (driver.FindElements(By.XPath("//*[@id='content']/div[2]/div[1]/h1/strong")).Count < 0)
            {
                throw new InvalidOperationException("We are in the wrong page");
            }
        }
        public void EnterLogin(string login)
        {
            driver.FindElement(loginField).SendKeys(login);
        }
        public void EnterPassword(string password)
        {
            driver.FindElement(passwordField).SendKeys(password);
        }
        public Personal_Account SubmitButtonValid()
        {
            driver.FindElement(submitButton).Click();
            return new Personal_Account(driver);
        }
        public void SubmitButtonInvalid()
        {
            driver.FindElement(submitButton).Click();
        }
        public string ActualResultIvnalid()
        {
            IWebElement findActual = driver.FindElement(actualResult);
            return findActual.Text;
        }
        public void TearDown()
        {
            driver.Quit();
        }
    }
}

