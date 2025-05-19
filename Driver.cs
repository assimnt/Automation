using Newtonsoft.Json;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium.Firefox;

namespace QA_FEAST_DEMO
{
    public class Driver
    {
        public static IWebDriver driver;
       

        public void drivers()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());

            IWebDriver firefoxDriver = new FirefoxDriver();
            driver = firefoxDriver;

            //string downloadDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "SeleniumFirefoxDownloads");
            //Directory.CreateDirectory(downloadDirectory);

            //var profile = new FirefoxProfile();

            //// Set preferences to avoid download prompts
            //profile.SetPreference("browser.download.folderList", 2); // 0=desktop, 1=default, 2=custom
            //profile.SetPreference("browser.download.dir", downloadDirectory);
            //profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/pdf,text/csv,application/vnd.ms-excel");
            //profile.SetPreference("pdfjs.disabled", true); // Disable built-in PDF viewer

            //var options = new FirefoxOptions
            //{
            //    Profile = profile
            //};
            


            driver.Url = "https://www.qafeast.com/demo";
        }



        public static void wait(IWebDriver driver, By locator, TimeSpan timeout)
        {

            WebDriverWait wait = new WebDriverWait(driver, timeout);
            IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }




        public static void clicks(IWebDriver driver, By locator, TimeSpan timeout)
        {

            // WebDriverWait wait = new WebDriverWait(driver, timeout);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => drv.FindElements(By.CssSelector("div.ad-container")).Count == 0);
            IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            driver.FindElement(locator).Click();


        }


        public static void sendkey(IWebDriver driver, By locator, string testdata, TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, timeout);


            IWebElement element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));

            element.SendKeys(testdata);


        }

        public static void SelectFromDropdown(IWebDriver driver, By dropdownLocator, string optionText, TimeSpan timeout)
        {

            WebDriverWait wait = new WebDriverWait(driver, timeout);


            IWebElement dropdownElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(dropdownLocator));


            SelectElement select = new SelectElement(dropdownElement);


            select.SelectByText(optionText);

        }

        public static T ReadJsonFile<T>(string filePath)
        {
            try
            {
                string jsonData = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<T>(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading JSON file: " + ex.Message);
                return default(T);
            }
        }


    }


}

