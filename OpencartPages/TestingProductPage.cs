using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpencartPages.Pages;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpencartPages
{
    [TestClass]
    public class TestingProductPage
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
        public void VerifyCurrencyEuro()
        {

            ProductPage productPage = new ProductPage(browser);
            productPage.SearchForItem("iPhone");

            productPage.productResultClick();
            productPage.CurrencyClick();
            productPage.EuroClick();

            //Assert Price in Euro

            var isMyPriceInEuro = productPage.txtPrice.Text.Contains("€");  //to find about characters 

            Assert.IsTrue(isMyPriceInEuro);

        }

        [TestMethod]
        public void VerifyCurrencyPound()
        {
            ProductPage productPage = new ProductPage(browser);
            productPage.SearchForItem("iPhone");
            productPage.productResultClick();
            productPage.CurrencyClick();
            productPage.PoundClick();

            //Assert Price in Pounds

            var isMyPriceInPounds = productPage.txtPrice.Text.Contains("£");  //to find about characters 

            Assert.IsTrue(isMyPriceInPounds);

        }

        [TestMethod]
        public void WriteValidReview()
        {
            ProductPage productPage = new ProductPage(browser);
            productPage.SearchForItem("iPhone");
            productPage.productResultClick();
            productPage.TabReviewClick();
            productPage.WriteName("AslamAshishRmabadKumar");
            productPage.WriteReview("Very good product. I recommend");
            productPage.GiveRating();
            productPage.clickReviewButton();

            var reviewSuccessfully = productPage.successAlert.Text;

            Assert.AreEqual(reviewSuccessfully, "Thank you for your review. It has been submitted to the webmaster for approval.");

        }

        [TestMethod]
        public void WriteInvalidReviewRaiting()
        {
            ProductPage productPage = new ProductPage(browser);
            productPage.SearchForItem("iPhone");
            productPage.productResultClick();
            productPage.TabReviewClick();
            productPage.WriteName("AslamAshishRmabadKumar");
            productPage.WriteReview("Very good product. I recommend");
            productPage.clickReviewButton();

            var reviewFail = productPage.failAlert.Text;

            Assert.AreEqual(reviewFail, "Warning: Please select a review rating!");

        }

        [TestMethod]
        public void WriteInvalidReviewName()
        {
            ProductPage productPage = new ProductPage(browser);
            productPage.SearchForItem("iPhone");
            productPage.productResultClick();
            productPage.TabReviewClick();
            productPage.WriteReview("Very good product. I recommend");
            productPage.GiveRating();
            productPage.clickReviewButton();

            var reviewName = productPage.nameAlert.Text;

            Assert.AreEqual(reviewName, "Warning: Review Name must be between 3 and 25 characters!");

        }

        [TestMethod]
        public void WriteInvalidReviewcharacters()
        {
            ProductPage productPage = new ProductPage(browser);
            productPage.SearchForItem("iPhone");
            productPage.productResultClick();
            productPage.TabReviewClick();
            productPage.WriteName("AslamAshishRmabadKumar");
            productPage.WriteReview("Very good.");
            productPage.GiveRating();
            productPage.clickReviewButton();

            var reviewCharacters = productPage.charactersAlert.Text;

            Assert.AreEqual(reviewCharacters, "Warning: Review Text must be between 25 and 1000 characters!");
        }

        [TestMethod] 
        public void AddSimpleProdToCart()
        {
            ProductPage productPage = new ProductPage(browser);
            productPage.OpenSamsungMonitor();
            productPage.ClickAddToCart();
            productPage.ClickOnYourCart();

            var checkMonitorsProdTitle = productPage.txtMonitorsSamsungTitle.Text;  //txtMonitorsSamsungTitle

            Assert.AreEqual(checkMonitorsProdTitle, "Samsung SyncMaster 941BW");
        }

        [TestMethod]
        public void AddProductToCartFormCompletionRequired() 
        { 
            ProductPage productPage = new ProductPage(browser);
            productPage.OpenAppleMonitor();
            productPage.FillForm();
            productPage.ClickAddToCart();

            var msgAlertRadioRequired = productPage.AlertRadioRequired.Text;
            Assert.AreEqual(msgAlertRadioRequired, "Radio required!");

            var msgFileRequired = productPage.AlertFileRequired.Text;
            Assert.AreEqual(msgFileRequired, "File required!"); 
        }

        [TestMethod]
        public void CheckBoxUnchecked()  
        {
            ProductPage productPage = new ProductPage(browser);
            productPage.OpenAppleMonitor();
            productPage.ChooseColorClick();
            productPage.ChooseBlueColorClick();
            productPage.TextareaInputTyping();
            productPage.ClickAddToCart();

            var msgAlertRadioRequired = productPage.AlertRadioRequired.Text;
            Assert.AreEqual(msgAlertRadioRequired, "Radio required!");

            var msgFileRequired = productPage.AlertFileRequired.Text;
            Assert.AreEqual(msgFileRequired, "File required!");

            var msgCheckboxRequired = productPage.AlertCheckboxRequired.Text;
            Assert.AreEqual(msgCheckboxRequired, "Checkbox required!"); 
        }

        [TestMethod]
        public void ColorOptionUnchecked()
        {
            ProductPage productPage = new ProductPage(browser);
            productPage.OpenAppleMonitor();
            productPage.ChooseCheckBoxClick();
            productPage.TextareaInputTyping();
            productPage.ClickAddToCart(); 

            var msgAlertRadioRequired = productPage.AlertRadioRequired.Text;
            Assert.AreEqual(msgAlertRadioRequired, "Radio required!");

            var msgFileRequired = productPage.AlertFileRequired.Text;
            Assert.AreEqual(msgFileRequired, "File required!"); 

            var msgSelectRequired = productPage.AlertSelectRequired.Text;
            Assert.AreEqual(msgSelectRequired, "Select required!");
        }

        [TestMethod]
        public void TextareaUnchecked()  
        {
            ProductPage productPage = new ProductPage(browser);
            productPage.OpenAppleMonitor();
            productPage.ChooseCheckBoxClick();
            productPage.ChooseColorClick();
            productPage.ChooseBlueColorClick();
            productPage.ClickAddToCart();

            var msgAlertRadioRequired = productPage.AlertRadioRequired.Text;
            Assert.AreEqual(msgAlertRadioRequired, "Radio required!");

            var msgFileRequired = productPage.AlertFileRequired.Text;
            Assert.AreEqual(msgFileRequired, "File required!");

            var msgTextareaRequired = productPage.AlertTextareaRequired.Text;
            Assert.AreEqual(msgTextareaRequired, "Textarea required!");
        }
    }
}
