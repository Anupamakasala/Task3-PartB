using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AdvancedTaskSpecFlow.Pages;

namespace AdvancedTaskSpecFlow.Utilities
{
    public class CommonDriver
    {
        
        public static IWebDriver driver;
        
        public static ExtentReports extentReportObj = null;
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentTest test;
        static string reportPath = System.IO.Directory.GetParent(@"../../../").FullName +
        Path.DirectorySeparatorChar + "ExtentReports" +
        Path.DirectorySeparatorChar + "Result " + DateTime.Now.ToString("ddMMyyyy HHmmss");
        
        public static void Initialize()
        {
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(reportPath);
            extentReportObj = new ExtentReports();
            extentReportObj.AttachReporter(htmlReporter);

            driver = new ChromeDriver();
            

        }

        public class GetScreenShot
        {
            public static string Capture(IWebDriver driver, string screenShotName)
            {
                ITakesScreenshot ts = (ITakesScreenshot)driver;
                Screenshot screenshot = ts.GetScreenshot();
                string pth = System.Reflection.Assembly.GetCallingAssembly().Location;
                string finalpth = pth.Substring(0, pth.LastIndexOf("bin")) + "Screenshots\\" + screenShotName + ".png";
                string localpath = new Uri(finalpth).LocalPath;
                screenshot.SaveAsFile(localpath, ScreenshotImageFormat.Png);
                return localpath;
            }
        }


        public static void Close()
        {
            extentReportObj.Flush();
            driver.Quit();

        }
    }
}





