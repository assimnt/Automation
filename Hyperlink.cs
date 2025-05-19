using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FEAST_DEMO
{
    public class Hyperlink:Driver
    {
        By Hyperlinkclick = By.XPath("//label[normalize-space()='Hyperlink']");
        By Browser = By.XPath("//a[normalize-space()='Web browser automation']");
        By Desktops = By.XPath("//a[normalize-space()='Desktop automation']");



        public void Linkss()
        {

            clicks(driver, Hyperlinkclick, TimeSpan.FromSeconds(500));
            clicks(driver, Browser, TimeSpan.FromSeconds(200));
            clicks(driver, Desktops, TimeSpan.FromSeconds(200));
        }
    }
}
