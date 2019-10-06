using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using MaltaParkTest.BaseClass;
using MaltaParkTest.Utilities;

namespace MaltaParkTest
{
    [TestFixture]
    public class ParallelTesting
    {
        IWebDriver chrome;

        [Test, Category("UAT Testing"), Category("Module")]
        public void TestMethod1()
        {
            var Chrome = new BrowserUtility().Init(chrome);
            IWebElement nameField = chrome.FindElement(By.CssSelector("#Name"));
            nameField.SendKeys("Albert Bach");
            Chrome.Close();
         
        }



    }
}
