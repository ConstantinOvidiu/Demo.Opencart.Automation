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
        //------------------ELEMENTS----------------------

        
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

       

        //Tablets Page Elements
        [FindsBy(How = How.LinkText, Using = "Tablets")]
        public IWebElement linkTablets { get; set; }


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


        //MP3 Dropdown Elements
        [FindsBy(How = How.LinkText, Using = "MP3 Players")]
        public IWebElement linkMP3Players { get; set; }

        [FindsBy(How = How.LinkText, Using = "test 4 (0)")]
        public IWebElement linkTest4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/p")]
        public IWebElement txtNoProductsToListMp3 { get; set; }



        //Footer Elements


        //Success Message
        [FindsBy(How = How.CssSelector, Using = "#common-success .row #content p")]
        public IWebElement SuccesMsgGeneric { get; set; }

        //Alert Message
        [FindsBy(How = How.ClassName, Using = "text-danger")]
        public IWebElement AlertMsgForms { get; set; }


        //Information column 


       //split the Element for affiliate page
        [FindsBy(How = How.CssSelector, Using = "#content h1")]
        public IWebElement FooterTitlePageNoContent { get; set; } 

        [FindsBy(How = How.LinkText, Using = "About Us")]
        public IWebElement LinkAboutUs { get; set; }

        [FindsBy(How = How.LinkText, Using = "Delivery Information")]
        public IWebElement LinkDeliveryInformation { get; set; }

        [FindsBy(How = How.LinkText, Using = "Privacy Policy")]
        public IWebElement LinkPrivacyPolicy { get; set; }

        [FindsBy(How = How.LinkText, Using = "Terms & Conditions")]
        public IWebElement LinkTermsConditions { get; set; }



        //Customer Service column
        //Contact Us


        [FindsBy(How = How.LinkText, Using = "Contact Us")]
        public IWebElement LinkContactUs { get; set; }

        
        //Returns page
        [FindsBy(How = How.LinkText, Using = "Returns")]
        public IWebElement LinkReturns { get; set; }

       

        //Site Map

        [FindsBy(How = How.LinkText, Using = "Site Map")]
        public IWebElement LinkSiteMap { get; set; }


        //Extras column
        //Brands

        [FindsBy(How = How.LinkText, Using = "Brands")]
        public IWebElement LinkBrands { get; set; }

        //Gift Certificates

        [FindsBy(How = How.LinkText, Using = "Gift Certificates")]
        public IWebElement LinkGiftCertificates { get; set; }


        //Affiliate

        [FindsBy(How = How.LinkText, Using = "Affiliate")]
        public IWebElement LinkAffiliate { get; set; }

        [FindsBy(How = How.LinkText, Using = "Edit your affiliate information")]
        public IWebElement LinkAffiliateInfo { get; set; }





        //Specials

        [FindsBy(How = How.LinkText, Using = "Specials")]
        public IWebElement LinkSpecials { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content h2")]
        public IWebElement GenericTitleHead2 { get; set; }


        //My Account column 
        //My Account

        [FindsBy(How = How.LinkText, Using = "My Account")]
        public IWebElement LinkMyAccount { get; set; }

        //Order History

        [FindsBy(How = How.LinkText, Using = "Order History")]
        public IWebElement LinkOrderHistory { get; set; }

        //Wish List 

        [FindsBy(How = How.LinkText, Using = "Wish List")]
        public IWebElement LinkWishList { get; set; }

        //Newsletter

        [FindsBy(How = How.LinkText, Using = "Newsletter")]
        public IWebElement LinkNewsletter { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[name=\"newsletter\"][value=\"0\"]")]
        public IWebElement NewsletterRadioNo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/form/div/div[2]/input")]
        public IWebElement BtnSubmitNewsletter { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account-account .alert-success")]
        public IWebElement SuccessMsgNewsletter { get; set; }





        //------------------METHODS----------------------


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



        //Footer Methods
        //Information column

        public void ClickLinkAboutUs()
        {
            LinkAboutUs.Click();
        }

        public void ClickDeliveryInformation()
        {
            LinkDeliveryInformation.Click();
        }

        public void ClickPrivacyPolicy()
        {
            LinkPrivacyPolicy.Click();
        }

        public void ClickTermsConditions() 
        {
            LinkTermsConditions.Click();
        }


        //Customer Service column 
        //Contact Us page

        public void ClickLinkContactUs()
        {
            LinkContactUs.Click();     
        }


        //Returns page

        public void ClickLinkReturns()  
        {
            LinkReturns.Click();         
        }

       
        //Site Map 

        public void ClickLinkSiteMap() 
        {
            LinkSiteMap.Click();
        }

        
        //Extras column
        //Brands

        public void ClickLinkBrandsPage()
        {
            LinkBrands.Click();
        }

        //Gift Certificates

        public void ClickLinkGiftCertificates()
        {
            LinkGiftCertificates.Click();
        }

        //Affiliate

        public void ClickLinkAffiliatePage()
        {
            LinkAffiliate.Click(); 
        }

        public void ClickLinkAffiliateInfo()
        {
            LinkAffiliateInfo.Click();
        }


        //Specials

        public void ClickLinkSpecialsPage()
        {
            LinkSpecials.Click(); 
        }


        //My Account column
        //My Account

        public void ClickMyAccountsPage() 
        {
            LinkMyAccount.Click(); 
        }

        //Order History

        public void ClickOrderHistoryPage()
        {
            LinkOrderHistory.Click();
        }

        //Wish List

        public void ClickOrderWishListPage()
        {
            LinkWishList.Click();
        }

        //Newsletter

        public void ClickNewsletterPage()
        {
            LinkNewsletter.Click();
        }

        public void NewsletterSubscribeNo()
        {
            NewsletterRadioNo.Click();
            BtnSubmitNewsletter.Click();
        }
    }
}

