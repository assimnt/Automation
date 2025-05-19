using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_FEAST_DEMO
{
    public class ChatWindow: Driver
    {
        By ChatWindowlick = By.XPath("//label[normalize-space()='Chat Window']");
        By userlogin = By.XPath("//div[@class='chat-userlogin-wrap']//input[@id='username']");
        By pwd = By.XPath("//div[@class='chat-userlogin-wrap']//input[@id='pwd']");
        By SignIn = By.XPath("//button[normalize-space()='Sign In']");
        By Chat = By.XPath("//button[@id='openchatform']");
        By Messages = By.XPath("//textarea[@placeholder='Type message..']");
        By Send = By.XPath("//button[normalize-space()='Send']");
        By Close = By.XPath("//button[@id='closechatform']");


        public void CWINDOW()
        {
            clicks(driver, ChatWindowlick, TimeSpan.FromSeconds(200));



            string filepath = @"C:\Users\IqraArfeen\source\repos\qa_FEAST_DEMO\QA_FEAST_DEMO\ChatWindowModel.json";
            ChatWindowModel cw = Driver.ReadJsonFile<ChatWindowModel>(filepath);
            
            sendkey(driver, userlogin, cw.userlogins, TimeSpan.FromSeconds(200));
            sendkey(driver, pwd, cw.pwds, TimeSpan.FromSeconds(200));
            clicks(driver, SignIn, TimeSpan.FromSeconds(200));
            clicks(driver, Chat, TimeSpan.FromSeconds(200));
            sendkey(driver, Messages, cw.Message, TimeSpan.FromSeconds(200));
           // clicks(driver, Send, TimeSpan.FromSeconds(700));
            clicks(driver, Close, TimeSpan.FromSeconds(1000));




        }
    }
}
