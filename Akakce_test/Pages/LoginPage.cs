using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using Akakce_test.Pages;

namespace Akakce_test
{
    public class LoginPage : BasePage 
    {

        public IWebElement emailtxtbox => _driver.FindElement(By.Name("life"));
        public IWebElement passwordtxtbox => _driver.FindElement(By.Name("lifp"));
        public IWebElement loginBtn => _driver.FindElement(By.Id("lfb"));
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }
        public void LogIn(string email, string password)
        {
            emailtxtbox.SendKeys(email);
            passwordtxtbox.SendKeys(password);
            loginBtn.Click();
        }  
    }
}
