using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Selenium
{
    class EntryPoint
    {
        static void Main()
        {
            string jobSelectorButtonXPath = @"//*[@id=""navbarsExampleDefault""]/ul/li[1]/a";
            string inputFieldXCSSPath = "body > app-root > app-job-selector > div > label:nth-child(4) > input";
            string setButtonXPath = "/html/body/app-root/app-job-selector/div/label[2]/button";
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://vc1tsw01tfs15v7:8080/welcome");
            IWebElement jobSelectorButton = driver.FindElement(By.XPath(jobSelectorButtonXPath));
            jobSelectorButton.Click();
            IWebElement inputField = driver.FindElement(By.CssSelector(inputFieldXCSSPath));
            inputField.SendKeys("Some text");
            IWebElement setButton = driver.FindElement(By.XPath(jobSelectorButtonXPath));
            setButton.Click();





            Thread.Sleep(30000);

            driver.Quit();
        }
    }
}
