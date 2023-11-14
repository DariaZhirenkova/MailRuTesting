using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Interactions;

namespace GmailComTesting
{
    public abstract class BasePage
    {
        IWebDriver _driver;
        WebDriverWait _wait;



        public BasePage(IWebDriver _wdriver)
        {
            _driver = _wdriver;
          
            _driver.Manage().Window.Maximize();
            _wait = new WebDriverWait(_wdriver, TimeSpan.FromSeconds(10));
        }
      

        public IWebElement GetElementByXPath(string xpath)
        {
            return _wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
        }
        public void MoveToEl(string xPath)
        {
            new Actions(_driver).MoveToElement(GetElementByXPath(xPath));
        }
        public void ClickMenuPoint(string xPath)
        {
            GetElementByXPath(xPath).Click();
        }

        public void SendInfo(string xPath,string info)
        {
            var el = GetElementByXPath(xPath);
            Thread.Sleep(1000);
            el.SendKeys(info);
        }

        public void SwitchToFrame(string xpath)
        {
            IWebElement iframe = _wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
            _driver.SwitchTo().Frame(iframe);
            Thread.Sleep(1000);
        }

        public void EndOfFrame()
        {
            _driver.SwitchTo().DefaultContent();
        }


        public bool IsElementVisible(User user)
        {
           return GetElementByXPath($"(//span[contains(@title,'{user.name}')])[1]/ancestor::div[3]").Displayed;           
        }
      
    }
}
