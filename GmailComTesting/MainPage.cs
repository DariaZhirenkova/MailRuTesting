using OpenQA.Selenium;

namespace MailRuTesting
{
    public class MainPage:BasePage
    {
        const string SIGN_UP_BUTTON = "//*[@id='mailbox']/div[1]/button";
        const string LOGIN_INPUT_BOX = "//div[contains(@class,'base-0-2-57')]/div/div/input";
        const string LOGIN_BUTTON_NEXT = "//div[contains(@class,'submit-button-wrap')]/button";

        const string FRAME_LOGIN_NAME = "//*[contains(@class,'ag-popup__frame__layout__iframe')]"; //ag-popup__frame__layout__iframe
        const string SELECT_LIST = "//*[contains(@class,'Select__control')]";
       
        const string PASSWORD_INPUT_BOX = "//input[contains(@class,'input-0-2-71 withIcon-0-2-72')]";
        const string PASSWORD_BUTTON_NEXT ="//div[contains(@class,'submit-button-wrap')]/div/button";

        const string HOME_PAGE_URL = "https://mail.ru/";

        public MainPage(IWebDriver driver) : base(driver)
        {
            driver.Url = HOME_PAGE_URL;
        }

        public void AutorizedLoginAndPassword(string name, string inputXPath, string buttonXPath)
        {
            SendInfo(inputXPath, name);
            ClickMenuPoint(buttonXPath);
        }

        public void Login(User user) 
        {
            ClickMenuPoint(SIGN_UP_BUTTON);
            SwitchToFrame(FRAME_LOGIN_NAME);
            ClickMenuPoint(SELECT_LIST);

            ClickMenuPoint(user.endOfEmail);
            AutorizedLoginAndPassword(user.login, LOGIN_INPUT_BOX, LOGIN_BUTTON_NEXT);
            AutorizedLoginAndPassword(user.password, PASSWORD_INPUT_BOX, PASSWORD_BUTTON_NEXT);
         
            EndOfFrame();
          
        }

    }
}
