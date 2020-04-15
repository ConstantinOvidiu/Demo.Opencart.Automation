using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///TODO
namespace OpencartPages.Pages
{
    public class HomePage
    {
        public HomePage(IWebDriver browser)                //the HomePage class Constructor
        {
            PageFactory.InitElements(browser, this);
        }

        [FindsBy(How = How.CssSelector, Using = "i.fa.fa-user")]
        public IWebElement btnMyAccount { get; set; }

        [FindsBy(How = How.LinkText, Using = "My Account")]
        public IWebElement linkMyAccount { get; set; }

        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement btnLogin { get; set; }

        [FindsBy(How = How.Name, Using = "search")]
        private IWebElement searchInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-default.btn-lg")]
        private IWebElement btnSearch { get; set; }

        [FindsBy(How = How.LinkText, Using = "MacBook")]
        public IWebElement linkMacBook { get; set; }

        [FindsBy(How = How.Id, Using = "logo")]
        public IWebElement linkLogo { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content h3")]
        public IWebElement txtFeatured { get; set; }

        [FindsBy(How = How.Id, Using = "cart")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cart ul li .text-center")]
        public IWebElement txtEmptyCart { get; set; }

        public void ClickOnMyAccount()
        {
            btnMyAccount.Click();
        }

        public void GoToLogin()
        {
            btnLogin.Click();
        }

        public void SearchForItem(string text)
        {
            searchInput.SendKeys(text);
            btnSearch.Click();
        }

        public void ClickOnlinkMacBook()
        {
            linkMacBook.Click();
        }

        public void ClickOnLogo()
        {
            linkLogo.Click();
        }

        public void ClickOnEmptyCart()
        {
            btnCart.Click();
        }
    }
}
