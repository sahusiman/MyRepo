using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LandingPageAutomation.Tests1.Repository
{
    class LoginPageObjects
    {
        IWebDriver driver;

        public LoginPageObjects(IWebDriver driver)
        {

            this.driver = driver;
        }
        //Objects Identification
        readonly By txtusername = By.Id("userNameInput");
        readonly By txtpasssword = By.Id("passwordInput");
        readonly By btnlogin = By.Id("submitButton");
        //Passing UserName and Password
        public void Login(String UserName, String Password)
        {
            driver.FindElement(txtusername).SendKeys(UserName);
            driver.FindElement(txtpasssword).SendKeys(Password);
        }
        //Clicking on Login Button
        public void Clicklogin()
        {

            driver.FindElement(btnlogin).Click();
            Thread.Sleep(20000);
        }

    }
}
