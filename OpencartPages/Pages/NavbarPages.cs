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


        //Components Dropdown Elements

        [FindsBy(How = How.LinkText, Using = "Samsung SyncMaster 941BW")]
        public IWebElement txtMonitorsSamsungTitle { get; set; }


        //Tablets Page Elements

        [FindsBy(How = How.LinkText, Using = "Samsung Galaxy Tab 10.1")]
        public IWebElement txtTabletsProdTitle { get; set; }

        //Cameras Page Elements


        [FindsBy(How = How.LinkText, Using = "Nikon D300")]
        public IWebElement txtCamerasProdTitle { get; set; }

    }
}

