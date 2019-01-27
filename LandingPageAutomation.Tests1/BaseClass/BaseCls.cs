using LandingPageAutomation.Tests1.Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingPageAutomation.Tests1.BaseClass
{
    public class BaseCls
    {

        public static IWebDriver driver = null;


        [SetUp]
        public void Initialize()
        {
            if (driver == null)
            {
                driver = new OpenQA.Selenium.IE.InternetExplorerDriver();
                //Opening of Laning Page and login in to the Website
                //Try to ensure if already logged in before running logic logic
                driver.Manage().Cookies.DeleteAllCookies();
                driver.Navigate().GoToUrl("https://landingpage-itc.oitcloud.vodafone.com");
                // driver.Manage().Window.Maximize();
                System.Threading.Thread.Sleep(30000);
                LoginPageObjects log = new LoginPageObjects(driver);
                log.Login("vfsvc-o365.spo-devadmin@vodafone-itc.com", "itcadmin@123456");
                log.Clicklogin();

            }
            //[TearDown]

            //public void Close()
            //{
            //    driver.Close();
            //}

        }
    }
}
