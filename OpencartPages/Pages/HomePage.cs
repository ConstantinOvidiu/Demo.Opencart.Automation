using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpencartPages.Pages
{
    public class HomePage
    {
        public HomePage(IWebDriver browser)                 //the HomePage class Constructor
        {
            PageFactory.InitElements(browser, this);
        }

        [FindsBy(How = How.Name, Using = "search")]
        private IWebElement searchInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-default.btn-lg")]
        private IWebElement btnSearch { get; set; }

        public void SearchForItem(string text)
        {
            searchInput.SendKeys(text);
            btnSearch.Click();
        }
    }
}
