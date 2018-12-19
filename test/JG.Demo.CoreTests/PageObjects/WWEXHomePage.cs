using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace JG.Demo.CoreTests.PageObjects
{
    public class WWEXHomePage : DemoPage
    {
        public WWEXHomePage(IWebDriver driver, Uri baseUrl, string path) : base(driver, baseUrl, path)
        {
        }

        public IWebElement logo
        {
            get { return this.Driver.FindElement(By.XPath(@"//*[@id='logo']")); }
        }
    }
}
