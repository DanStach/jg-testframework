using System;
using JG.Demo.CoreTests.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace JG.Demo.CoreTests
{
    [TestClass]
    public class WWEXPageTest : DemoTest
    {
        [TestMethod]
        public void WWEXHomePage_logo()
        {
             var homePage = new WWEXHomePage(this.Driver, this.BaseUrl, "/");
            homePage.Navigate();

            System.Threading.Thread.Sleep(10000);
            var displayed = homePage.logo.Displayed;

            Assert.IsTrue(displayed, "Logo is not displayed");
        }

        [TestMethod]
        public void WWEXHomePage_Title_TC()
        {
            // navigate to page
            var homePage = new GoogleHomePage(this.Driver, this.BaseUrl, "/");
            homePage.Navigate();

            // fixme: need to resplace sleep, with the page load fucntion
            System.Threading.Thread.Sleep(10000);


            // Verify 
            String expTitle = "Worldwide Express";
            String actTitle = homePage.Title;

            Assert.AreEqual("Worldwide Express - Shipping Logistics for Small and Midsize Businesses", actTitle, false);
            Assert.IsTrue(actTitle.Contains(expTitle), "Issue: title missing company name. Exp="+expTitle+ " Act="+actTitle);
        }

        [TestMethod]
        public void WWEXHomePage_Navigate_QALead()
        {
            // Navigate to page
            var homePage = new WWEXHomePage(this.Driver, this.BaseUrl, "/");
            homePage.Navigate();

            System.Threading.Thread.Sleep(5000);

            // Navigate to career page
            homePage.menuCareers.Click();
            System.Threading.Thread.Sleep(1000);

            // Navigate to Tech Dev page
            homePage.modTechDev.Click();
            System.Threading.Thread.Sleep(1000);
            homePage.modTechDevPopup.Click();
            System.Threading.Thread.Sleep(1000);

            // Navigate to QA Lead page
            homePage.modTechDevQALead.Click();
            System.Threading.Thread.Sleep(5000);

            // verify url
            string url = Driver.Url;
            Assert.IsTrue(url.Contains("jobs.jobvite.com"), "Issue with url");
        }
    }
}
