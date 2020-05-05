using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OpencartPages.Pages
{
    public class HomePage: GenericPage
    {
        public HomePage(IWebDriver browser)                //the HomePage class Constructor
        {
            PageFactory.InitElements(browser, this);
        }

       
        //Elements
       
        [FindsBy(How = How.LinkText, Using = "MacBook")]
        public IWebElement linkMacBook { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content h3")]
        public IWebElement txtFeatured { get; set; }


        //Methods

        public void ClickOnlinkMacBook()
        {
            linkMacBook.Click();
        }  
    }
}
