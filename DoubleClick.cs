using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FEAST_DEMO
{
    public class DoubleClick:Driver
    {
        By Doubleclick = By.XPath("//label[normalize-space()='Double Click']");
        //By oK = By.XPath("//div[1]//div[1]//ul[1]//li[11]");



        public void DC()
        {
            clicks(driver, Doubleclick, TimeSpan.FromSeconds(200));
            IWebElement elementToDoubleClick = driver.FindElement(By.XPath("//p[contains(@class,'bg-info')]"));

            // Create Actions instance
            Actions actions = new Actions(driver);

            // Perform double click
            actions.DoubleClick(elementToDoubleClick).Perform();

        }
    }
}
