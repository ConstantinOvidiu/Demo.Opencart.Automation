using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpencartPages.Pages
{
    public class LoginPage: GenericPage 
    {
        public LoginPage(IWebDriver browser)  //LoginPage constructor
        {
            PageFactory.InitElements(browser, this);
        }
        

    }
}
