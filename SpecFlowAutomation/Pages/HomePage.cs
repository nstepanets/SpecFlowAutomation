using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SpecFlowAutomation.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowAutomation.Pages
{
    public class HomePage : BasePage
    {
        private string URL => "https://specflow.org/";
        private string MainMenuItemXpath => "//div[@id='top-menu']/ul/li";

        private string SubMenuItemXpath => "//div[@id='top-menu']//a";

        private static HomePage homePage;
        public static HomePage Instance => homePage ?? (homePage = new HomePage());

        public void OpenSpecFlowHomePage()
        {
            DriverManager.Instance().Navigate().GoToUrl(URL);
        }

        public void HoverMainMenuItem(string item)
        {
            var actions = new Actions(DriverManager.Instance());
            var menuItem = FindElements(By.XPath(MainMenuItemXpath)).Single(x => x.Text.Equals(item));

            actions.MoveToElement(menuItem).Perform();
        }

        public void ClickSubMenuItem(string item)
        {
            var subMenuItem = FindElements(By.XPath(SubMenuItemXpath)).Single(x => x.Text.Equals(item));
            subMenuItem.Click();
        }
    }
}
