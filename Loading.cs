using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FEAST_DEMO
{
    public class Loading : Driver
    {

        By Loadings = By.XPath("//label[normalize-space()='Loading']");
        By PBL = By.XPath("//button[@onclick='move()']");
        By Loader = By.XPath("//button[contains(@onclick,'myloaderFunction()')]");



        public void Load()
        {
            clicks(driver, Loadings, TimeSpan.FromSeconds(500));
            clicks(driver, PBL, TimeSpan.FromSeconds(500));
            clicks(driver, Loader, TimeSpan.FromSeconds(500));


        }
    }
}
