using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpencartPages.Pages
{
    public class NavbarPages: GenericPage
    {
        public NavbarPages(IWebDriver browser)  //NavbarPages constructor
        {
            PageFactory.InitElements(browser, this);
        }

    }
}

