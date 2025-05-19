using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FEAST_DEMO
{
    public class Button : Driver
    {
        By Buttonclick = By.XPath("//body/section[@id='block-one']/div[@class='container']/div[1]/div[1]/div[1]/ul[1]/li[2]");
        By Submit = By.XPath("//button[@id='button-1']");
        By Order = By.XPath("//button[@id='button-2']");

        public void Buttons()
        {

            clicks(driver, Buttonclick, TimeSpan.FromSeconds(200));
            clicks(driver, Submit, TimeSpan.FromSeconds(200));
            clicks(driver, Order, TimeSpan.FromSeconds(200));
        }

    }
}
