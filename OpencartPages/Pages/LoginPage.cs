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
        public LoginPage(IWebDriver browser)  //LoginPage constructor
        {
            PageFactory.InitElements(browser, this);
        }

        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement txtEmail { get; set; }


        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement txtPassword { get; set; }


        [FindsBy(How = How.CssSelector, Using = "input.btn.btn-primary")]
        private IWebElement btnLogin { get; set; }

        [FindsBy(How = How.ClassName, Using = "alert")]
        public IWebElement txtErrorMessage { get; set; }

        public void Login()
        {
            txtEmail.SendKeys("ovidiu.chiruta@gmail.com");
            txtPassword.SendKeys("Parolanoua1234");
            btnLogin.Click();
        }

        public void Login(string username, string password)
        {
            txtEmail.SendKeys(username);
            txtPassword.SendKeys(password);
            btnLogin.Click();
        }
    }
}
