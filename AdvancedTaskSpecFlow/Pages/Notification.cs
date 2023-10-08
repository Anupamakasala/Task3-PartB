using AdvancedTaskSpecFlow.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskSpecFlow.Pages
{
    public class Notification: CommonDriver

    {

        //Initialize the web elements
        private IWebElement notificationDropdown => driver.FindElement(By.XPath("//i[@class='dropdown icon']"));

        //See all option
        private IWebElement seeAll => driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/div/div/span/div/div[2]/div/center/a"));

        //load more to see all notifications
        private IWebElement LoadMoreText => driver.FindElement(By.XPath("//a[@class='ui button']"));
        // "//a[@class='ui button']"));

        //show less to see less notifications
        private IWebElement ShowLessText => driver.FindElement(By.XPath("//a[@class='ui button'][1]"));
         //   "//html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[9]/div[1]/center/a"));

        //


        //FOr LoadMore Notifications on Page
        public void LoadMoreNotification()
        {
            //Click on notification drop down
            Thread.Sleep(5000);
            notificationDropdown.Click();
        }

        public void SeeAll()
        {
            //Click on see all option
            WaitHelpers.WaitToBeClickable(driver, "XPath", "//html/body/div[1]/div/div[1]/div[2]/div/div/div/span/div/div[2]/div/center/a", 10);
            seeAll.Click();
        }
            

        public void LoadMore()
        {

            //Click on loadMore option to see all the notifications 
            Thread.Sleep(5000);
            LoadMoreText.Click();
            
        }
           
        

        public string GetShowLessText()
        {
            WaitHelpers.WaitToExist(driver,"XPath", "//html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[9]/div[1]/center/a", 10);
            return ShowLessText.Text;
            
        }


        //FOr ShowLessNotifications on Page

        public void ShowLessNotification()
        {
            Thread.Sleep(5000);
            ShowLessText.Click();  
        }

        public string GetLoadMoreText()
        {
            WaitHelpers.WaitToExist(driver, "XPath", "//a[@class='ui button']", 10);
            return LoadMoreText.Text;
            
         
        }
     

    }
}
    
