using CentralModule.GetSet;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CentralModule.Objects
{
    class Navigation
    {
        public  Navigation()
        {
            PageFactory.InitElements(WebDriver.driver, this);
        }

        //Navigation of Central

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-menu/aside/p-scrollpanel/div/div[1]/div/eclipse-menu/p-panelmenu/div/div[3]/div[1]/a/span[2]")]
        public IWebElement btnDropdownBusinessPartner { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-menu/aside/p-scrollpanel/div/div[1]/div/eclipse-menu/p-panelmenu/div/div[3]/div[2]/div/p-panelmenusub/ul/li[1]/a/span[2]")]  
        public IWebElement btnCustomerCreation { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-menu/aside/p-scrollpanel/div/div[1]/div/eclipse-menu/p-panelmenu/div/div[3]/div[2]/div/p-panelmenusub/ul/li[2]/a/span[2]")]
        public IWebElement btnCustomerInquiry { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-menu/aside/p-scrollpanel/div/div[1]/div/eclipse-menu/p-panelmenu/div/div[3]/div[2]/div/p-panelmenusub/ul/li[3]/a/span[2]")]
        public IWebElement btnStatusMaintainance { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-menu/aside/p-scrollpanel/div/div[1]/div/eclipse-menu/p-panelmenu/div/div[3]/div[2]/div/p-panelmenusub/ul/li[4]/a")]
        public IWebElement btnCompanyRegistration { get; set; }


        //Navigation of WorkBench

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-menu/aside/p-scrollpanel/div/div[1]/div/eclipse-menu/p-dropdown/div")]
        public IWebElement dpdModule { get; set; }            

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-menu/aside/p-scrollpanel/div/div[1]/div/eclipse-menu/p-panelmenu/div/div[1]/div/a")]
        public IWebElement btnCompletedActivity { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-menu/aside/p-scrollpanel/div/div[1]/div/eclipse-menu/p-panelmenu/div/div[3]/div/a")]
        public IWebElement btnIncompletedActivity { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-menu/aside/p-scrollpanel/div/div[1]/div/eclipse-menu/p-panelmenu/div/div[2]/div/a")]
        public IWebElement btnApproval { get; set; }

        //Navigate of Note Maintenance

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-menu/aside/p-scrollpanel/div/div[1]/div/eclipse-menu/p-panelmenu/div/div[1]/div/a/span[2]")]
        public IWebElement btnNoteMaintenance { get; set; }

        


        public void CustomerCreation()
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(2000);
            btnDropdownBusinessPartner.ButtonClick();
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(2000);
            btnCustomerCreation.ButtonClick();
            Thread.Sleep(3000);
            // return new BusinessPartnerCreationFirstPageObjects();
        }
        public void CustomerInquiry()
        {            
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(5000);
            btnDropdownBusinessPartner.ButtonClick();          
            Thread.Sleep(3000);
            btnCustomerInquiry.ButtonClick();
            Thread.Sleep(3000);
            // return new BusinessPartnerUpdateMainPageObjects();
        }
        public void WorkBenchCompleted()
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(2000);
            dpdModule.ButtonClick();
            Thread.Sleep(4000);
            Actions workbench = new Actions(WebDriver.driver);
            workbench.SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(3000);
            btnCompletedActivity.ButtonClick();
            Thread.Sleep(5000);
        }
        public void WorkBenchIncompleted()
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(2000);        
            dpdModule.ButtonClick();
            Actions workbench = new Actions(WebDriver.driver);
            workbench.SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(3000);
            btnIncompletedActivity.ButtonClick();
            Thread.Sleep(5000);
        }
        public void WorkBenchApproval()
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(2000);
            dpdModule.ButtonClick();
            Actions workbench = new Actions(WebDriver.driver);
            workbench.SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(3000);
            btnApproval.ButtonClick();
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(5000);
        }
        public void StatusMaintainance()
        {           
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(5000);
            btnDropdownBusinessPartner.ButtonClick();
            Thread.Sleep(3000);
            btnStatusMaintainance.ButtonClick();
            Thread.Sleep(3000);
        }

        public void NoteMaintenance()
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(2000);
            btnNoteMaintenance.ButtonClick();
            Thread.Sleep(3000);
        }

        public void CompletedCentral()
        {           
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(2000);
            dpdModule.ButtonClick();
            Thread.Sleep(2000);
            Actions workbench = new Actions(WebDriver.driver);
            workbench.SendKeys(Keys.Enter).Perform();
            Thread.Sleep(3000);
            btnCompletedActivity.ButtonClick();
            Thread.Sleep(5000);
        }

        public void CompanyCreation()
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(2000);
            btnDropdownBusinessPartner.ButtonClick();
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(2000);
            btnCompanyRegistration.ButtonClick();
            Thread.Sleep(3000);
        }
    }
}
