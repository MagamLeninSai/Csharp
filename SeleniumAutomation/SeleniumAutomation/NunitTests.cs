using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumAutomation
{
    class NunitTests
    {
        IWebDriver driver = new ChromeDriver();
      
        private IWebElement element;
        string originalWindow;

        [SetUp]
        public void initialise() {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            Screenshot screenshot = (driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile("C:\\training\\C_Sharp\\SeleniumAutomation\\SeleniumAutomation\\ScreenShot\\img.png", ScreenshotImageFormat.Png);
            Thread.Sleep(2000);
        }
        
        [Test,Order(3)]
        public void verifyBestSellersAddedToCart() {
            element = driver.FindElement(By.XPath("(//*[text()='Best Sellers'])[1]"));
            Assert.AreEqual(element.Text, "Best Sellers");
            element.Click();
            driver.FindElement(By.XPath("//*[text()='Amazon Launchpad']")).Click();
            driver.FindElement(By.XPath("(//*[@class='p13n-sc-truncate-desktop-type2 p13n-sc-truncated'])[1]")).Click();
            driver.FindElement(By.Id("add-to-cart-button")).Click();
            Thread.Sleep(2000);
        }
        [Test,Order(2)]
        public void verifyMobileIsAddedToCart()
        {
            Actions act = new Actions(driver);
            driver.FindElement(By.XPath("(//*[contains(text(),'Mobiles')])[2]")).Click();
            Thread.Sleep(3000);
            element = driver.FindElement(By.XPath("//*[text()='Cloudtail India']"));
            act.MoveToElement(element).Click().Perform();
            Thread.Sleep(2000);

            originalWindow = driver.CurrentWindowHandle;

            driver.FindElement(By.XPath("(//*[@class='s-image'])[3]")).Click();
            Thread.Sleep(2000);
            this.switchToNextPage();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("add-to-cart-button")).Click();
            Thread.Sleep(2000);
            driver.Close();
            driver.SwitchTo().Window(originalWindow);
        }
        [Test,Order(1)]
        public void verifyAddToCart() {
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("iphone");
            driver.FindElement(By.Id("nav-search-submit-button")).Click();

            originalWindow = driver.CurrentWindowHandle;

            driver.FindElement(By.XPath("(//*[@class='s-image'])[1]")).Click();
            Thread.Sleep(2000);
            this.switchToNextPage();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("add-to-cart-button")).Click();
            Thread.Sleep(2000);
            driver.Close();
            driver.SwitchTo().Window(originalWindow);
            
        }
        public void switchToNextPage() {
            foreach (string window in driver.WindowHandles)
            {
                if (originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }
        }
        public void oneTimeSetUp() {

        }

        [OneTimeTearDown]
        public void endTest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
