using AdvancedTaskSpecFlow.Utilities;
using OpenQA.Selenium;


namespace AdvancedTaskSpecFlow.Pages
{
    public class Notifications:CommonDriver
    {

            public static IWebElement notificationTab => driver.FindElement(By.XPath("//div[1]/div[2]/div/div"));
            public static IWebElement seeAllElement => driver.FindElement(By.XPath("//a[@href='/Account/Dashboard']"));
            public static IWebElement checkBox => driver.FindElement(By.XPath("//input[@type='checkbox']"));
            public static IWebElement deleteIcon => driver.FindElement(By.XPath("//div[@data-tooltip='Delete selection']"));
            public static IWebElement selectAllIcon => driver.FindElement(By.XPath("//i[@class='mouse pointer icon']"));
            public static IWebElement markAsReadIcon => driver.FindElement(By.XPath("//i[@class='check square icon']"));

           
        
            public void GoToNotification()
            {
            //WaitHelpers.WaitToExist(driver, "XPath", "//div[1]/div[2]/div/div", 10);
            Thread.Sleep(3000);
            notificationTab.Click();

            }
            public void MarkAsRead()
            {
            
            // WaitHelpers.WaitToExist(driver, "XPath", "//a[@href='/Account/Dashboard']", 10);
                Thread.Sleep(2000);
                seeAllElement.Click();
                //WaitHelpers.WaitToExist(driver, "XPath", "//i[@class='mouse pointer icon']", 10);
                Thread.Sleep(2000);
                selectAllIcon.Click();
                markAsReadIcon.Click();
                driver.Navigate().Refresh();
                             
            }

            public string GetNotification()
            {

                WaitHelpers.WaitToExist(driver, "XPath", " //div[@class='item link']", 10);
                var HighlightedText = driver.FindElement(By.XPath(" //div[@class='item link']")).GetCssValue("font-weight");
                return HighlightedText;

            }

            public void DeleteNotification()
            {
                Thread.Sleep(3000);
                notificationTab.Click();
                Thread.Sleep(3000);
                //WaitHelpers.WaitToExist(driver, "XPath", "//a[@href='/Account/Dashboard']", 10);
                seeAllElement.Click();
                WaitHelpers.WaitToExist(driver, "XPath", "//input[@type='checkbox']", 10);
                selectAllIcon.Click();
                deleteIcon.Click();
                driver.Navigate().Refresh();
              
            }

            public string GetDeletedNotification()
            {
            WaitHelpers.WaitToExist(driver, "XPath", "//div[2]/div/div/div[3]/div[2]/span/div", 10);
            var NotificationText = driver.FindElement(By.XPath("//div[2]/div/div/div[3]/div[2]/span/div")).Text;
            Console.WriteLine(NotificationText);
            return NotificationText;
            }

    }
}
