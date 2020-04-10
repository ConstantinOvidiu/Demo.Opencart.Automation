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

            var isMyPriceInEuro = productPage.txtPriceInEuro.Text.Contains("€");  //to find about characters 

            Assert.IsTrue(isMyPriceInEuro);

        }
    }
}
