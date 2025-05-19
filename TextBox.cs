using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FEAST_DEMO
{
    public class TextBox: Driver
    {

        By elementclick = By.XPath("//li[@class='active']");
        By EditableTextboxs = By.XPath("(//input[@id='editabletext'])[1]");
        By Textboxwithsometexts = By.XPath("//body/section[@id='block-one']/div[@class='container']/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]");



        public void TB()
        {
            string filepath = @"C:\Users\IqraArfeen\source\repos\qa_FEAST_DEMO\QA_FEAST_DEMO\textbox.json";
            TextBoxModel RB = Driver.ReadJsonFile<TextBoxModel>(filepath);            
            clicks(driver, elementclick, TimeSpan.FromSeconds(200));
            sendkey(driver, EditableTextboxs,RB.EditableTextbox, TimeSpan.FromSeconds(200));

            //sendkey(driver, Textboxwithsometexts, RB.Textboxwithsometext,TimeSpan.FromSeconds(200));
            IWebElement textboxWithText = driver.FindElement(Textboxwithsometexts);
            //textboxWithText.Click();
            textboxWithText.SendKeys(Keys.Control + "a");
            textboxWithText.SendKeys(Keys.Delete);
            sendkey(driver, Textboxwithsometexts, RB.Textboxwithsometext, TimeSpan.FromSeconds(200));


        }
    }
}
