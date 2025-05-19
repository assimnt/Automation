using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FEAST_DEMO
{
   public class ContextMenu : Driver
    {
        By ContextMenuclick = By.XPath("//label[normalize-space()='Context Menu']");
        //By oK = By.XPath("//div[1]//div[1]//ul[1]//li[11]");

        public void context()
        {
            clicks(driver, ContextMenuclick, TimeSpan.FromSeconds(200));

            //IWebElement elementToRightClick = driver.FindElement(By.XPath("//div[@id='hot-spot']")); // Replace with actual ID or locator
            IWebElement elementToRightClick = driver.FindElement(By.Id("hot-spot")); // Replace with actual ID or locator

            // Create Actions object
            Actions actions = new Actions(driver);

            // Perform right-click (context click)
            actions.ContextClick(elementToRightClick).Perform();
            //clicks(driver, oK, TimeSpan.FromSeconds(200));
             driver.SwitchTo().Alert().Accept();
            System.Threading.Thread.Sleep(2000);

        }
    }
}
