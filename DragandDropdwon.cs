using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace QA_FEAST_DEMO
{
    public class DragandDropdwon: Driver
    {

        By DDclick = By.XPath("//label[normalize-space()='Drag & Drop']");
        By draggable = By.XPath("//div[@class='draggable-box']//div[1]");
        By droppable = By.XPath("//div[contains(@class,'dropable-box')]//div[2]");
        By javasdrag = By.XPath("//div[contains(@class,'dropable-box')]//div[2]");
        By javadrop = By.XPath("//div[contains(@class,'dropable-box')]//div[1]");
       
        //IWebElement draggable = driver.FindElement(By.XPath("//div[@class='draggable-box']//div[1]"));
        //IWebElement droppable = driver.FindElement(By.XPath("//div[contains(@class,'dropable-box')]//div[1]"));

        // Perform drag-and-drop action
       
        public void DragandDropdwons() {
            clicks(driver, DDclick,TimeSpan.FromSeconds(300));
            IWebElement draggables = driver.FindElement(draggable);
            IWebElement droppables = driver.FindElement(droppable);
            IWebElement drag1 = driver.FindElement(javasdrag);
            IWebElement drop1 = driver.FindElement(javadrop);

            // Perform drag-and-drop action
            Actions actions = new Actions(driver);
            actions.DragAndDrop(draggables, droppables).Build().Perform();
            actions.DragAndDrop(drag1, drop1).Build().Perform();

        }
            





    }
}
