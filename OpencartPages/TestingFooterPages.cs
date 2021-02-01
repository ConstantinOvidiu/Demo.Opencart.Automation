using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpencartPages.Pages;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpencartPages
{
    [TestClass]
    public class TestinghomePage 
    {
        private ChromeDriver browser;

        [TestInitialize]  //MS Test tag initialize
        public void TestInit()
        {
            //Open browser instance
            browser = new ChromeDriver();

            //Open page
            browser.Navigate().GoToUrl("https://demo.opencart.com/");

            //Implicit wait
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


            //Login Page Initialize 
            LoginPage loginPage = new LoginPage(browser);
            loginPage.ClickOnMyAccount();
            loginPage.GoToLogin();
            loginPage.Login();

        }

        [TestCleanup]
        public void TestCleanup()
        {
            //Close driver and browser
            browser.Quit();
        }


        //Testing Footer
        //Information column

        [TestMethod]
        public void OpenAboutUs()
        {
            HomePage homePage = new HomePage(browser);
            homePage.ClickLinkAboutUs();

            var footerTitlePageNoContent = homePage.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "About Us");
        }

        [TestMethod]
        public void OpenDeliverYInformation()
        {
            HomePage homePage = new HomePage(browser);
            homePage.ClickDeliveryInformation();

            var footerTitlePageNoContent = homePage.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Delivery Information");
        }

        [TestMethod]
        public void OpenPrivacyPolicy()
        {
            HomePage homePage = new HomePage(browser);
            homePage.ClickPrivacyPolicy();

            var footerTitlePageNoContent = homePage.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Privacy Policy");
        }

        [TestMethod]
        public void OpenTermsConditions()
        {
            HomePage homePage = new HomePage(browser);
            homePage.ClickTermsConditions();

            var footerTitlePageNoContent = homePage.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Terms & Conditions");
        }



        //Site Map

        [TestMethod]
        public void CheckSiteMapPage()
        {
            HomePage homePage = new HomePage(browser);
            homePage.ClickLinkSiteMap();

            var footerTitlePageNoContent = homePage.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Site Map");
        }

        //Extras
        //Brands

        [TestMethod]
        public void CheckBrandsPage()
        {
            HomePage homePage = new HomePage(browser);
            homePage.ClickLinkBrandsPage();

            var footerTitlePageNoContent = homePage.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Find Your Favorite Brand");
        }

        //Gift Certificates

        


        //Affiliate 

        [TestMethod]
        public void CheckAffiliatePage()
        {
            HomePage homePage = new HomePage(browser);
            homePage.ClickLinkAffiliatePage();
      
            homePage.ClickLinkAffiliateInfo();

            var footerTitlePageNoContent = homePage.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Your Affiliate Information");
        }

        //Specials 

        [TestMethod]
        public void CheckSpecialsPage()
        {
            HomePage homePage = new HomePage(browser);
            homePage.ClickLinkSpecialsPage();

            var footerTitlePageNoContent = homePage.GenericTitleHead2.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Special Offers");
        }


        //My Account column
        //My Account

        [TestMethod]
        public void CheckMyAccountsPage()
        {
            HomePage homePage = new HomePage(browser);
            homePage.ClickMyAccountsPage();
           
            var footerTitlePageNoContent = homePage.GenericTitleHead2.Text;
            Assert.AreEqual(footerTitlePageNoContent, "My Account");
        }

        //Order History
        [TestMethod]
        public void CheckOrderHistoryPage()
        {
            HomePage homePage = new HomePage(browser);
            homePage.ClickOrderHistoryPage();
           
            var footerTitlePageNoContent = homePage.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Order History");
        }

        //Wish List
        [TestMethod]
        public void CheckOrderWishListPage()
        {
            HomePage homePage = new HomePage(browser); 
            homePage.ClickOrderWishListPage();
            

            var footerTitlePageNoContent = homePage.GenericTitleHead2.Text;
            Assert.AreEqual(footerTitlePageNoContent, "My Wish List");
        }

        //Newsletter 
        [TestMethod]
        public void CheckNewsletterPage()
        {
            HomePage homePage = new HomePage(browser);
            homePage.ClickNewsletterPage();    
            homePage.NewsletterSubscribeNo(); 

            var successMsgNewsletter = homePage.SuccessMsgNewsletter.Text;
            Assert.AreEqual(successMsgNewsletter, "Success: Your newsletter subscription has been successfully updated!");
        }
    }
}
