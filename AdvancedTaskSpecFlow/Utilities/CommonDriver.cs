using AdvancedTaskSpecFlow.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using AdvancedTaskSpecFlow.Utilities;
using AdvancedTaskSpecFlow.Pages;
using NUnit.Framework;

namespace AdvancedTaskSpecFlow.Utilities
{
    
    public class CommonDriver
    {
       
        public static IWebDriver driver;
        LoginPage loginPageObj;
        

        [BeforeScenario]
        public void SetUp()
        {
           
            //Initiate driver

            driver = new ChromeDriver();

            //Maximise the window
            driver.Manage().Window.Maximize();

            //Navigate to Url
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

        }

        // [AfterScenario]
        //public void TearDown()
        //{
        //    driver.Close();
        //}


    }
}







