using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationlTest02_DealsDray.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement Username => driver.FindElement(By.Name("username"));
        IWebElement Password => driver.FindElement(By.Name("password"));
        IWebElement LoginButton => driver.FindElement(By.XPath("Login"));

        public void Login(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            Password.Submit();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }
}
