using MailRuTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MailTest
{
    public class Tests
    {
        private static IWebDriver _driver;
        MainPage page;
        UserPage userPage;
        User firstUser;
        User secondUser;

        

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            page = new MainPage(_driver);
            userPage = new UserPage(_driver);
            firstUser = new("zhirenkovad@inbox.ru","zhirenkovad", "Meshokgovna19", "//*[text()='@inbox.ru']","Даша Жиренкова");
            secondUser = new("daria12345678@internet.ru", "daria12345678", "qwerty30062003", "//*[text()='@internet.ru']", "Даша Иванова");

        }

        [Test]
        public void MailRuTest()
        {
            page.Login(firstUser);
            userPage.SendMessage("first try","hi, Dasha",secondUser);
            userPage.Exit();

            page.Login(secondUser);

            while (userPage.IsElementVisible(firstUser) == false)
            {
                Thread.Sleep(2000);
                _driver.Navigate().Refresh();
                Thread.Sleep(5000);
            }


            var test1 = userPage.Check(firstUser);
            Assert.IsTrue(test1.Contains("hi"));
            userPage.ReplyMessage("fine, and u?");
            userPage.Exit();

            page.Login(firstUser);
            while (userPage.IsElementVisible(secondUser) == false)
            {
                Thread.Sleep(2000);
                _driver.Navigate().Refresh();
                Thread.Sleep(5000);
            }
            var text = userPage.Check(secondUser);
            Assert.IsTrue(text.Contains("fine"));
          
        }
        [TearDown]
        public static void Cleanup()
        {
            // Закрытие и освобождение ресурсов веб-драйвера здесь
            _driver.Quit();
        }

    }
}