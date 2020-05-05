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
    public class TestingFooterPages
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
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ClickLinkAboutUs();

            var footerTitlePageNoContent = footerPages.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "About Us");
        }

        [TestMethod]
        public void OpenDeliverYInformation()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ClickDeliveryInformation();

            var footerTitlePageNoContent = footerPages.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Delivery Information");
        }

        [TestMethod]
        public void OpenPrivacyPolicy()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ClickPrivacyPolicy();

            var footerTitlePageNoContent = footerPages.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Privacy Policy");
        }

        [TestMethod]
        public void OpenTermsConditions()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ClickTermsConditions();

            var footerTitlePageNoContent = footerPages.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Terms & Conditions");
        }


        //Customer Service
        //Contact Us

        [TestMethod]
        public void CheckValidFormContactUs()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ContactUsSubmitValidForm();

            var footerTitlePageNoContent = footerPages.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Contact Us");
        }

        [TestMethod]
        public void CheckInvalidFormName()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ContactUsSubmitInvalidName();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Name must be between 3 and 32 characters!");
        }

        [TestMethod]
        public void CheckInvalidFormEmail()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ContactUsSubmitInvalidEmail();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "E-Mail Address does not appear to be valid!");
        }

        [TestMethod]
        public void CheckInvalidFormEnquiryText()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ContactUsSubmitInvalidEnquiryText();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Enquiry must be between 10 and 3000 characters!");
        }

        [TestMethod]
        public void CheckInvalidFormEnquiryEmpty()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ContactUsSubmitInvalidEnquiryEmpty();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Enquiry must be between 10 and 3000 characters!");
        }


        //Returns
        [TestMethod]
        public void CheckValidFormReturns()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ReturnsSubmitValidForm();

            var succesMsgGeneric = footerPages.SuccesMsgGeneric.Text.Contains("Thank you for submitting");
            Assert.IsTrue(succesMsgGeneric);
        }

        [TestMethod]
        public void CheckInvalidFormFirstName()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ReturnsInvalidFormFirstName();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "First Name must be between 1 and 32 characters!");
        }

        [TestMethod]
        public void CheckInvalidFormLastName()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ReturnsInvalidFormLasttName();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Last Name must be between 1 and 32 characters!");
        }

        [TestMethod]
        public void CheckInvalidReturnsFormEmail()
        {
            FooterSection footerPages = new FooterSection(browser); 
            footerPages.ReturnsInvalidFormEmail();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "E-Mail Address does not appear to be valid!");
        }

        [TestMethod]
        public void CheckInvalidReturnsFormTelephone()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ReturnsInvalidFormTelephone();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Telephone must be between 3 and 32 characters!");
        }

        [TestMethod]
        public void CheckInvalidReturnsFormOrderID()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ReturnsInvalidFormOrderID();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Order ID required!");
        }

        [TestMethod]
        public void CheckInvalidReturnsFormProductName()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ReturnsInvalidFormProductName();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Product Name must be greater than 3 and less than 255 characters!");
        }

        [TestMethod]
        public void CheckInvalidReturnsFormProductCode()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ReturnsInvalidFormProductCode();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Product Model must be greater than 3 and less than 64 characters!");
        }

        [TestMethod]
        public void CheckInvalidReturnsFormReasOfRet()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ReturnsInvalidFormReasOfRet();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "You must select a return product reason!");
        }

        [TestMethod]
        public void CheckOrderIdCheckValZero()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.OrderIdCheckValZero();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Order ID required!");
        }

        [TestMethod]
        public void CheckOrderIdCheckValZeroZero()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.OrderIdCheckValZeroZero();

            var succesMsgGeneric = footerPages.SuccesMsgGeneric.Text.Contains("Thank you for submitting");
            Assert.IsTrue(succesMsgGeneric);
        }

        //Site Map

        [TestMethod]
        public void CheckSiteMapPage()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ClickLinkSiteMap();

            var footerTitlePageNoContent = footerPages.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Site Map");
        }

        //Extras
        //Brands

        [TestMethod]
        public void CheckBrandsPage()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ClickLinkBrandsPage();

            var footerTitlePageNoContent = footerPages.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Find Your Favorite Brand");
        }

        //Gift Certificates

        [TestMethod]
        public void GiftCertPageValidForm()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.GiftCertSubmitValidForm();

            var succesMsgGeneric = footerPages.SuccesMsgGeneric.Text.Contains("Thank you for purchasing");
            Assert.IsTrue(succesMsgGeneric);
        }

        [TestMethod]
        public void CheckGiftCertInvalidFormRecipientsName()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.GiftCertInvalidFormRecipientsName();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Recipient's Name must be between 1 and 64 characters!");
        }

        [TestMethod]
        public void CheckGiftCertInvalidFormRecipientsEmail()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.GiftCertInvalidFormRecipientsEmail();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "E-Mail Address does not appear to be valid!");
        }

        [TestMethod]
        public void CheckGiftCertInvalidFormName()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.GiftCertInvalidFormName();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Your Name must be between 1 and 64 characters!");
        }

        [TestMethod]
        public void CheckGiftCertInvalidEmail()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.GiftCertInvalidEmail();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "E-Mail Address does not appear to be valid!");
        }

        [TestMethod]
        public void CheckGiftCertInvalidTheme()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.GiftCertInvalidTheme();

            var alertMsgForms = footerPages.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "You must select a theme!");
        }

        [TestMethod]
        public void CheckGiftCertInvalidAgrCheckBox()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.GiftCertInvalidAgrCheckBox();

            var alertMsgForms = footerPages.AlertAgreementCheckBox.Text;
            Assert.AreEqual(alertMsgForms, "Warning: You must agree that the gift certificates are non-refundable!");
        }


        //Affiliate 

        [TestMethod]
        public void CheckAffiliatePage()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ClickLinkAffiliatePage();

            var footerTitlePageNoContent = footerPages.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Affiliate Program");
        }

        //Specials 

        [TestMethod]
        public void CheckSpecialsPage()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ClickLinkSpecialsPage();

            var footerTitlePageNoContent = footerPages.GenericTitleHead2.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Special Offers");
        }


        //My Account column
        //My Account

        [TestMethod]
        public void CheckMyAccountsPage()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ClickMyAccountsPage();
            footerPages.Login();

            var footerTitlePageNoContent = footerPages.GenericTitleHead2.Text;
            Assert.AreEqual(footerTitlePageNoContent, "My Account");
        }

        //Order History
        [TestMethod]
        public void CheckOrderHistoryPage()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ClickOrderHistoryPage();
            footerPages.Login();

            var footerTitlePageNoContent = footerPages.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Order History");
        }

        //Wish List
        [TestMethod]
        public void CheckOrderWishListPage()
        {
            FooterSection footerPages = new FooterSection(browser); 
            footerPages.ClickOrderWishListPage();
            footerPages.Login();

            var footerTitlePageNoContent = footerPages.GenericTitleHead2.Text;
            Assert.AreEqual(footerTitlePageNoContent, "My Wish List");
        }

        //Newsletter 
        [TestMethod]
        public void CheckNewsletterPage()
        {
            FooterSection footerPages = new FooterSection(browser);
            footerPages.ClickNewsletterPage();
            footerPages.Login();
            footerPages.NewsletterSubscribeNo();

            var successMsgNewsletter = footerPages.SuccessMsgNewsletter.Text;
            Assert.AreEqual(successMsgNewsletter, "Success: Your newsletter subscription has been successfully updated!");
        }
    }
}
