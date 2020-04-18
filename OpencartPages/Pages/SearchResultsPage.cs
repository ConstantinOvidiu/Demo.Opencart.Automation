using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace OpencartPages.Pages
{
    public class SearchResultsPage
    {
        public SearchResultsPage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".product-layout .caption a")]
        public IWebElement txtProductTitle { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".product-layout button:nth-child(1)")]
        private IWebElement btnAddToCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/p[2]")]
        public IWebElement txtNoItemsReturned { get; set; }

        public void AddToCart()
        {
            btnAddToCart.Click();
        }
    }
}
