﻿using AdvancedTaskSpecFlow.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskSpecFlow.Pages
{
    internal class SignUp: CommonDriver

    { 
        
        //Finding the Join 
        private IWebElement Join => driver.FindElement(By.XPath("//button[@class='ui green basic button']"));

        //Identify FirstName Textbox
        private IWebElement FirstName => driver.FindElement(By.Name("firstName"));

        //Identify LastName Textbox
        private IWebElement LastName => driver.FindElement(By.Name("lastName"));

        //Identify Email Textbox
        private IWebElement Email => driver.FindElement(By.Name("email"));

        //Identify Password Textbox
        private IWebElement Password => driver.FindElement(By.XPath("//input[@name='password']"));

        //Identify Confirm Password Textbox
        private IWebElement ConfirmPassword => driver.FindElement(By.XPath("//input[@name='confirmPassword']"));

        //Identify Term and Conditions Checkbox
        private IWebElement Checkbox => driver.FindElement(By.XPath("//input[@type='checkbox']"));

        //Identify join button
        private IWebElement JoinBtn => driver.FindElement(By.Id("submit-btn"));





        public void Register()
        {

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");


            //Click on Join button
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//button[@class='ui green basic button']", 10);
            Join.Click();
        }

        public void SignupCredentials(string firstname, string lastname, string emailaddress, string password, string confirmpassword)
        {
            //Enter FirstName
            FirstName.SendKeys(firstname);

            //Enter LastName
            LastName.SendKeys(lastname);

            //Enter Email
            Email.SendKeys(emailaddress);

            //Enter Password
            Password.SendKeys(password);

            //Enter Password again to confirm
            ConfirmPassword.SendKeys(confirmpassword);

        }
        public void CheckBoxButton()
        {
            //Click on Checkbox
            Checkbox.Click();
        }

          

        public void JoinButton()
        {

            //Click on join button to Sign Up
            JoinBtn.Click();
            Thread.Sleep(5000);
        }
            

        
        public string GetPopUpMessage()
        {
            WaitHelpers.WaitToExist(driver, "XPath", "/html/body/div[1]/div", 10);
            IWebElement registrationSuccessfulPopUpMessage = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            return registrationSuccessfulPopUpMessage.Text;

        }


    }
}
    