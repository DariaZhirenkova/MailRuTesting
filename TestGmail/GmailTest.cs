using GmailComTesting;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Chrome;

namespace TestGmail
{
    [TestClass]
    public class GmailTest
    {
        private static IWebDriver _driver;
       // private static WebDriverWait _agreeWait;
        MainPage page;
        UserPage userPage;
        User firstUser;
        User secondUser;

       [TestInitialize]
        public void Initialize()
        {
            _driver = new ChromeDriver();
            page = new MainPage(_driver);
            userPage = new UserPage(_driver);
            firstUser = new ("zhirenkovad", "Meshokgovna19", "//*[text()='@inbox.ru']");
            secondUser = new("daria12345678", "qwerty30062003", "//*[text()='@internet.ru']");

        }

        [TestMethod]
        public void MailRuTest()
        { 
            page.Login(firstUser);
            userPage.SendMessage();
            userPage.Exit();
            

            page.Login(secondUser);
            userPage.ClickMenuPoint("(//span[contains(@title,'Даша Жиренкова')])[1]/ancestor::div[3]");
            Thread.Sleep(2000);
            var test1 = _driver.FindElement(By.XPath("//*[@class='letter__body']")).Text;

            Assert.IsTrue(test1.Contains(firstUser.login) && test1.Contains("hi"));
            userPage.ClickMenuPoint("(//div[@class='button2__txt' and text()='Ответить'])[1]");
            userPage.WriteMessage("//*[@role = 'textbox']/div[1]", "//*[@tabindex='570']", "fine and you?");
            userPage.Exit();

            page.Login(firstUser);
            Thread.Sleep(5000);
            userPage.ClickMenuPoint("(//span[contains(@title,'Даша Иванова')])[1]/ancestor::div[3]");
            Thread.Sleep(2000);
            var text = _driver.FindElement(By.XPath("//div[@class='letter-body__body']")).Text;

            Assert.IsTrue(text.Contains(secondUser.login) && text.Contains("fine"));


        }
        public static void Cleanup()
        {
            // Закрытие и освобождение ресурсов веб-драйвера здесь
            _driver.Quit();
        }
    }
}