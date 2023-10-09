using AdvancedTaskSpecFlow.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AdvancedTaskSpecFlow.Pages
{
    

    
    internal  class LoginPage : CommonDriver
    {

        private IWebElement SignIn => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div[1]/div/a"));
        
        // Finding the Email Field
        private IWebElement Email => driver.FindElement(By.Name("email"));

        //Finding the Password Field
        private IWebElement Password => driver.FindElement(By.Name("password"));

        //Tick the CheckBox Remember me
        private IWebElement Checkbox => driver.FindElement(By.XPath("//input[@name='rememberDetails']"));

        //Finding the Login Button
        private IWebElement LoginBtn => driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));




        public void LoginSteps()
        {
            //driver.Navigate().GoToUrl("http://localhost:5000/Home");
            //driver.Manage().Window.Maximize();
            SignIn.Click();
            Email.SendKeys("rana.akash101@gmail.com");
            Password.SendKeys("9418535907");
            Checkbox.Click();
            LoginBtn.Click();
        }


        public void ClickonSignin()
            {
                //Click on Signin button
                WaitHelpers.WaitToBeClickable(driver,"XPath", "/html/body/div/div/div/div/div/div[1]/div/a", 10);
                SignIn.Click();
            }
         
        public void Entercredentials(string emailaddress, string password)
        {
            //Enter email
            Email.SendKeys(emailaddress);

            //Enter password
            Password.SendKeys(password);

            //Click the RememberMe Checkbox
            Checkbox.Click();
        }
           
        



        public void LoginButton()
        {
            //Click Login button
            LoginBtn.Click();

        }

        public string GetName()

        {
          
            WaitHelpers.WaitToExist(driver, "XPath", "/ html / body / div[1] / div / div[1] / div[2] / div / span", 10);
            IWebElement newName = driver.FindElement(By.XPath("/ html / body / div[1] / div / div[1] / div[2] / div / span"));
            return newName.Text;
            Thread.Sleep(4000);
             
            ////span[@class='item ui dropdown link']
        }


    }

       
    }



    

       

