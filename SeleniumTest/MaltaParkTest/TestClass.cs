using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using MaltaParkTest.BaseClass;

namespace MaltaParkTest
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test]
        public void TestNameField()
        {
            
            IWebElement nameField = chromeDriver.FindElement(By.CssSelector("#Name"));
            nameField.SendKeys("Albert Bach");
         
        }

        [Test]
        public void TestNameFieldEmpty()
        {

            IWebElement nameField = chromeDriver.FindElement(By.CssSelector("#Name"));
            nameField.SendKeys("");

        }

        [Test]
        public void TestNameFieldNumber()
        {

            IWebElement nameField = chromeDriver.FindElement(By.CssSelector("#Name"));
            nameField.SendKeys("01234");

        }

        [Test]
        public void TestNameFieldChars()
        {

            IWebElement nameField = chromeDriver.FindElement(By.CssSelector("#Name"));
            nameField.SendKeys("*/-+\'[");

        }
    }
}
