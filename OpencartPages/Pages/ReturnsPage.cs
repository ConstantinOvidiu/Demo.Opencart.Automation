using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpencartPages.Pages
{
    public class ReturnsPage: GenericPage
    {
        public ReturnsPage(IWebDriver browser)  //ReturnsPage constructor
        {
            PageFactory.InitElements(browser, this);
        }


        //Elements

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-firstname\"]")]
        public IWebElement ReturnsFirstNameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-lastname\"]")]
        public IWebElement ReturnsLastNameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-email\"]")]
        public IWebElement ReturnsEmailField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-telephone\"]")]
        public IWebElement ReturnsTelephoneField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-order-id\"]")]
        public IWebElement ReturnsOrderIdField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-product\"]")]
        public IWebElement ReturnsProductNameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-model\"]")]
        public IWebElement ReturnsProductCodeField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[name=\"return_reason_id\"][value=\"1\"]")]
        public IWebElement ReturnsResOfRet { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[name=\"opened\"][value=\"1\"]")]
        public IWebElement ReturnsProdOpenedYes { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/form/div/div[2]/input")]
        public IWebElement BtnSubmitReturns { get; set; }



        //Methods

        public void ReturnsValidForm()
        {
            ReturnsFirstNameField.SendKeys("Ovidiu");
            ReturnsLastNameField.SendKeys("Chiruta");
            ReturnsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            ReturnsTelephoneField.SendKeys("0741333444");
            ReturnsOrderIdField.SendKeys("01");
            ReturnsProductNameField.SendKeys("MacBook");
            ReturnsProductCodeField.SendKeys("Product 16");
            ReturnsResOfRet.Click();
            ReturnsProdOpenedYes.Click();
            BtnSubmitReturns.Click();
        }

        public void ReturnsInvalidFormFirstName() 
        {

            ReturnsLastNameField.SendKeys("Chiruta");
            ReturnsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            ReturnsTelephoneField.SendKeys("0741333444");
            ReturnsOrderIdField.SendKeys("01");
            ReturnsProductNameField.SendKeys("MacBook");
            ReturnsProductCodeField.SendKeys("Product 16");
            ReturnsResOfRet.Click();
            ReturnsProdOpenedYes.Click();
            BtnSubmitReturns.Click();
        }

        public void ReturnsInvalidFormLasttName()
        {

            ReturnsFirstNameField.SendKeys("Ovidiu");
            ReturnsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            ReturnsTelephoneField.SendKeys("0741333444");
            ReturnsOrderIdField.SendKeys("01");
            ReturnsProductNameField.SendKeys("MacBook");
            ReturnsProductCodeField.SendKeys("Product 16");
            ReturnsResOfRet.Click();
            ReturnsProdOpenedYes.Click();
            BtnSubmitReturns.Click();
        }

        public void ReturnsInvalidFormEmail()
        {

            ReturnsFirstNameField.SendKeys("Ovidiu");
            ReturnsLastNameField.SendKeys("Chiruta");
            ReturnsTelephoneField.SendKeys("0741333444");
            ReturnsOrderIdField.SendKeys("01");
            ReturnsProductNameField.SendKeys("MacBook");
            ReturnsProductCodeField.SendKeys("Product 16");
            ReturnsResOfRet.Click();
            ReturnsProdOpenedYes.Click();
            BtnSubmitReturns.Click();
        }

        public void ReturnsInvalidFormTelephone()
        {

            ReturnsFirstNameField.SendKeys("Ovidiu");
            ReturnsLastNameField.SendKeys("Chiruta");
            ReturnsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            ReturnsOrderIdField.SendKeys("01");
            ReturnsProductNameField.SendKeys("MacBook");
            ReturnsProductCodeField.SendKeys("Product 16");
            ReturnsResOfRet.Click();
            ReturnsProdOpenedYes.Click();
            BtnSubmitReturns.Click();
        }

        public void ReturnsInvalidFormOrderID()
        {

            ReturnsFirstNameField.SendKeys("Ovidiu");
            ReturnsLastNameField.SendKeys("Chiruta");
            ReturnsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            ReturnsTelephoneField.SendKeys("0741333444");
            ReturnsProductNameField.SendKeys("MacBook");
            ReturnsProductCodeField.SendKeys("Product 16");
            ReturnsResOfRet.Click();
            ReturnsProdOpenedYes.Click();
            BtnSubmitReturns.Click();
        }

        public void ReturnsInvalidFormProductName()
        {

            ReturnsFirstNameField.SendKeys("Ovidiu");
            ReturnsLastNameField.SendKeys("Chiruta");
            ReturnsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            ReturnsTelephoneField.SendKeys("0741333444");
            ReturnsOrderIdField.SendKeys("01");
            ReturnsProductCodeField.SendKeys("Product 16");
            ReturnsResOfRet.Click();
            ReturnsProdOpenedYes.Click();
            BtnSubmitReturns.Click();
        }

        public void ReturnsInvalidFormProductCode()
        {

            ReturnsFirstNameField.SendKeys("Ovidiu");
            ReturnsLastNameField.SendKeys("Chiruta");
            ReturnsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            ReturnsTelephoneField.SendKeys("0741333444");
            ReturnsOrderIdField.SendKeys("01");
            ReturnsProductNameField.SendKeys("MacBook");
            ReturnsResOfRet.Click();
            ReturnsProdOpenedYes.Click();
            BtnSubmitReturns.Click();
        }

        public void ReturnsInvalidFormReasOfRet()
        {

            ReturnsFirstNameField.SendKeys("Ovidiu");
            ReturnsLastNameField.SendKeys("Chiruta");
            ReturnsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            ReturnsTelephoneField.SendKeys("0741333444");
            ReturnsOrderIdField.SendKeys("01");
            ReturnsProductNameField.SendKeys("MacBook");
            ReturnsProductCodeField.SendKeys("Product 16");
            ReturnsProdOpenedYes.Click();
            BtnSubmitReturns.Click();
        }

        public void OrderIdCheckValZero()
        {

            ReturnsFirstNameField.SendKeys("Ovidiu");
            ReturnsLastNameField.SendKeys("Chiruta");
            ReturnsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            ReturnsTelephoneField.SendKeys("0741333444");
            ReturnsOrderIdField.SendKeys("0");
            ReturnsProductNameField.SendKeys("MacBook");
            ReturnsProductCodeField.SendKeys("Product 16");
            ReturnsResOfRet.Click();
            ReturnsProdOpenedYes.Click();
            BtnSubmitReturns.Click();
        }

        public void OrderIdCheckValZeroZero()
        {

            ReturnsFirstNameField.SendKeys("Ovidiu");
            ReturnsLastNameField.SendKeys("Chiruta");
            ReturnsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            ReturnsTelephoneField.SendKeys("0741333444");
            ReturnsOrderIdField.SendKeys("00");
            ReturnsProductNameField.SendKeys("MacBook");
            ReturnsProductCodeField.SendKeys("Product 16");
            ReturnsResOfRet.Click();
            ReturnsProdOpenedYes.Click();
            BtnSubmitReturns.Click();
        }
    }
}
