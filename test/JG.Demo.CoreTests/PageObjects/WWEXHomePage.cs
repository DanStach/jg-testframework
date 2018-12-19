using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace JG.Demo.CoreTests.PageObjects
{
    public class WWEXHomePage : DemoPage
    {
        private string logoXPath= "//*[@id='logo']";
        private string menuCareersXPath = "//*[@id='menu-main-1']/li[4]";

        public WWEXHomePage(IWebDriver driver, Uri baseUrl, string path) : base(driver, baseUrl, path)
        {
        }

        public IWebElement logo
        {
            get { return this.Driver.FindElement(By.XPath(logoXPath)); }
        }

        public IWebElement menuCareers
        {
            get { return this.Driver.FindElement(By.XPath(menuCareersXPath)); }
        }
    }
}
