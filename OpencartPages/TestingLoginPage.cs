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
    [TestClass]   //MS Test tag
    public class TestingLoginPage
    {
        private ChromeDriver browser;   //declaram driverul ca private si variabila browser
        private HomePage newHomepage;   

        [TestInitialize]  //MS Test tag initialize
        public void TestInit()
        {
            //Open browser instance
            browser = new ChromeDriver();

            //Open page
            browser.Navigate().GoToUrl("https://demo.opencart.com/");

            //Implicit wait
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            newHomepage = new HomePage(browser);  //Initializare pagina HomePage

            newHomepage.ClickOnMyAccount();
            newHomepage.GoToLogin();

        }

        [TestCleanup]
        public void TestCleanup()
        {
            //Close driver and browser
            browser.Quit();
        }


        //TestMethods

        [TestMethod]
        public void VerifySuccessfullyLogin() 
        {
            LoginPage loginPage = new LoginPage(browser);
            loginPage.Login();

            newHomepage.ClickOnMyAccount();
            var isMyAccountVisible = newHomepage.linkMyAccount.Displayed;
            Assert.IsTrue(isMyAccountVisible);
        }


        [TestMethod]
        public void VerifyIncorrectEmailMsg() 
        {
            LoginPage loginPage = new LoginPage(browser);
            loginPage.Login("ovidiu.chirutza@gmail.com", "Parolanoua1234");

            var returnedError = loginPage.txtErrorMessage.Text;
            Assert.AreEqual(returnedError, "Warning: No match for E-Mail Address and/or Password.");
        }


        [TestMethod]
        public void VerifyIncorrectPassMsg()
        {
            LoginPage loginPage = new LoginPage(browser);
            loginPage.Login("ovidiu.chiruta@gmail.com", "Parolaincorecta");


            var returnedError = loginPage.txtErrorMessage.Text;
            Assert.AreEqual(returnedError, "Warning: No match for E-Mail Address and/or Password.");
        }


        [TestMethod]
        public void VerifyIncorrectEmailPassMsg()
        {
            LoginPage loginPage = new LoginPage(browser);
            loginPage.Login("emailgresit", "Parolaincorecta");


            var returnedError = loginPage.txtErrorMessage.Text;
            Assert.AreEqual(returnedError, "Warning: No match for E-Mail Address and/or Password.");
        }

    }
}
