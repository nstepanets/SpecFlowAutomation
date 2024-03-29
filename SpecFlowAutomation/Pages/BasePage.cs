﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SpecFlowAutomation.Base;
using System;
using System.Collections.Generic;

namespace SpecFlowAutomation.Pages
{
    public class BasePage
    {
        private string TitleXpath => "//h1[contains(text(), '{0}')]";
        public BasePage()
        {

        }

        public IWebElement FindElement(By locator)
        {
            return DriverManager.Instance().FindElement(locator);
        }

        public IReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            return DriverManager.Instance().FindElements(locator);
        }

        public bool IsDisplayed(By locator, int timeout = 30)
        {
            var wait = new WebDriverWait(DriverManager.Instance(), TimeSpan.FromSeconds(timeout));
            return wait.Until(d => DriverManager.Instance().FindElement(locator).Displayed);
        }

        public bool IsPageTitleDisplayed(string pageTitle)
        {
            return IsDisplayed(By.XPath(string.Format(TitleXpath, pageTitle)));
        }
    }
}
