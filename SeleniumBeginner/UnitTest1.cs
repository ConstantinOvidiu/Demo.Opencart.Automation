using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumBeginner
{
    [TestClass]
    public class UnitTest1
    {
        public object TimeUnit { get; private set; }

        [TestMethod]
        public void TestMethod1()
        {
 
            var browser = new ChromeDriver();

            //wait 
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(30));

            browser.Navigate().GoToUrl("http://www.google.com/");
            browser.FindElementById("gb_70").Click();

            

            browser.FindElementByCssSelector("input#identifierId").SendKeys("testcont1992@gmail.com");
            browser.FindElementById("identifierNext").Click();


            Thread.Sleep(2000);


            browser.FindElementByCssSelector("input.whsOnd.zHQkBf").SendKeys("Parolanoua1234");


            Thread.Sleep(2000);

            browser.FindElementByClassName("CwaK9").Click();

            Thread.Sleep(2000);

            browser.FindElementByClassName("gb_Ia").Click();

            //assert 
            var ceva = browser.FindElementByClassName("gb_ob").Text;
            Assert.AreEqual(ceva, "test cont1992");



           //browser.Quit();

        }
    }
}
