using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Akakce_test.Pages;

namespace Akakce_test.Pages
{
    public class HomePage : BasePage
    {
        public IWebElement searchTxt => _driver.FindElement(By.Name("q"));
        public IWebElement signInBtn=> _driver.FindElement(By.XPath(".//* [@id='H_rl_v8']/a[2]"));
        public IWebElement searchBtn => _driver.FindElement(By.XPath(".//* [@id='H_s_v8']/button"));
        public IWebElement changePageBtn => _driver.FindElement(By.XPath(".//*[@id='TPL']/li[27]/p/a[2]"));

        public HomePage(IWebDriver driver) :base(driver)
        {

        }
        public void SignIn()
        {
            signInBtn.Click();
        }
        public void Search(string key)
        {
            searchTxt.SendKeys(key);
            searchBtn.Click();
        }
        public void ChangePage()
        {
            changePageBtn.Click();

        }

    }
}
