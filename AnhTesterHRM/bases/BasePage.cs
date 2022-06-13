using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using AnhTesterHRM.DriverManage;

namespace AnhTesterHRM.bases
{
    class BasePage
    {
        public static IWebDriver driver;


        public void SetupBrowser(string browser)
        {
            driver = BDriverFactory.InitDriver(browser);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5000);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(2000);
        }

        public void TearDown()
        {
            driver.Quit();
        }
    }
}

