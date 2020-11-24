using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Akakce_test.Pages;
using System.Threading;

namespace Akakce_test.Pages
{
   public  class ProductPage : BasePage
    {
        public IWebElement product => _driver.FindElement(By.XPath("//*[@id='TPL']/li[5]/a"));
        public IWebElement favoriteBtn => _driver.FindElement(By.ClassName("ufo_v8"));
        public IWebElement fAddBtn => _driver.FindElement(By.Id("btnUfoSave"));
 

        public ProductPage(IWebDriver driver) : base(driver)
        {

        }
        public void AddtoMyFavorites()
        {
            product.Click();
            Thread.Sleep(2000);
            favoriteBtn.Click();
            Thread.Sleep(2000);
            fAddBtn.Click();
            Thread.Sleep(5000);
        }
    }
}
