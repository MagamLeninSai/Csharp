using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("iphone");
            driver.FindElement(By.Id("nav-search-submit-button")).Click();
            
            string originalWindow = driver.CurrentWindowHandle;

            driver.FindElement(By.XPath("(//*[@class='s-image'])[1]")).Click();

            foreach (string window in driver.WindowHandles)
            {
                if (originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }
            driver.FindElement(By.Id("add-to-cart-button")).Click();
            Thread.Sleep(2000);
            driver.Close();
            driver.Quit();
        }
    }
}
