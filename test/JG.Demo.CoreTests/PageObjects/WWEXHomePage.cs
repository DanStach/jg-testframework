using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace JG.Demo.CoreTests.PageObjects
{
    public class WWEXHomePage : DemoPage
    {
        // variables that define xpaths and css
        private string logoXPath= "//*[@id='logo']";
        private string menuCareersXPath = "//*[@id='menu-main-1']/li[4]";
        private string modTechDevXPath = "//*[@id='team']/div/ul/li[8]";
        private string modTechDevPopupXPath = "//*[@id='perk8']/div/a";
        private string modTechDevQALeadXPath = "/html/body/div/div/div/div/article/div/table/tbody/tr[4]/td[1]/a";
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
        public IWebElement modTechDev
        {
            get { return this.Driver.FindElement(By.XPath(modTechDevXPath)); }
        }
        public IWebElement modTechDevPopup
        {
            get { return this.Driver.FindElement(By.XPath(modTechDevPopupXPath)); }
        }
        public IWebElement modTechDevQALead
        {
            get { return this.Driver.FindElement(By.XPath(modTechDevQALeadXPath)); }
        }

    }
}
