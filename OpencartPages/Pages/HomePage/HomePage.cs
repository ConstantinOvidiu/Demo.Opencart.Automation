using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpencartPages.Pages.HomePage
{
    public class HomePage
    {
        [FindsBy(How = How.Id, Using = "")]

        public IWebElement searchInput { get; set; }

        public HomePage (IWebElement browser)                 //the HomePage class Constructor
        {
            PageFactory.InitElements(browser, this);  
        }
    }
}
