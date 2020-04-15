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
    public class TestingNavbarPages
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
        public void DesktopsDropdown() 
        {

            NavbarPages navbarPages = new NavbarPages(browser);
            navbarPages.ClickOnDesktops();
            navbarPages.ClickOnPC();

            var checkPCPageMsg = navbarPages.txtNoProductsToList.Text;

            Assert.AreEqual(checkPCPageMsg, "There are no products to list in this category.");
        }

        [TestMethod]
        public void LaptopsAndNotebooksDropdown()
        {

            NavbarPages navbarPages = new NavbarPages(browser);
            navbarPages.ClickOnLaptopsAndNotebooks();
            navbarPages.ClickOnWindows();

            var checkWindowsPageMsg = navbarPages.txtNoProductsToListLN.Text;

            Assert.AreEqual(checkWindowsPageMsg, "There are no products to list in this category.");
        }


        [TestMethod]
        public void ComponentsDropdown()
        {

            NavbarPages navbarPages = new NavbarPages(browser);
            navbarPages.ClickOnComponents();
            navbarPages.ClickOnMonitors();

            var checkMonitorsProdTitle = navbarPages.txtMonitorsProdTitle.Text;

            Assert.AreEqual(checkMonitorsProdTitle, "Samsung SyncMaster 941BW");
        }


        [TestMethod]
        public void TabletsPage()
        {

            NavbarPages navbarPages = new NavbarPages(browser);
            navbarPages.ClickOnTablets();

            var checkTabletsProdTitle = navbarPages.txtTabletsProdTitle.Text;

            Assert.AreEqual(checkTabletsProdTitle, "Samsung Galaxy Tab 10.1");
        }


        [TestMethod]
        public void SoftwarePage()
        {

            NavbarPages navbarPages = new NavbarPages(browser);
            navbarPages.ClickOnSoftwarePage();

            var checkSoftwarePageMsg = navbarPages.txtNoProductsToListSof.Text; 

            Assert.AreEqual(checkSoftwarePageMsg, "There are no products to list in this category.");
        }


        [TestMethod]
        public void PhonesAndPDAsPage() 
        {

            NavbarPages navbarPages = new NavbarPages(browser);
            navbarPages.ClickOnPhonesPDAsPage();

            var checkPhonesPDAsProdTitle = navbarPages.txtPhonesPDAsProdTitle.Text; 

            Assert.AreEqual(checkPhonesPDAsProdTitle, "Palm Treo Pro");
        }


        [TestMethod]
        public void CamerasPage()
        {

            NavbarPages navbarPages = new NavbarPages(browser);
            navbarPages.ClickOnCamerasPage(); 

            var checkCamerasProdTitle = navbarPages.txtCamerasProdTitle.Text;

            Assert.AreEqual(checkCamerasProdTitle, "Nikon D300");
        }


        [TestMethod]
        public void MP3PlayersDropdown() 
        {

            NavbarPages navbarPages = new NavbarPages(browser);
            navbarPages.ClickOnMP3Players(); 
            navbarPages.ClickOnTest4();

            var checkMp3PageMsg = navbarPages.txtNoProductsToListMp3.Text; 

            Assert.AreEqual(checkMp3PageMsg, "There are no products to list in this category.");
        }
    }
}
