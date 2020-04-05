using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpencartPages.Pages;
using OpenQA.Selenium.Chrome;

namespace OpencartPages
{
    [TestClass]  //MS Test tag
    public class TestingHomePage 
    {
        private ChromeDriver browser;   //declaram driverul ca private si variabila browser


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
