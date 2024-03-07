using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{


     class LoginPage
    {
        private IWebDriver driver;
        public LoginPage(IWebDriver browser)
        {
            driver = browser;
        }

        private By login = By.CssSelector("a[class='nav-link text-dark1']");
        private IWebElement BtnLogin => driver.FindElement(login);

        private By username = By.Id("Input_Email");
        private IWebElement Username => driver.FindElement(username);

        private By password = By.Id("Input_Password");
        private IWebElement Password => driver.FindElement(password);
        private By loginClick = By.Id("login-submit");
        private IWebElement BtnLoginClick => driver.FindElement(loginClick);
        
        public void GoToLogin()
        {
            BtnLogin.Click();
        }

        public void LoginApplication(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            BtnLoginClick.Click();
        }
    }
}
