using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace SeleniumBeginner.StepDefinitions
{
    [Binding]
    public class GoogleSearchSteps
    {
        public object TimeUnit { get; private set; }

        ChromeDriver browser = new ChromeDriver();

        //WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(30));



        [Given(@"I navigate to Google")]
        public void GivenINavigateToGoogle()
        {
            browser.Navigate().GoToUrl("http://www.google.com/");   
        }
        
        [Given(@"I click the Login button")]
        public void GivenIClickTheLoginButton()
        {
            browser.FindElementById("gb_70").Click();
        }
        
        [Given(@"I have entered my credentials")]
        public void GivenIHaveEnteredMyCredentials()
        {
            browser.FindElementByCssSelector("input#identifierId").SendKeys("testcont1992@gmail.com");
            browser.FindElementById("identifierNext").Click();

            Thread.Sleep(2000);


            browser.FindElementByCssSelector("input.whsOnd.zHQkBf").SendKeys("Parolanoua1234");

            Thread.Sleep(2000);
        }
        
        [Given(@"I fill the search input")]
        public void GivenIFillTheSearchInput()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I press submit")]
        public void WhenIPressSubmit()
        {
            browser.FindElementByClassName("CwaK9").Click();

            Thread.Sleep(2000);
        }
        
        [When(@"I press enter")]
        public void WhenIPressEnter()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am successfully Logged In")]
        public void ThenIAmSuccessfullyLoggedIn()
        {
            browser.FindElementByClassName("gb_Ia").Click();

            //assert 
            var ceva = browser.FindElementByClassName("gb_rb").Text;
            Assert.AreEqual(ceva, "test cont1992");

            browser.Quit();
        }
        
        [Then(@"I can see the search results")]
        public void ThenICanSeeTheSearchResults()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
