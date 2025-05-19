using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FEAST_DEMO
{
    public class Dropdown: Driver
    {
        By dropdownclick = By.XPath("//label[normalize-space()='Dropdown']");
        By CountrynameText = By.XPath("//select[@name='countryname']");
        By StatenameText = By.XPath("//select[@name='statename']");

        public void dropdowns() 
        {

            string filepath = @"C:\Users\IqraArfeen\source\repos\qa_FEAST_DEMO\QA_FEAST_DEMO\Dropdownfile.json";
            Dropdownmoel dB = Driver.ReadJsonFile<Dropdownmoel>(filepath);
            clicks(driver, dropdownclick, TimeSpan.FromSeconds(200));
            SelectFromDropdown(driver, CountrynameText, dB.Countryname, TimeSpan.FromSeconds(200));
        }


    }
}
