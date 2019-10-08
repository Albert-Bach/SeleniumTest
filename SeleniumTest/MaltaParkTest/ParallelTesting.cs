using NUnit.Framework;
using OpenQA.Selenium;
using MaltaParkTest.Utilities;

namespace MaltaParkTest
{
    [TestFixture]
    public class ParallelTesting
    {
        IWebDriver driver;

        [Test,Category("UAT Testing"),Category("Module")]
        public void TestNameFieldWithProperName()
        {
            var chromeDriver = new BrowserUtility().Init(driver);
            IWebElement nameField = chromeDriver.FindElement(By.CssSelector("#Name"));
            nameField.SendKeys("Albert Bach");
            chromeDriver.Close();
         
        }

        [Test, Category("UAT Testing"), Category("Module")]
        public void TestNameFieldEmpty()
        {
            var chromeDriver = new BrowserUtility().Init(driver);
            IWebElement nameField = chromeDriver.FindElement(By.CssSelector("#Name"));
            nameField.SendKeys("");
            chromeDriver.Close();

        }

        [Test, Category("UAT Testing"), Category("Module")]
        public void TestNameFieldNumber()
        {
            var chromeDriver = new BrowserUtility().Init(driver);
            IWebElement nameField = chromeDriver.FindElement(By.CssSelector("#Name"));
            nameField.SendKeys("01234");
            chromeDriver.Close();
        }

        [Test, Category("UAT Testing"), Category("Module")]
        public void TestNameFieldChars()
        {
            var chromeDriver = new BrowserUtility().Init(driver);
            IWebElement nameField = chromeDriver.FindElement(By.CssSelector("#Name"));
            nameField.SendKeys("*/-+\'[");
            chromeDriver.Close();
        }
    }
}
