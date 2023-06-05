using AdvancedTaskSpecFlow.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskSpecFlow.Pages
{
    public class NotificationMoreAndLess: CommonDriver

    {

        //Initialize the web elements
        private IWebElement notificationDropdown => driver.FindElement(By.XPath("//i[@class='dropdown icon']"));

        //See all option
        private IWebElement seeAll => driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div[2]/div/div/div/span/div/div[2]/div/center/a"));

        //load more to see all notifications
        private IWebElement LoadMore => driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a"));


        ////a[@class='ui button']
        //show less to see less notifications
        private IWebElement ShowLess => driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[9]/div[1]/center/a"));




        public void LoadMoreNotification(IWebDriver driver)
        {

            //Click on notification drop down
            Thread.Sleep(5000);
            notificationDropdown.Click();

            //Click on see all option
            WaitHelpers.WaitToBeClickable(driver, "XPath", "/html/body/div[1]/div/div[1]/div[2]/div/div/div/span/div/div[2]/div/center/a", 10);
            seeAll.Click();

            //Click on loadMore option to see all the notifications 
            //wait(2);
            Thread.Sleep(9000);
            LoadMore.Click();
            Thread.Sleep(5000);
        }

      




        public void ShowLessNotification(IWebDriver driver)
        {

            //Click on showless option to see onlylatest notifications
            Thread.Sleep(9000);
            ShowLess.Click();
            
        }
     

    }
}
    
