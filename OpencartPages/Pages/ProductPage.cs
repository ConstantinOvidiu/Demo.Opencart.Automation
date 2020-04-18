using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpencartPages.Pages
{
    public class ProductPage: GenericPage
    {
        public ProductPage(IWebDriver browser)  //ProductPage constructor
        {
            PageFactory.InitElements(browser, this);
        }


        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-default.btn-lg")]
        private IWebElement btnSearch { get; set; }

        //Product Thumb elements
        [FindsBy(How = How.ClassName, Using = "product-thumb")]
        public IWebElement productResult { get; set; }

        //Currency elements
        [FindsBy(How = How.Id, Using = "form-currency")]
        public IWebElement linkCurrency { get; set; }

        [FindsBy(How = How.Name, Using = "EUR")]
        public IWebElement linkEuro { get; set; }

        [FindsBy(How = How.Name, Using = "GBP")]
        public IWebElement linkPound { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".list-unstyled li h2")]
        public IWebElement txtPrice { get; set; }

        //Review Form elements
        [FindsBy(How = How.LinkText, Using = "Reviews (0)")]
        public IWebElement linkTabReview { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".form-group .col-sm-12 #input-name")]
        public IWebElement nameInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".form-group .col-sm-12 #input-review")]
        public IWebElement reviewInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[name=\"rating\"][value=\"5\"]")]
        public IWebElement ratingInput { get; set; }

        [FindsBy(How = How.Id, Using = "button-review")]
        public IWebElement btnReview { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-review .alert-success")]
        public IWebElement successAlert { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-review .alert-danger")]
        public IWebElement failAlert { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-review .alert-danger")]
        public IWebElement nameAlert { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#form-review .alert-danger")]
        public IWebElement charactersAlert { get; set; }



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

        public void PoundClick()
        {
            linkPound.Click();
        }

        //Review tab methods

        public void TabReviewClick()
        {
            linkTabReview.Click();
        }

        public void WriteName(string text)
        {
            nameInput.SendKeys(text);

        }

        public void WriteReview(string text)
        {
            reviewInput.SendKeys(text);
        }

        public void GiveRating()
        {
            ratingInput.Click();
        }

        public void clickReviewButton()
        {
            btnReview.Click();
        }
    }
}
