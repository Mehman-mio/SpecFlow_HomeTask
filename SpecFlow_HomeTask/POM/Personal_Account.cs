using OpenQA.Selenium;
using System;

namespace SpecFlow_HomeTask.Steps
{
    class Personal_Account
    {
        private IWebDriver driver;
        private By accountPage = By.XPath("//div/h2[@class='header-3']");
        private By accountNew = By.XPath("//div/div/h1/strong");

        public Personal_Account(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string ActualPersonalPage()
        {
            IWebElement findActual = driver.FindElement(accountPage);
            return findActual.Text;
        }
        public string ActualPersonalNew()
        {
            IWebElement findActual = driver.FindElement(accountNew);
            return findActual.Text;
        }
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
