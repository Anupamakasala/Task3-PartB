using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedTaskSpecFlow.Utilities;
using NUnit.Framework;



namespace AdvancedTaskSpecFlow.Pages
{
    public class Skills :CommonDriver
    {
        IWebElement skillTab => driver.FindElement(By.XPath("//a[contains(text(),'Skills')]"));        
        IWebElement skillAddButton => driver.FindElement(By.XPath("//div[@data-tab='second']/div/div[2]/div/table/thead/tr/th[3]/div"));
        IWebElement skillTextbox => driver.FindElement(By.Name("name"));
        IWebElement skillAdd => driver.FindElement(By.XPath("//input [@type ='button' and @value='Add']"));        
        IWebElement newskill => driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody[last()]/tr/td[1]"));        
        IWebElement newSkillLevel => driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody[last()]/tr/td[2]"));        
        IWebElement editSkillIcon => driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody[last()]/tr/td[3]/span[1]/i"));
        IWebElement editSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        IWebElement skillUpdateButton => driver.FindElement(By.XPath("//input[@type='button' and @value='Update']"));
        IWebElement newUpdatedskill => driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody[last()]/tr/td[1]"));
        IWebElement newUpdatedSkillLevel => driver.FindElement(By.XPath("//div[@data-tab='second']//table/tbody[last()]/tr/td[2]"));
        IWebElement deleteSkillIcon => driver.FindElement(By.XPath("//div[@data-tab='second']/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i"));
        IWebElement deletedSkill => driver.FindElement(By.XPath("//div[@class='form-wrapper']/table/tbody[last()]/tr[1]/td[1]"));

        //Wait for the AddNew button to be clickable
        public string wait0 = "//div[@data-tab='second']/div/div[2]/div/table/thead/tr/th[3]/div";
        //Wait for the textbox to be clickable
        public string wait1 = "//div[@data-tab='second']/div/div[2]/div/div/div[1]/input";
        //Wait for the text to exist
        public string wait2 = "//div[@data-tab='second']//table/tbody/tr/td[1]";
        //Wait for Delete icon to be clickable
        public string wait3 = "//div[@data-tab='second']//table/tbody/tr/td[3]/span[2]/i";       


        public void SkillsClick()
        {
            skillTab.Click();
            //WaitHelpers.WaitToBeVisible(driver, "XPath", "wait0", 5);
            skillAddButton.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", wait1, 5);
        }
        public void SkillsSteps(string skill, string level)

        {
            //ADD Skills              
            
            skillTextbox.SendKeys(skill);
            SelectElement skillLevel = new SelectElement(driver.FindElement(By.Name("level")));
            skillLevel.SelectByValue(level);            
        }
        public void SkillsAdd()
        {
            skillAdd.Click();
            WaitHelpers.WaitToExist(driver, "XPath", wait2, 10);
            Thread.Sleep(3000);
        }
        public string GetSkill(string skill)
        {            
            return newskill.Text;
        }
        public string GetSkillLevel(string level)
        {           
            return newSkillLevel.Text;
        }

        //UPDATE Skill
        public void UpdateSkillsClick()
        {
            skillTab.Click();
            editSkillIcon.Click();
        }
        public void UpdateSkills(string skill, string level)
        {

            editSkill.Clear();
            editSkill.SendKeys(skill);

            SelectElement editSkillLevel = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select")));
            editSkillLevel.SelectByValue(level);
        }
        public void UpdateSkillsButton()
        {
            skillUpdateButton.Click();
            Thread.Sleep(3000);
        }

        public string GetUpdatedSkill()
        {        
             return newUpdatedskill.Text;
        }
        public string GetUpdatedSkillLevel()
        {
            
            return newUpdatedSkillLevel.Text;
        }

        //DELETE SKILL
        public void DeleteSkills(string skill)

        {           
            skillTab.Click();
            WaitHelpers.WaitToBeClickable(driver, "XPath", wait3, 5);
            deleteSkillIcon.Click();
            Thread.Sleep(3000);
        }

        //Validate Deleted Skill

        public string GetDeleteSkills()
        {                       
            return deletedSkill.Text;          
            
        }
    }
}
