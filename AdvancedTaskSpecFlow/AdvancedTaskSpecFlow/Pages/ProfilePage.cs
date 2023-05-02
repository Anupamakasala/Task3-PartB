using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedTaskSpecFlow.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AdvancedTaskSpecFlow.Pages
{
    public class ProfilePage
    {
        public void VerifyProfilePage(IWebDriver driver)
        {

            // navigate to profile page and check if user has logged in Successfully
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span", 5);
            IWebElement hiAnupama = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));

            Assert.That(hiAnupama.Text == "Hi Anupama", "login failed, Test failed");

        }

        public void ClickOnPencilIconNextToDescriptionField(IWebDriver driver)
        {
            IWebElement editDescription = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span"));
            editDescription.Click();

        }

        public void EnterTextInDescriptionTextBox(IWebDriver driver)
        {
            IWebElement descriptionTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            descriptionTextBox.SendKeys("I am a Test Analyst");

        }

        public void ClickOnTheSaveButton(IWebDriver driver)
        {
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveButton.Click();

        }

        public void DescriptionDetailsSaved(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement viewDescription = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            Assert.That(viewDescription.Text == "I am a Test Analyst");

        }
        public void ClickOnHiFirstName(IWebDriver driver)
        {


            IWebElement clickProfileName = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
            clickProfileName.Click();

        }
        public void ClickOnChangePassword(IWebDriver driver)
        {
            IWebElement changePassword = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[2]"));
            changePassword.Click();

        }
        public void EnterCurrentPasswordNewPasswordConfirmPassword(IWebDriver driver)
        {
            IWebElement currentPassword = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[1]/input"));
            currentPassword.SendKeys("");
            IWebElement newPassword = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[2]/input"));
            newPassword.SendKeys("");
            IWebElement confirmPassword = driver.FindElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[3]/input"));
            confirmPassword.SendKeys("");

        }
        public void NewPasswordDetailsSaved(IWebDriver driver)
        {
            IWebElement passwordSaved = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            Assert.That(passwordSaved.Text == "Password Changed Successfully");

        }
        public void ClickOnManageRequestsTab(IWebDriver driver)
        {
            IWebElement manageRequestsTab = driver.FindElement(By.XPath("//*[@id=\"sent-request-section\"]/section[1]/div/div[1]"));
            manageRequestsTab.Click();
        }

        public void ClickOnReceivedRequests(IWebDriver driver)
        {
            IWebElement receivedRequests = driver.FindElement(By.XPath("//*[@id=\"sent-request-section\"]/section[1]/div/div[1]/div/a[1]"));
            receivedRequests.Click();
        }
        public void VerifyReceivedRequestsPage(IWebDriver driver)
        {
            IWebElement receivedRequestsBody = driver.FindElement(By.XPath("//*[@id=\"received-request-section\"]/div[2]/h3"));
            receivedRequestsBody.Click();
        }

        public void ClickOnSentRequests(IWebDriver driver)
        {
            IWebElement sentRequests = driver.FindElement(By.XPath("//*[@id=\"sent-request-section\"]/section[1]/div/div[1]/div/a[2]"));
            sentRequests.Click();
        }
        public void VerifySentRequestsPage(IWebDriver driver)
        {
            IWebElement sentRequestsBody = driver.FindElement(By.XPath("//*[@id=\"sent-request-section\"]/div[2]/h3"));
            sentRequestsBody.Click();
        }
    }
}