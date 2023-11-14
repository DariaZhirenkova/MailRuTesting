using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.FedCm;
using OpenQA.Selenium.Edge;

namespace GmailComTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            IWebDriver driver = new ChromeDriver();
            MainPage page = new MainPage(driver);
            UserPage userPage = new UserPage(driver);
            User firstUser = new User("zhirenkovad", "Meshokgovna19", "//*[text()='@inbox.ru']");
            User secondUser = new User("daria12345678", "qwerty30062003", "//*[text()='@internet.ru']");
          
            page.Login(firstUser);
            userPage.FirstPersonSendMessage();
            userPage.Exit();
         

            page.Login(secondUser);
            userPage.ClickMenuPoint("(//span[contains(@title,'Даша Жиренкова')])[1]/ancestor::div[3]");
            Thread.Sleep(2000);
            var test1 = driver.FindElement(By.XPath("//*[@class='letter__body']")).Text;

            userPage.ClickMenuPoint("(//div[@class='button2__txt' and text()='Ответить'])[1]");
            userPage.WriteMessage("//*[@role = 'textbox']/div[1]", "//*[@tabindex='570']","fine and you?");
            userPage.Exit();
       
            page.Login(firstUser);
            Thread.Sleep(5000);
            userPage.ClickMenuPoint("(//span[contains(@title,'Даша Иванова')])[1]/ancestor::div[3]");
            Thread.Sleep(2000);
            var text = driver.FindElement(By.XPath("//div[@class='letter-body__body']")).Text;

            driver.Quit();*/
        }
    }
}