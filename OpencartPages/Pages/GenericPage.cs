using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpencartPages.Pages
{
    public class GenericPage

    {
        //Search box Elements
        [FindsBy(How = How.Name, Using = "search")]
        private IWebElement searchInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-default.btn-lg")]
        private IWebElement btnSearch { get; set; }


        //My Account Dropdown Elements
        [FindsBy(How = How.CssSelector, Using = "i.fa.fa-user")]
        public IWebElement btnMyAccount { get; set; }

        [FindsBy(How = How.LinkText, Using = "My Account")]
        public IWebElement linkMyAccount { get; set; }

        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement btnLogin { get; set; }


        // Logo, Cart button
        [FindsBy(How = How.Id, Using = "logo")]
        public IWebElement linkLogo { get; set; }

        [FindsBy(How = How.Id, Using = "cart")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cart ul li .text-center")]
        public IWebElement txtEmptyCart { get; set; } 


        //Search box Methods
        public void SearchForItem(string text)
        {
            searchInput.SendKeys(text);
            btnSearch.Click();
        }

        //MyAccount Methods
        public void ClickOnMyAccount()
        {
            btnMyAccount.Click();
        }

        public void GoToLogin()
        {
            btnLogin.Click();
        }

        //Click on logo and cart button Methods
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
