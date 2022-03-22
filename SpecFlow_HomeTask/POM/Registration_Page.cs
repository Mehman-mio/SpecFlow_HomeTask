using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SpecFlow_HomeTask.Steps.Registration
{
    class Registration_Page
    {
        private IWebDriver driver;
        private string urlRegistration;
        private By firstNameField = By.XPath("//input[@name='firstname']");
        private By secondNameField = By.XPath("//input[@name='lastname']");
        private By emailField = By.XPath("//input[@name='email']");
        private By phoneField = By.XPath("//input[@name='telephone']");
        private By adressField = By.XPath("//input[@name='address_1']");
        private By cityField = By.XPath("//input[@name='city']");
        private By regionField = By.XPath("//select[@name='zone_id']");
        private By passwordField = By.XPath("//tbody/tr/td/input[@name='password']");
        private By confirmPasswordField = By.XPath("//tbody/tr/td/input[@name='confirm']");
        private By submitButton = By.XPath("//input[@type='submit']");
        private By actErrortLogin = By.XPath("//div[@class='warning']");
        private By actEmptyName = By.XPath("//*[@id='content']/div[2]/form/div[1]/div//tr[1]/td[2]/span");
        private By actEmptySecName = By.XPath("//*[@id='content']/div[2]/form/div[1]/div//tr[2]/td[2]/span");
        private By actEmptyMail = By.XPath("//*[@id='content']/div[2]/form/div[1]/div//tr[3]/td[2]/span");
        private By actEmptyPhone = By.XPath("//*[@id='content']/div[2]/form/div[1]/div//tr[4]/td[2]/span");
        private By actEmptyAdress = By.XPath("//*[@id='content']/div[2]//div[2]//tr[5]/td[2]/span");
        private By actEmptyCity = By.XPath("//*[@id='content']/div[2]//div[2]//tr[7]/td[2]/span");
        private By actEmptyRegion = By.XPath("//*[@id='content']/div[2]//div[2]//tr[10]/td[2]/span[2]");
        private By actEmptyPassword = By.XPath("//*[@id='content']/div[2]//div[3]//tr[1]/td[2]/span");
        private By actDifferentPassw = By.XPath("//*[@id='content']/div[2]//tr[2]/td[2]/span");

        public Registration_Page(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void OpenPage()
        {
            urlRegistration = "https://anadolu.az/index.php?route=account/register";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(urlRegistration);

            if (driver.FindElements(By.XPath("//*[@id='content']/div[2]/div[1]/h1/strong")).Count < 0)
            {
                throw new InvalidOperationException("We are in the wrong page");
            }
        }

        public void EnterFirstName(string firstName)
        {
            driver.FindElement(firstNameField).SendKeys(firstName);
        }
        public void EnterSecondName(string secondName)
        {
            driver.FindElement(secondNameField).SendKeys(secondName);
        }
        public void EnterEmail(string email)
        {
            driver.FindElement(emailField).SendKeys(email);
        }
        public void EnterPhone(string phone)
        {
            driver.FindElement(phoneField).SendKeys(phone);
        }
        public void EnterAdress(string adress)
        {
            driver.FindElement(adressField).SendKeys(adress);
        }
        public void EnterCity(string city)
        {
            driver.FindElement(cityField).SendKeys(city);
        }
        public void EnterRegion()
        {
            string txt = "Baki";
           IWebElement selectRegion = driver.FindElement(regionField);
           SelectElement region = new SelectElement(selectRegion);
           region.SelectByText(txt);
        }
        public void EnterPassword(string regPassw)
        {
            driver.FindElement(passwordField).SendKeys(regPassw);
        }
        public void EnterConfirmPassword(string confRegPassw)
        {
            driver.FindElement(confirmPasswordField).SendKeys(confRegPassw);
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
        public string ActualErrorLogin()
        {
            IWebElement findActual = driver.FindElement(actErrortLogin);
           return findActual.Text;
        }
        public string ActualEmptyName()
        {
            IWebElement findActual = driver.FindElement(actEmptyName);
            return findActual.Text;
        }
        public string ActualEmptySecName()
        {
            IWebElement findActual = driver.FindElement(actEmptySecName);
           return findActual.Text;
        }
        public string ActualEmptyEmail()
        {
            IWebElement findActual = driver.FindElement(actEmptyMail);
           return findActual.Text;
        }
        public string ActualEmptyPhone()
        {
            IWebElement findActual = driver.FindElement(actEmptyPhone);
           return findActual.Text;
        }
        public string ActualEmptyAdress()
        {
            IWebElement findActual = driver.FindElement(actEmptyAdress);
           return findActual.Text;
        }
        public string ActualEmptyCity()
        {
            IWebElement findActual = driver.FindElement(actEmptyCity);
           return findActual.Text;
        }
        public string ActualEmptyRegion()
        {
            IWebElement findActual = driver.FindElement(actEmptyRegion);
           return findActual.Text;
        }
        public string ActualEmptyPassword()
        {
            IWebElement findActual = driver.FindElement(actEmptyPassword);
           return findActual.Text;
        }
        public string ActualDifferentPasswords()
        {
            IWebElement findActual = driver.FindElement(actDifferentPassw);
           return findActual.Text;
        }
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
