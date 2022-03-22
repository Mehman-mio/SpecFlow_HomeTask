using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace SpecFlow_HomeTask.Steps.Registration
{
    [Binding, Scope(Feature = "RegistrationWithEmptyFields")]
    public class RegistrationWithEmptyFieldsSteps
    {
        public IWebDriver driver = new ChromeDriver("D:\\webdrivers");

        [Given(@"My registration page is opened")]
        public void GivenMyRegistrationPageIsOpened()
        {
            Registration_Page openPage = new Registration_Page(driver);
            openPage.OpenPage();
        }
        
        [When(@"I have not filled in any mandatory field")]
        public void WhenIHaveNotFilledInAnyMandatoryField()
        {
            Console.WriteLine("It wasn`t filled in");
        }
        
        [When(@"I have clicked the confirm button")]
        public void WhenIHaveClickedTheConfirmButton()
        {
            Registration_Page regPage = new Registration_Page(driver);
            regPage.SubmitButtonInvalid();
        }
        
        [Then(@"displayed warning message about empty First Name field")]
        public void ThenDisplayedWarningMessageAboutEmptyFirstNameField()
        {
            Registration_Page regPage = new Registration_Page(driver);
            string expected = "Ad 1 simvoldan 32 simvola qədər olmalıdır!"; //Имя должно содержать от 1 до 32 символов
            string actual = regPage.ActualEmptyName();

            Assert.AreEqual(expected, actual);
        }
        
        [Then(@"displayed warning message about empty Second Name field")]
        public void ThenDisplayedWarningMessageAboutEmptySecondNameField()
        {
            Registration_Page regPage = new Registration_Page(driver);
            string expected = "Soyad 1 simvoldan 32 simvola qədər olmalıdır!";//Фамилия должно содержать от 1 до 32 символов
            string actual = regPage.ActualEmptySecName();

            Assert.AreEqual(expected, actual);
        }
        
        [Then(@"displayed warning message about empty Email field")]
        public void ThenDisplayedWarningMessageAboutEmptyEmailField()
        {
            Registration_Page regPage = new Registration_Page(driver);
            string expected = "E-Mail yanlış daxil edilmişdir!";//Не правильно введен емаил
            string actual = regPage.ActualEmptyEmail();

            Assert.AreEqual(expected, actual);
        }
        
        [Then(@"displayed warning message about empty Phone Number field")]
        public void ThenDisplayedWarningMessageAboutEmptyPhoneNumberField()
        {
            Registration_Page regPage = new Registration_Page(driver);
            string expected = "Telefon 3 rəqəmdən 32 rəqəmə qədər olmalıdır!";//Номер телефона должен содержать от 3 до 32 символов
            string actual = regPage.ActualEmptyPhone();

            Assert.AreEqual(expected, actual);
        }
        
        [Then(@"displayed warning message about empty Adress field")]
        public void ThenDisplayedWarningMessageAboutEmptyAdressField()
        {
            Registration_Page regPage = new Registration_Page(driver);
            string expected = "Ünvan 3 simvoldan 128 simvola qədər olmalıdır!"; //Адрес должен содержать от 3 до 128 символов
            string actual = regPage.ActualEmptyAdress();

            Assert.AreEqual(expected, actual);
        }
        
        [Then(@"displayed warning message about empty City field")]
        public void ThenDisplayedWarningMessageAboutEmptyCityField()
        {
            Registration_Page regPage = new Registration_Page(driver);
            string expected = "Şəhərin adı 2 simvoldan 128 simvola qədər olmalıdır!";//Название города должно содержать от 2 до 128 символов
            string actual = regPage.ActualEmptyCity();

            Assert.AreEqual(expected, actual);
        }
        
        [Then(@"displayed warning message about empty Region field")]
        public void ThenDisplayedWarningMessageAboutEmptyRegionField()
        {
            Registration_Page regPage = new Registration_Page(driver);
            string expected = "Rayon/vilayət seçin!";//Выберите регион
            string actual = regPage.ActualEmptyRegion();

            Assert.AreEqual(expected, actual);
        }
        
        [Then(@"displayed warning message about empty Password field")]
        public void ThenDisplayedWarningMessageAboutEmptyPasswordField()
        {
            Registration_Page regPage = new Registration_Page(driver);
            string expected = "Şifrə 4 simvoldan 20 simvola qədər olmalıdır!";//Пароль должен содержать от 4 до 20 символов
            string actual = regPage.ActualEmptyPassword();

            Assert.AreEqual(expected, actual);

            regPage.TearDown();
        }
    }
}
