using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Akakce_test.Pages;
using System;
using OpenQA.Selenium.Support.UI;


namespace Akakce_test
{
    public class Tests
    {
        
        public IWebDriver driver { get; set; }
        
        [OneTimeSetUp]
        public void Setup()
        { 
            string link = "https://www.akakce.com/";
            driver = new ChromeDriver(@"C:\drivers");
            driver.Navigate().GoToUrl(link);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void RunTest()
        {
            HomePage home = new HomePage(driver);
            home.SignIn();
            Thread.Sleep(4000);
            LoginPage login = new LoginPage(driver);
            Thread.Sleep(4000);
            login.LogIn("admin1234@gmail.com", "admin1234");
            Thread.Sleep(4000);
            home.Search("Samsung");
            Thread.Sleep(4000);
            home.ChangePage();
            Thread.Sleep(4000);
            ProductPage product = new ProductPage(driver);
            product.AddtoMyFavorites();
            MyProfilePage myProfile = new MyProfilePage(driver);
            myProfile.MyProfile();
            Thread.Sleep(4000);
            myProfile.MyFavorites();
            Thread.Sleep(4000);
            myProfile.RemoveFav();
            Assert.Pass();
        }
    }
}