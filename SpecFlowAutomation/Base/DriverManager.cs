﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SpecFlowAutomation.Base
{
    public static class DriverManager
    {
        private static readonly ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static IWebDriver Instance()
        {
            if (driver.Value == null)
            {
                driver.Value = new ChromeDriver();
                driver.Value.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(30));
                driver.Value.Manage().Window.Maximize();
            }
            return driver.Value;
        }

        public static void QuitDriver()
        {
            Instance().Quit();
        }
    }
}
