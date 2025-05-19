using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FEAST_DEMO
{
    public class Scrolling:Driver
    {
        By Scrollclick = By.XPath("//label[normalize-space()='Scrolling']");

        By Names = By.XPath("//div[@class='scrolling-outer']//input[@id='username']");
        By Passwords= By.XPath("//div[@class='scrolling-outer']//input[@id='pwd']");
        By submitbutton = By.XPath("//button[@id='submitbtn']");
      



        public void scroll()
        {
            clicks(driver, Scrollclick, TimeSpan.FromSeconds(200));
            string filepath = @"C:\Users\IqraArfeen\source\repos\qa_FEAST_DEMO\QA_FEAST_DEMO\scrolling.json";
            ScrollModel SC = Driver.ReadJsonFile<ScrollModel>(filepath);
            
            sendkey(driver, Names,SC.Name, TimeSpan.FromSeconds(200));
            sendkey(driver, Passwords, SC.Password, TimeSpan.FromSeconds(200));






            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            IWebElement element = driver.FindElement(By.Id("submitbtn"));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            clicks(driver, submitbutton, TimeSpan.FromSeconds(200));

            //IWebElement scrollableElement = driver.FindElement(By.XPath("//div[@id='rghtsideinnerbox_1']"));
            //js.ExecuteScript("arguments[0].scrollLeft = arguments[0].scrollWidth;", scrollableElement);


            IWebElement scrollArea = driver.FindElement(By.Id("scrollingwrap-box"));

            // Scroll to div's most right:
            js.ExecuteScript("arguments[0].scrollLeft = arguments[0].offsetWidth", scrollArea);
            
            // Or scroll the div by pixel number:
            js.ExecuteScript("arguments[0].scrollLeft += 250", scrollArea);
        }


    }
}
