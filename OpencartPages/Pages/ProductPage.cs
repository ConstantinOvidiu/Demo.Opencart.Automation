using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpencartPages.Pages
{
    public class ProductPage
    {
        public ProductPage(IWebDriver browser)  //LoginPage constructor
        {
            PageFactory.InitElements(browser, this);
        }

        [FindsBy(How = How.Name, Using = "search")]
        private IWebElement searchInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-default.btn-lg")]
        private IWebElement btnSearch { get; set; }  

        [FindsBy(How = How.ClassName, Using = "product-thumb")]
        public IWebElement productResult { get; set; }

        [FindsBy(How = How.Id, Using = "form-currency")]
        public IWebElement linkCurrency { get; set; } 

        [FindsBy(How = How.Name, Using = "EUR")]
        public IWebElement linkEuro { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".list-unstyled li h2")]
        public IWebElement txtPriceInEuro { get; set; }


        public void SearchForItem(string text)
        {
            searchInput.SendKeys(text);
            btnSearch.Click();
        }

        public void productResultClick()
        {
            productResult.Click();
        }

        public void CurrencyClick()
        {
            linkCurrency.Click();
        }

        public void EuroClick()
        {
            linkEuro.Click();
        }
    }
}
