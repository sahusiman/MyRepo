using LandingPageAutomation.Tests1.BaseClass;
using LandingPageAutomation.Tests1.Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace LandingPageAutomation.Tests1
{
    [TestFixture()]
   
    public class TestClass:BaseCls
    {
        


        [Test]
        public void NotificationClick()
        {
            
            NotificationObjects  Tst = new NotificationObjects(driver);
            Thread.Sleep(30000);
            Tst.LearningTest();
           
        }

        [Test]

        public void NotificationTest1()

        {

            //System.Environment.SetEnvironmentVariable("restart.browser.each.scenario", "false");
            NotificationObjects Tst2 = new NotificationObjects(driver);
            Thread.Sleep(4000);
            Tst2.LearingNotificationFound();
            driver.Close();
        }
    }
}
