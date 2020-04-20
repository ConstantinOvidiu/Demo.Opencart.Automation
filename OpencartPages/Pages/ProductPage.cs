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


        //Add Product to Cart Completion Form Elements
        [FindsBy(How = How.CssSelector, Using = "input[name=\"option[218]\"][value=\"6\"]")]
        public IWebElement chooseDimensionInput { get; set; } 
                                                
        [FindsBy(How = How.CssSelector, Using = "input[name=\"option[223][]\"][value=\"9\"]")]
        public IWebElement chooseCheckBoxInput { get; set; } 

        [FindsBy(How = How.Id, Using = "input-option217")] 
        public IWebElement chooseColorInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-option217\"]/option[3]")]
        public IWebElement chooseBlueColor { get; set; }

        [FindsBy(How = How.Id, Using = "input-option209")]
        public IWebElement textareaInput { get; set; }

        [FindsBy(How = How.Id, Using = "button-upload222")] 
        public IWebElement btnUploadFile { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".alert.alert-success")]
        public IWebElement successAlertProdAdded { get; set; } 



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

        //Products click methods

        public void ClickOnSamsungMonitor() 
        {
            txtMonitorsSamsungTitle.Click();
        }

        public void ClickOnAppleMonitor() 
        {
            txtMonitorsAppleTitle.Click();
        }


        //Add Product to Cart Completion Form Methods

        public void ChooseDimensionClick()
        {
            chooseDimensionInput.Click();
        }

        public void ChooseCheckBoxClick()
        {
            chooseCheckBoxInput.Click();
        }

        public void ChooseColorClick()
        {
            chooseColorInput.Click();
        }

        public void ChooseBlueColorClick() 
        {
            chooseBlueColor.Click();
        }

        public void TextareaInputTyping()
        { 
            textareaInput.SendKeys("I want to by this product");
        }

        public void UploadImageFile()
        {
            btnUploadFile.SendKeys(@"C:\Users\ovidi\OneDrive\Desktop\IdentityCardCapture.bmp");
        }

        public void FillForm()
        {
            ChooseDimensionClick();
            ChooseCheckBoxClick();
            ChooseColorClick();
            ChooseBlueColorClick();
            TextareaInputTyping();
            UploadImageFile();
        }
    }
}
