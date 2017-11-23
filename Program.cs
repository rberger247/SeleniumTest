using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium2
{
    class Program
    {
        static void Main(string[] args)
        {

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("test-type");

            options.AddArguments("chrome.switches", "--disable-extensions --disable-extensions-file-access-check --disable-extensions-http-throttling");
            IWebDriver driver = new ChromeDriver(@"C:\Users\Rafib\Downloads\chromedriver_win32/");
      
            driver.Navigate().GoToUrl("https://www.google.com");

            // Find the element
            IWebElement element = driver.FindElement(By.Name("q"));
           
            //Preform operation
            element.SendKeys("ExecuteAutomation");
            //driver.GetScreenshot().SaveAsFile(@"F:\temp\screen.png", ImageFormat.Png);
        }
    }
}
