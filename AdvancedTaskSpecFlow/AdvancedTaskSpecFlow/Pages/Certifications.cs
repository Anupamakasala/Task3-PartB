using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Xml.Linq;
using NUnit.Framework;
using AdvancedTaskSpecFlow.Utilities;

namespace AdvancedTaskSpecFlow.Pages
{
    public class Certifications : CommonDriver
    {
        IWebElement certificationTab => driver.FindElement(By.XPath("//a[contains(text(),'Certifications')]"));
        IWebElement certAddnewButton => driver.FindElement(By.XPath("//div[@data-tab='fourth']/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        IWebElement certificateTextbox => driver.FindElement(By.Name("certificationName"));
        IWebElement certificatefromTextbox => driver.FindElement(By.Name("certificationFrom"));
        IWebElement certificateAddButton => driver.FindElement(By.XPath("//input [@type ='button' and @value='Add']"));       
        IWebElement certificateText => driver.FindElement(By.XPath("//div[@data-tab=\"fourth\"]/div/div/div/table/tbody[last()]/tr/td[1]"));
        IWebElement certificateFromText => driver.FindElement(By.XPath("//div[@class ='form-wrapper']/table/ tbody[last()]/tr/td[2]"));
        IWebElement certificateYearText => driver.FindElement(By.XPath("//div[@class ='form-wrapper']/table/ tbody[last()]/tr/td[3]"));
        IWebElement editCertificateIcon => driver.FindElement(By.XPath("//div[@data-tab='fourth']/div/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]"));
        IWebElement editCertificate => driver.FindElement(By.Name("certificationName"));
        IWebElement editCertificateFrom => driver.FindElement(By.Name("certificationFrom"));
        IWebElement certificateUpdateButton => driver.FindElement(By.XPath("//input[@type='button' and @value='Update']"));
        IWebElement newUpdatedCertificate => driver.FindElement(By.XPath("//div[@data-tab='fourth']/div/div/div/table/tbody[last()]/tr/td[1]"));
        IWebElement deleteCertificateIcon => driver.FindElement(By.XPath("//div[@data-tab='fourth']/div/div[2]/div/table/tbody[last()]/tr/td[4]/span[2]/i"));
        IWebElement deletedCertificateText => driver.FindElement(By.XPath("//div[@class='form-wrapper']/table/tbody[last()]/tr[1]/td[1]"));
        IWebElement msgError1 => driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        //Add Certification            
        public void ClickCertification()
        {
                certificationTab.Click();
                certAddnewButton.Click();

        }

        public void CertificationSteps(string Certificate, string CertificateFrom, string Year)
        {
            certificateTextbox.SendKeys(Certificate);           
            certificatefromTextbox.SendKeys(CertificateFrom);
            SelectElement certificateyear = new SelectElement(driver.FindElement(By.Name("certificationYear")));
            certificateyear.SelectByValue(Year);
                   
            certificateAddButton.Click();
            //Wait.WaitToBeVisible(driver, "XPath", "//div[@class ='form-wrapper']/table/tbody[last()]/tr/td[1]",10);
            Thread.Sleep(3000);
        }

        public string GetCertificate()
        {
            Thread.Sleep(6000);
            return certificateText.Text;
            
        }

        //Update Certificate Record
        public void UpdateCertificateClick()

        {
            certificationTab.Click();

            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@data-tab='fourth']/div/div/div/table/tbody[last()]/tr/td[1]", 10);

            editCertificateIcon.Click();
        }
        public void UpdateCertificateDetails(string Certificate, string CertificateFrom, string Year)
        {
            editCertificate.Clear();

            editCertificate.SendKeys(Certificate);

            editCertificateFrom.Clear();

            editCertificateFrom.SendKeys(CertificateFrom);

            SelectElement editCertificateyear = new SelectElement(driver.FindElement(By.Name("certificationYear")));

            editCertificateyear.SelectByValue(Year);
        }
        public void UpdateCertificate()
        { 
            certificateUpdateButton.Click();

            WaitHelpers.WaitToBeVisible(driver, "XPath", "//div[@data-tab='fourth']/div/div/div/table/tbody[last()]/tr/td[1]", 10);
        }

        public string GetUpdatedCertificate()
        {
            Thread.Sleep(5000);                      
            return newUpdatedCertificate.Text;
        }

        public void DeleteCertificate(string Certificate)
        {
            certificationTab.Click();
            WaitHelpers.WaitToExist(driver, "XPath", "//div[@class='form-wrapper']/table/ tbody/tr/td[1]", 10);           
            deleteCertificateIcon.Click();
            Thread.Sleep(5000);
        }

        public string GetDeleteCertificate()
        {
            
            return deletedCertificateText.Text;         

        }


        public string InvalidCert()
        {
            return msgError1.Text;
        }



    }
}
