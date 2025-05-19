using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FEAST_DEMO
{
    public class Webtable : Driver
    {
        By Webtables = By.XPath("//label[normalize-space()='Webtable']");
        //By Name = By.XPath("//th[@aria-label='Name: activate to sort column ascending']");
        public void WTables()
        {
            clicks(driver, Webtables, TimeSpan.FromSeconds(200));
            IWebElement columnHeader = driver.FindElement(By.XPath("//th[@aria-label='Name: activate to sort column descending']"));
            columnHeader.Click();
            clicks(driver, Webtables, TimeSpan.FromSeconds(200));
            IWebElement columnHeaders = driver.FindElement(By.XPath("//th[@aria-label='Office: activate to sort column ascending']"));
            columnHeaders.Click();



            IWebElement columnHeaderss = driver.FindElement(By.XPath("//th[@aria-label='Age: activate to sort column ascending']"));
            columnHeaderss.Click();
            // First click typically sorts ascending

            //clicks(driver, Name, TimeSpan.FromSeconds(200));


        }
    }
}
