using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FEAST_DEMO
{
    public class FileUpload:Driver
    {
        By FP = By.XPath("//label[normalize-space()='File Upload & Download event']");

        public void FILEFUNCTION()
        {
            clicks(driver, FP, TimeSpan.FromSeconds(500));
            //IWebElement fileInput = driver.FindElement(By.XPath("//input[@id='file-upload']")); // Use correct ID or selector

            //// Full path to the file on your local machine
            //string filePath = @"C:\Users\IqraArfeen\Desktop\Afer SOD run myry pass 5 lack out right ty jisamy say myny 1 lack outright k sath future m deal ki outright sale ki to ips buy hi sod chlany k bad outright 4 lack hogya and ips 1 lack hogya.docx";

            //// Upload the file by sending the path
            //fileInput.SendKeys(filePath);

            // Optional: click the upload button
            //IWebElement uploadButton = driver.FindElement(By.XPath("//input[@id='file-submit']"));
            //uploadButton.Click();

            var downloadLink = driver.FindElement(By.XPath("//a[normalize-space()='Regression.csv']"));
            downloadLink.Click();



            var downloadLink1 = driver.FindElement(By.XPath("//a[normalize-space()='Lorem Ipsum.pdf']"));
            downloadLink1.Click();



        }
    }
}
