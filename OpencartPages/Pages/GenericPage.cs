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

        [FindsBy(How = How.XPath, Using = "//*[@id=\"cart\"]/ul/li/p")]
        public IWebElement txtEmptyCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"cart\"]/ul/li[1]/table/tbody/tr/td[5]/button/i")]
        public IWebElement BtnRemoveFromCart { get; set; }


        //NAVBAR
        //Desktops Dropdown Elements
        [FindsBy(How = How.LinkText, Using = "Desktops")]
        public IWebElement linkDesktops { get; set; }

        [FindsBy(How = How.LinkText, Using = "PC (0)")]
        public IWebElement pcProductsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/p")]
        public IWebElement txtNoProductsToList { get; set; }


        //Laptops & Notebooks Dropdown Elements
        [FindsBy(How = How.LinkText, Using = "Laptops & Notebooks")]
        public IWebElement linkLaptopsAndNotebooks { get; set; }

        [FindsBy(How = How.LinkText, Using = "Windows (0)")]
        public IWebElement windowsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/p")]
        public IWebElement txtNoProductsToListLN { get; set; }


        //Components Dropdown Elements
        [FindsBy(How = How.LinkText, Using = "Components")]
        public IWebElement linkComponents { get; set; }

        [FindsBy(How = How.LinkText, Using = "Monitors (2)")]
        public IWebElement linkMonitors { get; set; }

        [FindsBy(How = How.LinkText, Using = "Samsung SyncMaster 941BW")]
        public IWebElement txtMonitorsSamsungTitle { get; set; }

        [FindsBy(How = How.LinkText, Using = "Apple Cinema 30\"")]
        public IWebElement txtMonitorsAppleTitle { get; set; } 


        //Tablets Page Elements
        [FindsBy(How = How.LinkText, Using = "Tablets")]
        public IWebElement linkTablets { get; set; }

        [FindsBy(How = How.LinkText, Using = "Samsung Galaxy Tab 10.1")]
        public IWebElement txtTabletsProdTitle { get; set; }


        //Software Page Elements
        [FindsBy(How = How.LinkText, Using = "Software")]
        public IWebElement linkSoftware { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/p")]
        public IWebElement txtNoProductsToListSof { get; set; }


        //Phones and PDAs Page Elements
        [FindsBy(How = How.LinkText, Using = "Phones & PDAs")]
        public IWebElement linkPhonesPDAsPage { get; set; }

        [FindsBy(How = How.LinkText, Using = "Palm Treo Pro")]
        public IWebElement txtPhonesPDAsProdTitle { get; set; }


        //Cameras Page Elements
        [FindsBy(How = How.LinkText, Using = "Cameras")]
        public IWebElement linkCameras { get; set; }

        [FindsBy(How = How.LinkText, Using = "Nikon D300")]
        public IWebElement txtCamerasProdTitle { get; set; }


        //MP3 Dropdown Elements
        [FindsBy(How = How.LinkText, Using = "MP3 Players")]
        public IWebElement linkMP3Players { get; set; }

        [FindsBy(How = How.LinkText, Using = "test 4 (0)")]
        public IWebElement linkTest4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/p")]
        public IWebElement txtNoProductsToListMp3 { get; set; }


        //Add to Cart Button
        [FindsBy(How = How.Id, Using = "button-cart")]
        public IWebElement addToCartBtn { get; set; }


        //Remove from Cart Method
        public void RemoveFromCart()
        {
            BtnRemoveFromCart.Click();
        }

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

        public void ClickOnYourCart()  
        {
            btnCart.Click();
        }



        //Desktops Dropdown Methods
        public void ClickOnDesktops()
        {
            linkDesktops.Click();
        }

        public void ClickOnPC()
        {
            pcProductsLink.Click();
        }


        //Laptops & Notebooks Dropdown Methods 
        public void ClickOnLaptopsAndNotebooks()
        {
            linkLaptopsAndNotebooks.Click();
        }

        public void ClickOnWindows()
        {
            windowsLink.Click();
        }


        //Components Dropdown Methods 
        public void ClickOnComponents()
        {
            linkComponents.Click();
        }

        public void ClickOnMonitors()
        {
            linkMonitors.Click();
        }


        //Tablets Page Methods 
        public void ClickOnTablets()
        {
            linkTablets.Click();
        }


        //Software Page Methods 
        public void ClickOnSoftwarePage()
        {
            linkSoftware.Click();
        }


        //PhonesPDAs Page Methods 
        public void ClickOnPhonesPDAsPage()
        {
            linkPhonesPDAsPage.Click();
        }


        //Cameras Page Methods 
        public void ClickOnCamerasPage()
        {
            linkCameras.Click();
        }


        //MP3 Dropdown Methods 
        public void ClickOnMP3Players()
        {
            linkMP3Players.Click();
        }

        public void ClickOnTest4()
        {
            linkTest4.Click();
        }


        //Click Add to Cart
        public void ClickAddToCart()
        {
            addToCartBtn.Click();
        }
    }
}
