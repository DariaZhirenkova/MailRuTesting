using OpenQA.Selenium;

namespace MailRuTesting
{
    public class UserPage : BasePage
    {

        const string BUTTON_WRITE_MESSAGE = "//*[@data-title-shortcut='N']";
        const string INPUT_FORWHOM_SEND_MESSAGE = "//*[@class = 'container--ItIg4 size_s--2eBQT size_s--3_M-_']/div/input";
        const string INPUT_MESSAGE = "//*[@role = 'textbox']";
        const string BUTTON_SEND_MESSAGE = "//*[@tabindex='570']";
        const string SUBJECT_INPUT_NAME = "//*[@name='Subject']";

        const string BUTTON_REPLY = "(//div[@class='button2__txt' and text()='Ответить'])[1]";
        const string CHECK_MESSAGE = "//*[@class='letter__body']";
        const string CLOSE_MESSAGE_WINDOW = "//*[@title='Закрыть']";
        const string ICON_TO_EXIT = "//*[@class='ph-auth svelte-1osmzf1']";
        const string BUTTON_EXIT = "//*[@data-testid='whiteline-account-exit']";

        public UserPage(IWebDriver _wdriver) : base(_wdriver)
        {
        }

        public void ChooseRecipient(string xPath, string inputBox, string info)
        {
            ClickMenuPoint(xPath);
            SendInfo(inputBox, info);
        }
        
             
        public void ChooseSubject(string xPath, string info)
        {
            SendInfo(xPath, info);
        }

        public void WriteMessage(string xPathInput, string xPathButton, string info)
        {
            SendInfo(xPathInput, info);
            ClickMenuPoint(xPathButton);
        }

        public void SendMessage(string subjectName,string message,User user)
        {
            ChooseRecipient(BUTTON_WRITE_MESSAGE, INPUT_FORWHOM_SEND_MESSAGE,user.fullEmail);
            ChooseSubject(SUBJECT_INPUT_NAME, subjectName);
            WriteMessage(INPUT_MESSAGE, BUTTON_SEND_MESSAGE, message);
        }

        public void ReplyMessage(string info)
        {
            ClickMenuPoint(BUTTON_REPLY);
            WriteMessage(INPUT_MESSAGE, BUTTON_SEND_MESSAGE, info);
        }

        public void Exit()
        {
            Thread.Sleep(1000);
            ClickMenuPoint(CLOSE_MESSAGE_WINDOW);
            ClickMenuPoint(ICON_TO_EXIT);
            ClickMenuPoint(BUTTON_EXIT);
        }

        public string Check(User user)
        {
            ClickMenuPoint($"(//span[contains(@title,'{user.name}')])[1]/ancestor::div[3]");//???
            var test1 = GetElementByXPath(CHECK_MESSAGE).Text;
            return test1;
        }

    }
}
