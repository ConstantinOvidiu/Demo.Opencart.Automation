using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpencartPages.Pages;
using OpenQA.Selenium.Chrome;

namespace OpencartPages
{
    [TestClass]
    public class UnitTest1
    {
        private ChromeDriver browser;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            //TODO Login before starting test methods

            //LoginPage loginPage = new LoginPage(browser);
            //loginPage.Login();

        }

        [ClassCleanup]
        public static void ClasCleanUp()
        {

        }

        [TestInitialize]
        public void TestInit()
        {
            //Open browser instance
            browser = new ChromeDriver();

            //Open IMDB page
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
        public void VerifySearchForASpecificItem()
        {
            HomePage homePage = new HomePage(browser);
            SearchResultsPage searchResultsPage = new SearchResultsPage(browser);

            var searchText = "MacBook";

            homePage.SearchForItem(searchText);

            var returnedItemTitle = searchResultsPage.txtProductTitle.Text;

            Assert.AreEqual(returnedItemTitle, searchText);
        }

        [TestMethod]
        public void VerifyMessageWhenNoItemsAreReturned()
        {
            HomePage homePage = new HomePage(browser);
            SearchResultsPage searchResultsPage = new SearchResultsPage(browser);

            homePage.SearchForItem("");

            var returnedMessage = searchResultsPage.txtNoItemsReturned.Text;

            Assert.AreEqual(returnedMessage, "There is no product that matches the search criteria.");
        }
    }
}
