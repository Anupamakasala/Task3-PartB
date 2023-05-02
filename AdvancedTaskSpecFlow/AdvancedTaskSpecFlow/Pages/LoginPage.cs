using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AdvancedTaskSpecFlow.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {

            // maximise window
            driver.Manage().Window.Maximize();

            // launch turn up portal
            driver.Navigate().GoToUrl("http://localhost:5000");

            // identify Sign In button
            IWebElement signIn = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signIn.Click();

            try
            {
                // identify username textbox and enter valid username
                IWebElement userName = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                userName.SendKeys("anupama.kasala@gmail.com");

                // identify password textbox and enter valid password
                IWebElement password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                password.SendKeys("Brio@123");

                // identify login button and click
                IWebElement login = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                login.Click();

            }
            catch (Exception ex)
            {
                Assert.Fail("Mars portal page did not launch");
            }

        }
    }
}