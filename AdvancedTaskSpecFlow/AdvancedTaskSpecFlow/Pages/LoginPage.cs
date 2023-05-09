using AdvancedTaskSpecFlow.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AdvancedTaskSpecFlow.Pages
{

    public class LoginPage : CommonDriver
    {

        IWebElement SignInButton => driver.FindElement(By.XPath("//a[@class='item']"));
        IWebElement UserNameTextbox => driver.FindElement(By.Name("email"));
        IWebElement PasswordTextbox => driver.FindElement(By.XPath("//input[@type='password']"));
        IWebElement LoginButton => driver.FindElement(By.XPath("//button[@class='fluid ui teal button'][text()='Login']"));
        public void LoginSteps()
        {

            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
            //ImpliWait();

            //Login                       
            SignInButton.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//input[@type='text'and @name='email']", 3);

            UserNameTextbox.SendKeys("poojasaini31@gmail.com");
            PasswordTextbox.SendKeys("Testing");
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//BUTTON[@class='fluid ui teal button'][text()='Login']", 5);
            LoginButton.Click();
            WaitHelpers.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span", 10);

        }
    }
}
       

