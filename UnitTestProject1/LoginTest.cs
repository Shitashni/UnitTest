using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class LoginTest
    {
        private IWebDriver driver;
        private LoginPage login;
        [TestInitialize] 
        public void Setup() { 
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://localhost:7091/");
            login = new LoginPage(driver);
        }

        [TestMethod]
        public void Login()
        {
            login.GoToLogin();
            login.LoginApplication("test2@test.com", "Admin@123");
        }
    }
}
