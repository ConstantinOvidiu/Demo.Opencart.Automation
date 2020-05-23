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
    public class TestingReturnsPage
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
        public void CheckValidFormReturns() 
        {
            ReturnsPage returnsPage = new ReturnsPage(browser);
            returnsPage.ClickLinkReturns();
            returnsPage.ReturnsValidForm();

            var succesMsgGeneric = returnsPage.SuccesMsgGeneric.Text.Contains("Thank you for submitting");
            Assert.IsTrue(succesMsgGeneric);
        }


        [TestMethod]
        public void CheckInvalidFormFirstName()
        {
            ReturnsPage returnsPage = new ReturnsPage(browser);
            returnsPage.ClickLinkReturns();
            returnsPage.ReturnsInvalidFormFirstName();

            var alertMsgForms = returnsPage.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "First Name must be between 1 and 32 characters!");
        }


        [TestMethod]
        public void CheckInvalidFormLastName()
        {
            ReturnsPage returnsPage = new ReturnsPage(browser);
            returnsPage.ClickLinkReturns();
            returnsPage.ReturnsInvalidFormLasttName();

            var alertMsgForms = returnsPage.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Last Name must be between 1 and 32 characters!");
        }


        [TestMethod]
        public void CheckInvalidReturnsFormEmail()
        {
            ReturnsPage returnsPage = new ReturnsPage(browser);
            returnsPage.ClickLinkReturns();
            returnsPage.ReturnsInvalidFormEmail();

            var alertMsgForms = returnsPage.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "E-Mail Address does not appear to be valid!");
        }


        [TestMethod]
        public void CheckInvalidReturnsFormTelephone()
        {
            ReturnsPage returnsPage = new ReturnsPage(browser);
            returnsPage.ClickLinkReturns();
            returnsPage.ReturnsInvalidFormTelephone();

            var alertMsgForms = returnsPage.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Telephone must be between 3 and 32 characters!");
        }


        [TestMethod]
        public void CheckInvalidReturnsFormOrderID()
        {
            ReturnsPage returnsPage = new ReturnsPage(browser);
            returnsPage.ClickLinkReturns();
            returnsPage.ReturnsInvalidFormOrderID();

            var alertMsgForms = returnsPage.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Order ID required!");
        }


        [TestMethod]
        public void CheckInvalidReturnsFormProductName()
        {
            ReturnsPage returnsPage = new ReturnsPage(browser);
            returnsPage.ClickLinkReturns();
            returnsPage.ReturnsInvalidFormProductName();

            var alertMsgForms = returnsPage.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Product Name must be greater than 3 and less than 255 characters!");
        }


        [TestMethod]
        public void CheckInvalidReturnsFormProductCode()
        {
            ReturnsPage returnsPage = new ReturnsPage(browser);
            returnsPage.ClickLinkReturns();
            returnsPage.ReturnsInvalidFormProductCode();

            var alertMsgForms = returnsPage.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Product Model must be greater than 3 and less than 64 characters!");
        }


        [TestMethod]
        public void CheckInvalidReturnsFormReasOfRet()
        {
            ReturnsPage returnsPage = new ReturnsPage(browser);
            returnsPage.ClickLinkReturns();
            returnsPage.ReturnsInvalidFormReasOfRet();

            var alertMsgForms = returnsPage.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "You must select a return product reason!");
        }


        [TestMethod]
        public void CheckOrderIdCheckValZero()
        {
            ReturnsPage returnsPage = new ReturnsPage(browser);
            returnsPage.ClickLinkReturns();
            returnsPage.OrderIdCheckValZero();

            var alertMsgForms = returnsPage.AlertMsgForms.Text;
            Assert.AreEqual(alertMsgForms, "Order ID required!");
        }


        [TestMethod]
        public void CheckOrderIdCheckValZeroZero()
        {
            ReturnsPage returnsPage = new ReturnsPage(browser);
            returnsPage.ClickLinkReturns();
            returnsPage.OrderIdCheckValZeroZero();

            var succesMsgGeneric = returnsPage.SuccesMsgGeneric.Text.Contains("Thank you for submitting");
            Assert.IsTrue(succesMsgGeneric);
        }

    }
}
