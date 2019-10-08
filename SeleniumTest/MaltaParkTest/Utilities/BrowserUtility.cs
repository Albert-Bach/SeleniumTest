using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MaltaParkTest.Utilities
{
    public class BrowserUtility
    {
        public IWebDriver Init(IWebDriver driver)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.maltapark.com/signup";
            return driver;
        }
    }
}
