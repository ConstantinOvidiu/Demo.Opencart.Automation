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
    public class TestingContactUsPage
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


        [TestMethod]
        public void CheckValidFormContactUs() 
        {
            ContactUsPage contactUs = new ContactUsPage(browser);
            contactUs.ClickLinkContactUs();
            contactUs.ContactUsSubmitValidForm();

            var footerTitlePageNoContent = contactUs.FooterTitlePageNoContent.Text;
            Assert.AreEqual(footerTitlePageNoContent, "Contact Us"); 
        }


        [TestMethod]
        public void CheckInvalidFormName()
        {
            ContactUsPage contactUs = new ContactUsPage(browser);
            contactUs.ClickLinkContactUs();
            contactUs.ContactUsSubmitInvalidName();

            var alertMsgForms = contactUs.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Name must be between 3 and 32 characters!"); 
        }


        [TestMethod]
        public void CheckInvalidFormEmail()
        {
            ContactUsPage contactUs = new ContactUsPage(browser);
            contactUs.ClickLinkContactUs();
            contactUs.ContactUsSubmitInvalidEmail();

            var alertMsgForms = contactUs.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "E-Mail Address does not appear to be valid!");
        }


        [TestMethod]
        public void CheckInvalidFormEnquiryText()
        {
            ContactUsPage contactUs = new ContactUsPage(browser);
            contactUs.ClickLinkContactUs();
            contactUs.ContactUsSubmitInvalidEnquiryText();

            var alertMsgForms = contactUs.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Enquiry must be between 10 and 3000 characters!");
        }


        [TestMethod]
        public void CheckInvalidFormEnquiryEmpty() 
        {
            ContactUsPage contactUs = new ContactUsPage(browser);
            contactUs.ClickLinkContactUs();
            contactUs.ContactUsSubmitInvalidEnquiryEmpty();

            var alertMsgForms = contactUs.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Enquiry must be between 10 and 3000 characters!");
        }
    }
}
