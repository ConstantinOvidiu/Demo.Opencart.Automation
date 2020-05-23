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
    public class TestingGiftCertificatesPage
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
        public void GiftCertPageValidForm()
        {
            GiftCertificatesPage giftCertPage = new GiftCertificatesPage(browser);
            giftCertPage.ClickLinkGiftCertificates();
            giftCertPage.GiftCertSubmitValidForm();

            var succesMsgGeneric = giftCertPage.SuccesMsgGeneric.Text.Contains("Thank you for purchasing"); 
            Assert.IsTrue(succesMsgGeneric);
        }

        [TestMethod]
        public void CheckGiftCertInvalidFormRecipientsName()
        {
            GiftCertificatesPage giftCertPage = new GiftCertificatesPage(browser);
            giftCertPage.ClickLinkGiftCertificates();
            giftCertPage.GiftCertInvalidFormRecipientsName();

            var alertMsgForms = giftCertPage.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Recipient's Name must be between 1 and 64 characters!");
        }

        [TestMethod]
        public void CheckGiftCertInvalidFormRecipientsEmail()
        {
            GiftCertificatesPage giftCertPage = new GiftCertificatesPage(browser);
            giftCertPage.ClickLinkGiftCertificates();
            giftCertPage.GiftCertInvalidFormRecipientsEmail();

            var alertMsgForms = giftCertPage.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "E-Mail Address does not appear to be valid!");
        }

        [TestMethod]
        public void CheckGiftCertInvalidFormName()
        {
            GiftCertificatesPage giftCertPage = new GiftCertificatesPage(browser);
            giftCertPage.ClickLinkGiftCertificates();
            giftCertPage.GiftCertInvalidFormName();

            var alertMsgForms = giftCertPage.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Your Name must be between 1 and 64 characters!");
        }

        [TestMethod]
        public void CheckGiftCertInvalidEmail()
        {
            GiftCertificatesPage giftCertPage = new GiftCertificatesPage(browser);
            giftCertPage.ClickLinkGiftCertificates();
            giftCertPage.GiftCertInvalidEmail();

            var alertMsgForms = giftCertPage.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "E-Mail Address does not appear to be valid!");
        }

        [TestMethod]
        public void CheckGiftCertInvalidTheme()
        {
            GiftCertificatesPage giftCertPage = new GiftCertificatesPage(browser);
            giftCertPage.ClickLinkGiftCertificates();
            giftCertPage.GiftCertInvalidTheme();

            var alertMsgForms = giftCertPage.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "You must select a theme!");
        }

        [TestMethod]
        public void CheckGiftCertInvalidAgrCheckBox()
        {
            GiftCertificatesPage giftCertPage = new GiftCertificatesPage(browser);
            giftCertPage.ClickLinkGiftCertificates();
            giftCertPage.GiftCertInvalidAgrCheckBox();

            var alertMsgForms = giftCertPage.AlertAgreementCheckBox.Text;
            Assert.AreEqual(alertMsgForms, "Warning: You must agree that the gift certificates are non-refundable!");
        }
    }
}
