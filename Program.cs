using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System.IO;

namespace Selenium2
{
    class Program
    {
        static void Main(string[] args)
        {

            string file = @"C:\Users\Rafib\Desktop\parsecsv.txt";
            file = @"C:\Users\Rafib\Downloads\Vega-Starter-Code-Section-5\vega\HtmlParse.html";
            string field1 = "";
            string field2 = "";
            string field3 = "";
            string field4 = "";
            string line = "";

            System.IO.StreamReader ofile = new System.IO.StreamReader(file);


            //while ((line = ofile.ReadToEnd()) != null )
            while ((line = ofile.ReadLine()) != null)
            {
           if (ofile.ReadLine().Contains("<td>") == true )
                {
                    int len = line.Length;
                    // field1 = line.Substring(0, 9);

                
                    string[] aryFields = line.Split(  "<td>" );
                  //  line.Split("<td>");


                    int endOfTdTag = 0;
                    field1 = aryFields[0];


                    var actual = field1.Substring(0, endOfTdTag  );
                    //    //field2 = aryFields[1];
             
                    //    string write = " field1=" + field1 + " field2=" + field2 + " field3=" + field4;
                    string write = field1;
                    // +field2 + field3 + field4
                    Console.WriteLine(field1);
                }
            }
      

            Console.ReadLine();
            /*
            IWebDriver driver = new InternetExplorerDriver(@"C:\Users\Rafib\Downloads\IEDriverServer_Win32_3.7.0\");          
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com");
            
            InternetExplorerOptions options = new InternetExplorerOptions();
            

            //driver.Navigate().GoToUrl("https://www.google.com");
            // Find the element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Preform operation
            element.SendKeys("ExecuteAutomation");
            */


            /*
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--test-type");
            //options.AddArgument("--ignore-certificate-errors");          
            //options.AddArguments("chrome.switches", "--disable-extensions --disable-extensions-file-access-check --disable-extensions-http-throttling");
            IWebDriver driver = new ChromeDriver(@"C:\Users\Rafib\Downloads\chromedriver_win32/");
      
            driver.Navigate().GoToUrl("https://www.google.com");

            // Find the element
            IWebElement element = driver.FindElement(By.Name("q"));
           
            //Preform operation
            element.SendKeys("ExecuteAutomation");
            //driver.GetScreenshot().SaveAsFile(@"F:\temp\screen.png", ImageFormat.Png);
            */
        }
    }
}
