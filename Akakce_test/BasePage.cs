using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Akakce_test.Pages;

namespace Akakce_test
{
    public class BasePage
    {
        public IWebDriver _driver { get; set; }
        
        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }
       
    }
}
