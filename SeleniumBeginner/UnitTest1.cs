using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace SeleniumBeginner
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var browser = new ChromeDriver();

            browser.Navigate().GoToUrl("http://www.google.com/");

            browser.FindElementByCssSelector("input.gLFyf").SendKeys("Abi Talent Velea");

            browser.FindElementByName("btnK").Click();

            var text = browser.FindElementByCssSelector("div.rc").Text;

            var existaAbi = text.Contains("Abi Talent și conflictul cu Alex Velea - ce i-a transmis");

            Assert.IsTrue(existaAbi);

            browser.Quit();
                          
        }
    }
}
