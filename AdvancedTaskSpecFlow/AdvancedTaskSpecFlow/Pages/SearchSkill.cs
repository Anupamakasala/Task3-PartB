using AdvancedTaskSpecFlow.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTaskSpecFlow.Pages
{
    public class SearchSkill :CommonDriver
    {

        IWebElement searchSkillTextbox => driver.FindElement(By.XPath("//div[@class = 'ui small icon input search-box']/input[@placeholder = 'Search skills']"));

        IWebElement searchIcon => driver.FindElement(By.XPath("//div[@class = 'ui small icon input search-box']/i[@class = 'search link icon']"));

        IWebElement allCategories => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[1]/b"));

        IWebElement programmingTech => driver.FindElement(By.XPath("//section[@class='search-results']//div[@class='four wide column']//div[@class='ui link list']/a[7]"));

        IWebElement qa => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[11]"));
        IWebElement searchSkill2 => driver.FindElement(By.XPath("//section[@class='search-results']//div[@class='ui small icon input search-box']//input[@placeholder='Search skills']"));

        IWebElement search2Icon => driver.FindElement(By.XPath(" //section[@class='search-results']/div[@class='ui grid']/div[@class='four wide column']/div[@class='ui small icon input search-box']/i"));
        IWebElement searchByUser => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input"));
        IWebElement searchUserSearchIcon => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[2]/i"));

        IWebElement selectUser => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div[1]/div/span"));
                                                                
        IWebElement refreshIcon => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[3]/div[2]/button/i"));


        IWebElement onlineFilterBtn => driver.FindElement(By.XPath("//section[@class='search-results']//div[@class='four wide column']/div[@class= 'ui buttons']/button[contains(text(),'Online')]"));
        IWebElement onsiteFilterBtn => driver.FindElement(By.XPath("//section[@class='search-results']//div[@class='four wide column']/div[@class= 'ui buttons']/button[contains(text(),'Onsite')]"));
        IWebElement showAllFilterBtn => driver.FindElement(By.XPath("//section[@class='search-results']//div[@class='four wide column']/div[@class= 'ui buttons']/button[contains(text(),'ShowAll')]"));

        IWebElement refineSearch => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/h3"));
        public string waitSearchTextbox1 = "//div[@class = 'ui small icon input search-box']/input[@placeholder = 'Search skills']";


        public string waitBtn1 = "//section[@class='search-results']//div[@class='ui grid']//div[@class='twelve wide column']//div[@class='right floated column ']/button[1]";
        public string waitTextResultsPerPage = "//section[@class='search-results']//div[@class='ui grid']//div[@class='twelve wide column']//div[@class='right floated column ']/text()";
        public string waitPageNo = "//*[@id=\"service-search-section\"]/div[3]/div/section/div/div[2]/div/div[3]/div[2]/div/button[2]";
        public string waitForUser = "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div[1]";
        //Search a Skill
        public void SearchSkillSteps(string Search1)
        {
            //Thread.Sleep(3000);            
            WaitHelpers.WaitToExist(driver, "XPath", waitSearchTextbox1, 20);
            searchSkillTextbox.Click();
            searchSkillTextbox.SendKeys(Search1);

            searchIcon.Click();
            WaitHelpers.WaitToBeVisible(driver, "XPath", waitBtn1, 10);

        }

        

        public void ClickAllCat()
        {

            allCategories.Click();
            WaitHelpers.WaitToExist(driver, "XPath", waitBtn1, 10);
        }

        //Refine the search by a Category
        public void ClickCategory()
        {

            programmingTech.Click();
            WaitHelpers.WaitToExist(driver, "XPath", waitBtn1, 10);
        }

        

        //Refine the search by a Subcategory
        public void ClickSubCategory()
        {

            qa.Click();
            WaitHelpers.WaitToExist(driver, "XPath", waitBtn1, 10);
        }



        //Refine search by username
        public void UserSearch(String user)
        {
            Thread.Sleep(3000);
            searchByUser.Click();
            searchByUser.SendKeys(user);
            WaitHelpers.WaitToExist(driver, "XPath", waitForUser, 10);
            Thread.Sleep(3000);
            selectUser.Click();
            Thread.Sleep(3000);

        }

        //Refresh the search
        public void ClickRefresh()
        {

            refreshIcon.Click();
        }


        //Search a  skill 
        public void ClickSearchSkillInner(string search2)
        {

            searchSkill2.Click();
            searchSkill2.SendKeys(search2);
            search2Icon.Click();
            WaitHelpers.WaitToExist(driver, "XPath", waitBtn1, 10);
        }

        //Refine the search by Filter
        public void Filters()
        {


            onlineFilterBtn.Click();

            WaitHelpers.WaitToExist(driver, "XPath", waitBtn1, 10);

            onsiteFilterBtn.Click();
            WaitHelpers.WaitToExist(driver, "XPath", waitBtn1, 10);

            showAllFilterBtn.Click();
            WaitHelpers.WaitToExist(driver, "XPath", waitBtn1, 10);


        }
        public string VerifySearch()
        {
            string refine = refineSearch.Text;
            return refine;
        }
        public string BoldClickCategory()
        {
            string boldProgrammingTech = programmingTech.GetCssValue("font-weight");

            return boldProgrammingTech;

        }

        public string BoldClickSubCategory()
        {
            string boldQa = qa.GetCssValue("font-weight");

            return boldQa;

        }

       
    }


}

