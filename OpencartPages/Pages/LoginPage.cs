using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpencartPages.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        [FindsBy(How = How.CssSelector, Using = "")]
        private IWebElement txtUserName { get; set; }


        [FindsBy(How = How.CssSelector, Using = "")]
        private IWebElement txtPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "")]
        private IWebElement btnLogin { get; set; }

        public void Login()
        {
            txtUserName.SendKeys(" nume user plm");
            txtPassword.SendKeys(" parola plm");
            btnLogin.Click();
        }

        public void Login(string username, string password)
        {
            txtUserName.SendKeys(username);
            txtPassword.SendKeys(password);
            btnLogin.Click();
        }
    }
}
