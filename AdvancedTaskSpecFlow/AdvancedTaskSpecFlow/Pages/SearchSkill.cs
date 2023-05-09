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

        IWebElement SearchSkillTextbox => driver.FindElement(By.XPath("//div[@class = 'ui small icon input search-box']/input[@placeholder = 'Search skills']"));

        IWebElement SearchIcon => driver.FindElement(By.XPath("//div[@class = 'ui small icon input search-box']/i[@class = 'search link icon']"));

        IWebElement AllCategories => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[1]/b"));

        IWebElement ProgrammingTech => driver.FindElement(By.XPath("//section[@class='search-results']//div[@class='four wide column']//div[@class='ui link list']/a[7]"));

        IWebElement Qa => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/div/a[11]"));

        //IWebElement SearchUser => driver.FindElement(By.XPath("//div[@class='ui search']/div[@class='ui icon input fluid']/input[@placeholder ='Search user']"));
        //IWebElement SearchUser => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[3]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input"));


        IWebElement SearchSkill2 => driver.FindElement(By.XPath("//section[@class='search-results']//div[@class='ui small icon input search-box']//input[@placeholder='Search skills']"));

        IWebElement Search2Icon => driver.FindElement(By.XPath(" //section[@class='search-results']/div[@class='ui grid']/div[@class='four wide column']/div[@class='ui small icon input search-box']/i"));
        IWebElement SearchByUser => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[1]/input"));
        IWebElement SearchUserSearchIcon => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[2]/i"));

        IWebElement SelectUser => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div[1]/div/span"));
                                                                
        IWebElement RefreshIcon => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[3]/div[2]/button/i"));


        IWebElement OnlineFilterBtn => driver.FindElement(By.XPath("//section[@class='search-results']//div[@class='four wide column']/div[@class= 'ui buttons']/button[contains(text(),'Online')]"));
        IWebElement OnsiteFilterBtn => driver.FindElement(By.XPath("//section[@class='search-results']//div[@class='four wide column']/div[@class= 'ui buttons']/button[contains(text(),'Onsite')]"));
        IWebElement ShowAllFilterBtn => driver.FindElement(By.XPath("//section[@class='search-results']//div[@class='four wide column']/div[@class= 'ui buttons']/button[contains(text(),'ShowAll')]"));

        IWebElement RefineSearch => driver.FindElement(By.XPath("//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[1]/h3"));
        public string WaitSearchTextbox1 = "//div[@class = 'ui small icon input search-box']/input[@placeholder = 'Search skills']";


        public string WaitBtn1 = "//section[@class='search-results']//div[@class='ui grid']//div[@class='twelve wide column']//div[@class='right floated column ']/button[1]";
        public string WaitTextResultsPerPage = "//section[@class='search-results']//div[@class='ui grid']//div[@class='twelve wide column']//div[@class='right floated column ']/text()";
        public string WaitPageNo = "//*[@id=\"service-search-section\"]/div[3]/div/section/div/div[2]/div/div[3]/div[2]/div/button[2]";
        public string WaitForUser = "//*[@id=\"service-search-section\"]/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div[1]";
        //Search a Skill
        public void SearchSkillSteps(string Search1)
        {
            //Thread.Sleep(3000);            
            WaitHelpers.WaitToExist(driver, "XPath", WaitSearchTextbox1, 20);
            SearchSkillTextbox.Click();
            SearchSkillTextbox.SendKeys(Search1);

            SearchIcon.Click();
            WaitHelpers.WaitToBeVisible(driver, "XPath", WaitBtn1, 10);

        }

        

        public void ClickAllCat()
        {

            AllCategories.Click();
            WaitHelpers.WaitToExist(driver, "XPath", WaitBtn1, 10);
        }

        //Refine the search by a Category
        public void ClickCategory()
        {

            ProgrammingTech.Click();
            WaitHelpers.WaitToExist(driver, "XPath", WaitBtn1, 10);
        }

        

        //Refine the search by a Subcategory
        public void ClickSubCategory()
        {

            Qa.Click();
            WaitHelpers.WaitToExist(driver, "XPath", WaitBtn1, 10);
        }



        //Refine search by username
        public void UserSearch(String User)
        {
            Thread.Sleep(3000);
            SearchByUser.Click();
            SearchByUser.SendKeys(User);
            WaitHelpers.WaitToExist(driver, "XPath", WaitForUser, 10);
            Thread.Sleep(3000);
            SelectUser.Click();
            Thread.Sleep(3000);

        }

        //Refresh the search
        public void ClickRefresh()
        {

            RefreshIcon.Click();
        }


        //Search a  skill 
        public void ClickSearchSkillInner(string Search2)
        {

            SearchSkill2.Click();
            SearchSkill2.SendKeys(Search2);
            Search2Icon.Click();
            WaitHelpers.WaitToExist(driver, "XPath", WaitBtn1, 10);
        }

        //Refine the search by Filter
        public void Filters()
        {


            OnlineFilterBtn.Click();

            WaitHelpers.WaitToExist(driver, "XPath", WaitBtn1, 10);

            OnsiteFilterBtn.Click();
            WaitHelpers.WaitToExist(driver, "XPath", WaitBtn1, 10);

            ShowAllFilterBtn.Click();
            WaitHelpers.WaitToExist(driver, "XPath", WaitBtn1, 10);


        }
        public string VerifySearch()
        {
            string refine = RefineSearch.Text;
            return refine;
        }
        public string BoldClickCategory()
        {
            string BoldProgrammingTech = ProgrammingTech.GetCssValue("font-weight");

            return BoldProgrammingTech;

        }

        public string BoldClickSubCategory()
        {
            string BoldQa = Qa.GetCssValue("font-weight");

            return BoldQa;

        }

        //public void Message()
        //{
        //    Console.WriteLine("Search Skill test Passed");
        //}


    }


}

