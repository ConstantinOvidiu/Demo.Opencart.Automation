using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpencartPages.Pages 
{
    public class GenericPage 

    {
        //------------------ELEMENTS----------------------

        //LOGIN Pimary Elements

        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement txtEmail { get; set; }


        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement txtPassword { get; set; }


        [FindsBy(How = How.CssSelector, Using = "input.btn.btn-primary")]
        private IWebElement BtnLoginPrimary { get; set; }


        [FindsBy(How = How.ClassName, Using = "alert")]
        public IWebElement txtErrorMessage { get; set; }


        //Search box Elements
        [FindsBy(How = How.Name, Using = "search")]
        private IWebElement searchInput { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-default.btn-lg")]
        private IWebElement btnSearch { get; set; }


        //My Account Dropdown Elements
        [FindsBy(How = How.CssSelector, Using = "i.fa.fa-user")]
        public IWebElement btnMyAccount { get; set; }

        [FindsBy(How = How.LinkText, Using = "My Account")]
        public IWebElement linkMyAccount { get; set; }

        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement btnLogin { get; set; }


        // Logo, Cart button
        [FindsBy(How = How.Id, Using = "logo")]
        public IWebElement linkLogo { get; set; }

        [FindsBy(How = How.Id, Using = "cart")]
        public IWebElement btnCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"cart\"]/ul/li/p")]
        public IWebElement txtEmptyCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"cart\"]/ul/li[1]/table/tbody/tr/td[5]/button/i")]
        public IWebElement BtnRemoveFromCart { get; set; }


        //NAVBAR
        //Desktops Dropdown Elements
        [FindsBy(How = How.LinkText, Using = "Desktops")]
        public IWebElement linkDesktops { get; set; }

        [FindsBy(How = How.LinkText, Using = "PC (0)")]
        public IWebElement pcProductsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/p")]
        public IWebElement txtNoProductsToList { get; set; }


        //Laptops & Notebooks Dropdown Elements
        [FindsBy(How = How.LinkText, Using = "Laptops & Notebooks")]
        public IWebElement linkLaptopsAndNotebooks { get; set; }

        [FindsBy(How = How.LinkText, Using = "Windows (0)")]
        public IWebElement windowsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/p")]
        public IWebElement txtNoProductsToListLN { get; set; }


        //Components Dropdown Elements
        [FindsBy(How = How.LinkText, Using = "Components")]
        public IWebElement linkComponents { get; set; }

        [FindsBy(How = How.LinkText, Using = "Monitors (2)")]
        public IWebElement linkMonitors { get; set; }

       

        //Tablets Page Elements
        [FindsBy(How = How.LinkText, Using = "Tablets")]
        public IWebElement linkTablets { get; set; }


        //Software Page Elements
        [FindsBy(How = How.LinkText, Using = "Software")]
        public IWebElement linkSoftware { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/p")]
        public IWebElement txtNoProductsToListSof { get; set; }


        //Phones and PDAs Page Elements
        [FindsBy(How = How.LinkText, Using = "Phones & PDAs")]
        public IWebElement linkPhonesPDAsPage { get; set; }

        [FindsBy(How = How.LinkText, Using = "Palm Treo Pro")]
        public IWebElement txtPhonesPDAsProdTitle { get; set; }


        //Cameras Page Elements
        [FindsBy(How = How.LinkText, Using = "Cameras")]
        public IWebElement linkCameras { get; set; }


        //MP3 Dropdown Elements
        [FindsBy(How = How.LinkText, Using = "MP3 Players")]
        public IWebElement linkMP3Players { get; set; }

        [FindsBy(How = How.LinkText, Using = "test 4 (0)")]
        public IWebElement linkTest4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/p")]
        public IWebElement txtNoProductsToListMp3 { get; set; }


        //Add to Cart Button
        [FindsBy(How = How.Id, Using = "button-cart")]
        public IWebElement addToCartBtn { get; set; }



        //Footer Elements
        //Information column

        [FindsBy(How = How.CssSelector, Using = "#content h1")]
        public IWebElement FooterTitlePageNoContent { get; set; } 

        [FindsBy(How = How.LinkText, Using = "About Us")]
        public IWebElement LinkAboutUs { get; set; }

        [FindsBy(How = How.LinkText, Using = "Delivery Information")]
        public IWebElement LinkDeliveryInformation { get; set; }

        [FindsBy(How = How.LinkText, Using = "Privacy Policy")]
        public IWebElement LinkPrivacyPolicy { get; set; }

        [FindsBy(How = How.LinkText, Using = "Terms & Conditions")]
        public IWebElement LinkTermsConditions { get; set; }


        //Customer Service column
        //Contact Us

        [FindsBy(How = How.LinkText, Using = "Contact Us")]
        public IWebElement LinkContactUs { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-name\"]")]
        public IWebElement ContactUsNameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-email\"]")]
        public IWebElement ContactUsEmailField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"input-enquiry\"]")]
        public IWebElement ContactUsEnquiryField { get; set; }
                                           
        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/form/div/div/input")]
        public IWebElement BtnSubmitContactUs { get; set; }

        [FindsBy(How = How.ClassName, Using = "text-danger")]
        public IWebElement AlertMsgForms { get; set; }  


        //Returns page
        [FindsBy(How = How.LinkText, Using = "Returns")]
        public IWebElement LinkReturns { get; set; }

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

        [FindsBy(How = How.CssSelector, Using = "#common-success .row #content p")]
        public IWebElement SuccesMsgGeneric{ get; set; }

        //Site Map

        [FindsBy(How = How.LinkText, Using = "Site Map")]
        public IWebElement LinkSiteMap { get; set; }


        //Extras
        //Brands

        [FindsBy(How = How.LinkText, Using = "Brands")]
        public IWebElement LinkBrands { get; set; }

        //Gift Certificates

        [FindsBy(How = How.LinkText, Using = "Gift Certificates")]
        public IWebElement LinkGiftCertificates { get; set; }

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

        //Affiliate

        [FindsBy(How = How.LinkText, Using = "Affiliate")]
        public IWebElement LinkAffiliate { get; set; }

        //Specials

        [FindsBy(How = How.LinkText, Using = "Specials")]
        public IWebElement LinkSpecials { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#content h2")]
        public IWebElement GenericTitleHead2 { get; set; }

        //My Account column 
        //My Account

        [FindsBy(How = How.LinkText, Using = "My Account")]
        public IWebElement LinkMyAccount { get; set; }

        //Order History

        [FindsBy(How = How.LinkText, Using = "Order History")]
        public IWebElement LinkOrderHistory { get; set; }

        //Wish List 

        [FindsBy(How = How.LinkText, Using = "Wish List")]
        public IWebElement LinkWishList { get; set; }

        //Newsletter

        [FindsBy(How = How.LinkText, Using = "Newsletter")]
        public IWebElement LinkNewsletter { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[name=\"newsletter\"][value=\"0\"]")]
        public IWebElement NewsletterRadioNo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"content\"]/form/div/div[2]/input")]
        public IWebElement BtnSubmitNewsletter { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#account-account .alert-success")]
        public IWebElement SuccessMsgNewsletter { get; set; }





        //------------------METHODS----------------------

        //LOGIN Pimary Methods

        public void Login()
        {
            txtEmail.SendKeys("ovidiu.chiruta@gmail.com");
            txtPassword.SendKeys("Parolanoua1234");
            BtnLoginPrimary.Click();
        }

        public void Login(string username, string password)
        {
            txtEmail.SendKeys(username);
            txtPassword.SendKeys(password);
            BtnLoginPrimary.Click();
        }

        //Remove from Cart Method
        public void RemoveFromCart()
        {
            BtnRemoveFromCart.Click();
        }

        //Search box Methods
        public void SearchForItem(string text)
        {
            searchInput.SendKeys(text);
            btnSearch.Click();
        }

        //MyAccount Methods
        public void ClickOnMyAccount()
        {
            btnMyAccount.Click();
        }

        public void GoToLogin()
        {
            btnLogin.Click();
        }

        //Click on logo and cart button Methods
        public void ClickOnLogo()
        {
            linkLogo.Click();
        }

        public void ClickOnYourCart()  
        {
            btnCart.Click();
        }



        //Desktops Dropdown Methods
        public void ClickOnDesktops()
        {
            linkDesktops.Click();
        }

        public void ClickOnPC()
        {
            pcProductsLink.Click();
        }


        //Laptops & Notebooks Dropdown Methods 
        public void ClickOnLaptopsAndNotebooks()
        {
            linkLaptopsAndNotebooks.Click();
        }

        public void ClickOnWindows()
        {
            windowsLink.Click();
        }


        //Components Dropdown Methods 
        public void ClickOnComponents()
        {
            linkComponents.Click();
        }

        public void ClickOnMonitors()
        {
            linkMonitors.Click();
        }


        //Tablets Page Methods 
        public void ClickOnTablets()
        {
            linkTablets.Click();
        }


        //Software Page Methods 
        public void ClickOnSoftwarePage()
        {
            linkSoftware.Click();
        }


        //PhonesPDAs Page Methods 
        public void ClickOnPhonesPDAsPage()
        {
            linkPhonesPDAsPage.Click();
        }


        //Cameras Page Methods 
        public void ClickOnCamerasPage()
        {
            linkCameras.Click();
        }


        //MP3 Dropdown Methods 
        public void ClickOnMP3Players()
        {
            linkMP3Players.Click();
        }

        public void ClickOnTest4()
        {
            linkTest4.Click();
        }


        //Click Add to Cart
        public void ClickAddToCart()
        {
            addToCartBtn.Click();
        }


        //Footer Methods
        //Information column

        public void ClickLinkAboutUs()
        {
            LinkAboutUs.Click();
        }

        public void ClickDeliveryInformation()
        {
            LinkDeliveryInformation.Click();
        }

        public void ClickPrivacyPolicy()
        {
            LinkPrivacyPolicy.Click();
        }

        public void ClickTermsConditions()
        {
            LinkTermsConditions.Click();
        }


        //Customer Service
        //Contact Us page

        public void ContactUsSubmitValidForm()
        {
            LinkContactUs.Click();
            ContactUsNameField.SendKeys("Ovidiu");
            ContactUsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            ContactUsEnquiryField.SendKeys("Hello! If I want to receive reward points how could I proceed? Thank you.");
            BtnSubmitContactUs.Click(); 
        }

        public void ContactUsSubmitInvalidName()
        {
            LinkContactUs.Click();
            ContactUsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            ContactUsEnquiryField.SendKeys("Hello! If I want to receive reward points how could I proceed? Thank you.");
            BtnSubmitContactUs.Click();
        }

        public void ContactUsSubmitInvalidEmail() 
        {
            LinkContactUs.Click();
            ContactUsNameField.SendKeys("Ovidiu");
            ContactUsEnquiryField.SendKeys("Hello! If I want to receive reward points how could I proceed? Thank you.");
            BtnSubmitContactUs.Click();
        }

        public void ContactUsSubmitInvalidEnquiryText()
        {
            LinkContactUs.Click();
            ContactUsNameField.SendKeys("Ovidiu");
            ContactUsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            ContactUsEnquiryField.SendKeys("Hello!");
            BtnSubmitContactUs.Click();
        }

        public void ContactUsSubmitInvalidEnquiryEmpty() 
        {
            LinkContactUs.Click();
            ContactUsNameField.SendKeys("Ovidiu");
            ContactUsEmailField.SendKeys("ovidiu.chiruta@gmail.com");
            BtnSubmitContactUs.Click();
        }


        //Returns page

        public void ReturnsSubmitValidForm()  
        {
            LinkReturns.Click();
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
            LinkReturns.Click();
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
            LinkReturns.Click();
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
            LinkReturns.Click();
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
            LinkReturns.Click();
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
            LinkReturns.Click();
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
            LinkReturns.Click();
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
            LinkReturns.Click();
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
            LinkReturns.Click();
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
            LinkReturns.Click(); 
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
            LinkReturns.Click();
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

        //Site Map 

        public void ClickLinkSiteMap() 
        {
            LinkSiteMap.Click();
        }

        
        //Extras
        //Brands

        public void ClickLinkBrandsPage()
        {
            LinkBrands.Click();
        }

        //Gift Certificates

        public void GiftCertSubmitValidForm() 
        {
            LinkGiftCertificates.Click();
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


        //Affiliate

        public void ClickLinkAffiliatePage()
        {
            LinkAffiliate.Click();
        }

        //Specials

        public void ClickLinkSpecialsPage()
        {
            LinkSpecials.Click(); 
        }


        //My Account column
        //My Account

        public void ClickMyAccountsPage()
        {
            LinkMyAccount.Click();
        }

        //Order History

        public void ClickOrderHistoryPage()
        {
            LinkOrderHistory.Click();
        }

        //Wish List

        public void ClickOrderWishListPage()
        {
            LinkWishList.Click();
        }

        //Newsletter

        public void ClickNewsletterPage()
        {
            LinkNewsletter.Click();
        }

        public void NewsletterSubscribeNo()
        {
            NewsletterRadioNo.Click();
            BtnSubmitNewsletter.Click();
        }

    }
}

