﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaltaParkTest.BaseClass
{
    public class BaseTest
    {
        public IWebDriver chromeDriver;

        [OneTimeSetUp]
        public void Open()
        {
            chromeDriver = new ChromeDriver();
            chromeDriver.Manage().Window.Maximize();
            chromeDriver.Url = "https://www.maltapark.com/signup";
        }

        [OneTimeTearDown]
        public void Close()
        {
            chromeDriver.Quit();
        }
    }
}
