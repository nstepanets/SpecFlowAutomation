using NUnit.Framework;
using SpecFlowAutomation.Base;
using SpecFlowAutomation.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowAutomation.Steps
{
    [Binding]
    public sealed class MainMenuSteps
    {
        private readonly ScenarioContext context;
        public MainMenuSteps(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"I open official SpecFlow website")]
        public void OpenOfficialSpecFlowWebsite()
        {
            HomePage.Instance.OpenSpecFlowHomePage();
        }

        [When(@"I hover the '([^']*)' menu item from the main menu")]
        public void HoverTheMenuItemFromTheMainMenu(string menuItem)
        {
            HomePage.Instance.HoverMainMenuItem(menuItem);
        }

        [When(@"I click '([^']*)' option from the main menu")]
        public void ClickOptionFromTheMainMenu(string option)
        {
            HomePage.Instance.ClickSubMenuItem(option);
        }

        [Then(@"Page with '([^']*)' title should be opened")]
        public void PageWithTitleShouldBeOpened(string title)
        {
            Assert.IsTrue(GettingStartedPage.Instance.IsPageTitleDisplayed(), "Page title for the page is not displayed");
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            DriverManager.QuitDriver();
        }
    }
}
