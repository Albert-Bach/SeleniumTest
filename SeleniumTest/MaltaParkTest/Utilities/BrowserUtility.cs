using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MaltaParkTest.Utilities
{
    public class BrowserUtility
    {
        public IWebDriver Init(IWebDriver chrome)
        {
            chrome = new ChromeDriver();
            chrome.Manage().Window.Maximize();
            chrome.Url = "https://www.maltapark.com/signup";
            return chrome;
        }
    }
}
