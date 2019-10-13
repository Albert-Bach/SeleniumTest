using NUnit.Framework;
using OpenQA.Selenium;
using MaltaParkTest.Utilities;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;

namespace MaltaParkTest
{
    [TestFixture]
    public class ParallelTesting
    {
        IWebDriver driver;

        [Test]
        public void TestNameFieldEmpty()
        {
            var chromeDriver = new BrowserUtility().Init(driver);
            IWebElement nameField = chromeDriver.FindElement(By.CssSelector("#Name"));
            nameField.SendKeys("");
            IWebElement emailField = chromeDriver.FindElement(By.CssSelector("#Email"));
            emailField.SendKeys("random@random.com");
            IWebElement userNameField = chromeDriver.FindElement(By.CssSelector("#Username"));
            userNameField.SendKeys("Random");
            IWebElement passwordField = chromeDriver.FindElement(By.CssSelector("#Password"));
            passwordField.SendKeys("Random");
            IWebElement telephoneField = chromeDriver.FindElement(By.CssSelector("#Telephone"));
            telephoneField.SendKeys("1111111");
            IWebElement element = chromeDriver.FindElement(By.CssSelector(".ui.fluid.large.primary.submit.button"));
            element.Click();
            var errorMessage = chromeDriver.FindElement(By.CssSelector(".list > li:nth-child(1)")).Text;
         

            Assert.AreEqual("The Name field is required.", errorMessage);

            chromeDriver.Close();

        }

    }
}
