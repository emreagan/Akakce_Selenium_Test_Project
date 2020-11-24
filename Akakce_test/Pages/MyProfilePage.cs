using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Akakce_test.Pages
{
    public class MyProfilePage : BasePage
    {
        public IWebElement  profileBtn => _driver.FindElement(By.XPath(".//*[@id='HM_v8']/i/a"));
        public IWebElement myFavoritesBtn => _driver.FindElement(By.XPath(".//*[@id='AL']/li[2]/a[1]"));
        public IWebElement removeFavBtn => _driver.FindElement(By.XPath(".//*[@id='UFP_v8']/li/a/span[4]"));
        public IWebElement removeBtn=> _driver.FindElement(By.ClassName("ur"));
        public MyProfilePage(IWebDriver driver) :base(driver)
        {

        }
        public void MyProfile()
        {
            profileBtn.Click();
        }
        public void MyFavorites()
        {
            myFavoritesBtn.Click();
        }
        public void RemoveFav()
        {
            removeFavBtn.Click();
            Thread.Sleep(5000);
            removeBtn.Click();
        }
    }
}
