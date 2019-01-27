using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using WaitHelpers = SeleniumExtras.WaitHelpers;


namespace LandingPageAutomation.Tests1.Repository
{
    class NotificationObjects
    {
        IWebDriver driver;

        public NotificationObjects(IWebDriver driver)
        {

            this.driver = driver;
        }

        //objects Identification
        //readonly By Leftmenu1 = By.XPath("//*[@id='lpMenu']/div[1]");
        //readonly By Leftmenu2 = By.XPath("//*[@id='notificationMenu-placeholder']");
        //readonly By Learing = By.XPath("//*[@id='details-container']/div/div");
        //readonly By IncidenceMenu = By.XPath("html/body/div[14]/div[3]/div[2]/div/div[1]/ul/li[2]");
        //readonly By NotificationSub2 = By.XPath("html/body/div[14]/div[3]/div[4]/div/div[1]/ul/li[2]");
        //readonly By Incident1 = By.XPath("html/body/div[14]/div[3]/div[2]/div/div[2]/div/div/div/div/div");
        //readonly By IncidenceClose = By.XPath("html/body/div[16]/div/div[1]/div/div/div/div[1]/button");

        public void LearningTest()
        {

            Actions act2 = new Actions(driver);
            Thread.Sleep(100000);
            act2.MoveToElement(driver.FindElement(By.XPath("//*[@id='lpMenu']/div[1]"))).Build().Perform();
            WebDriverWait waiting = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            waiting.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='notificationMenu-placeholder']")));
            //Clicking on the Notification  Menu
            act2.MoveToElement(driver.FindElement(By.XPath("//*[@id='notificationMenu-placeholder']")));
            act2.Build();
            act2.Perform();
            driver.FindElement(By.XPath("//*[@id='notificationMenu-placeholder']")).Click();
            //Clicking on Notificatin Menu
            driver.FindElement(By.XPath("//*[@id='details-container']/div/div")).Click();
            var Note = "No notification for you";
            driver.FindElement(By.XPath("//*[@id='details-container']/div/div")).Click();
            //Check if Notification is not available than displaying the appropriate message else click on 
            //the notificaiton.
            if (driver.FindElement(By.XPath("//*[@id='details-container']/div/div")).Text == Note)
            {
                Console.WriteLine("No Notifications Available");
                Thread.Sleep(10000);
            }
            else

                driver.FindElement(By.XPath("//*[@id='details-container']/div/div[1]/div/div/p[1]")).Click();

        }
        public void LearingNotificationFound()
        {

            //Actions act2 = new Actions(driver);
            //Thread.Sleep(3000);
            //act2.MoveToElement(driver.FindElement(By.XPath("//*[@id='lpMenu']/div[1]"))).Perform();
            //WebDriverWait waiting = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            //waiting.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//*[@id='notificationMenu-placeholder']")));
            //////Clicking on the Notification  Menu
            //act2.MoveToElement(driver.FindElement(By.XPath("//*[@id='notificationMenu-placeholder']")));
            //act2.Build();
            //act2.Perform();
            //driver.FindElement(By.XPath("//*[@id='notificationMenu-placeholder']")).Click();
            //Thread.Sleep(3000);
            //driver.FindElement(By.XPath("//*[@id='details-container']/div/div[1]/div/div/p[1]")).Click();
            var Note = "No notifications for you";
            driver.FindElement(By.XPath("html/body/div[14]/div[3]/div[2]/div/div[1]/ul/li[2]/span")).Click();
            if (driver.FindElement(By.XPath("//*[@id='details-container']/div/div")).Text == Note)
            {
                Console.WriteLine("No Notification Available");
                Thread.Sleep(10000);
            }
            else

            driver.FindElement(By.XPath("html/body/div[14]/div[3]/div[2]/div/div[2]/div/div/div/div/div")).Click();

            string win = driver.CurrentWindowHandle;
            driver.SwitchTo().Window(win);
            driver.FindElement(By.XPath("html/body/div[16]/div/div[1]/div/div/div/div[1]/button")).Click();
        }
    }
}

        

    

