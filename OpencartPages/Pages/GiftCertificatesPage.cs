using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpencartPages.Pages
{
    public class GiftCertificatesPage: GenericPage
    {
        public GiftCertificatesPage(IWebDriver browser)  //GiftCertificatesPage constructor
        {
            PageFactory.InitElements(browser, this);
        }

        //Elements

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-to-name\"]")]
        public IWebElement GiftRecipientsNameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-to-email\"]")]
        public IWebElement GiftRecipientsEmailField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-from-name\"]")]
        public IWebElement GiftYourNameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-from-email\"]")]
        public IWebElement GiftEmailField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[name=\"voucher_theme_id\"][value=\"7\"]")]
        public IWebElement GiftCertThemeRadio { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[name=\"agree\"][value=\"1\"]")]
        public IWebElement GiftAgreementCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/form/div[8]/div/input[2]")]
        public IWebElement BtnSubmitGiftCert { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".alert.alert-danger.alert-dismissible")]
        public IWebElement AlertAgreementCheckBox { get; set; }


        //Methods

        public void GiftCertSubmitValidForm()
        {
            GiftRecipientsNameField.SendKeys("My gifts");
            GiftRecipientsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            GiftYourNameField.SendKeys("Ovidiu");
            GiftEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            GiftCertThemeRadio.Click();
            GiftAgreementCheckBox.Click();
            BtnSubmitGiftCert.Click();
        }

        public void GiftCertInvalidFormRecipientsName()
        {
            LinkGiftCertificates.Click();
            GiftRecipientsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            GiftYourNameField.SendKeys("Ovidiu");
            GiftEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            GiftCertThemeRadio.Click();
            GiftAgreementCheckBox.Click();
            BtnSubmitGiftCert.Click();
        }

        public void GiftCertInvalidFormRecipientsEmail()
        {
            LinkGiftCertificates.Click();
            GiftRecipientsNameField.SendKeys("My gifts");
            GiftYourNameField.SendKeys("Ovidiu");
            GiftEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            GiftCertThemeRadio.Click();
            GiftAgreementCheckBox.Click();
            BtnSubmitGiftCert.Click();
        }

        public void GiftCertInvalidFormName()
        {
            LinkGiftCertificates.Click();
            GiftRecipientsNameField.SendKeys("My gifts");
            GiftRecipientsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            GiftEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            GiftCertThemeRadio.Click();
            GiftAgreementCheckBox.Click();
            BtnSubmitGiftCert.Click();
        }

        public void GiftCertInvalidEmail()
        {
            LinkGiftCertificates.Click();
            GiftRecipientsNameField.SendKeys("My gifts");
            GiftRecipientsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            GiftYourNameField.SendKeys("Ovidiu");
            GiftCertThemeRadio.Click();
            GiftAgreementCheckBox.Click();
            BtnSubmitGiftCert.Click();
        }

        public void GiftCertInvalidTheme()
        {
            LinkGiftCertificates.Click();
            GiftRecipientsNameField.SendKeys("My gifts");
            GiftRecipientsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            GiftYourNameField.SendKeys("Ovidiu");
            GiftEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            GiftAgreementCheckBox.Click();
            BtnSubmitGiftCert.Click();
        }

        public void GiftCertInvalidAgrCheckBox()
        {
            LinkGiftCertificates.Click();
            GiftRecipientsNameField.SendKeys("My gifts");
            GiftRecipientsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            GiftYourNameField.SendKeys("Ovidiu");
            GiftEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            GiftCertThemeRadio.Click();
            BtnSubmitGiftCert.Click();
        }
    }
}
