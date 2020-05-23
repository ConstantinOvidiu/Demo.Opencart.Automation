using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpencartPages.Pages
{
    public class ContactUsPage: GenericPage
    {
        public ContactUsPage(IWebDriver browser)  //ContactUsPage constructor
        {
            PageFactory.InitElements(browser, this);  
        }


        //Elements

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-name\"]")]
        public IWebElement ContactUsNameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-email\"]")]
        public IWebElement ContactUsEmailField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-enquiry\"]")]
        public IWebElement ContactUsEnquiryField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/form/div/div/input")]
        public IWebElement BtnSubmitContactUs { get; set; }

        


        //Methods

        public void ContactUsSubmitValidForm()
        {
            ContactUsNameField.SendKeys("Ovidiu");
            ContactUsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            ContactUsEnquiryField.SendKeys("Hello! If I want to receive reward points how could I proceed? Thank you.");
            BtnSubmitContactUs.Click();
        }

        public void ContactUsSubmitInvalidName()
        {
            ContactUsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            ContactUsEnquiryField.SendKeys("Hello! If I want to receive reward points how could I proceed? Thank you.");
            BtnSubmitContactUs.Click();
        }

        public void ContactUsSubmitInvalidEmail()
        {
            ContactUsNameField.SendKeys("Ovidiu");
            ContactUsEnquiryField.SendKeys("Hello! If I want to receive reward points how could I proceed? Thank you.");
            BtnSubmitContactUs.Click();
        }

        public void ContactUsSubmitInvalidEnquiryText()
        {
            ContactUsNameField.SendKeys("Ovidiu");
            ContactUsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            ContactUsEnquiryField.SendKeys("Hello!");
            BtnSubmitContactUs.Click();
        }

        public void ContactUsSubmitInvalidEnquiryEmpty()
        {
            ContactUsNameField.SendKeys("Ovidiu");
            ContactUsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            BtnSubmitContactUs.Click();
        }
    }
}
