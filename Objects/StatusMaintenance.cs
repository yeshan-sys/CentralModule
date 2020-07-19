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
    class StatusMaintenance
    {
        public StatusMaintenance()
        {
            PageFactory.InitElements(WebDriver.driver, this);

        }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-status-maintenance/div/div[1]/div/div/div[1]/span/p-dropdown/div/div[4]/span")]
        public IWebElement dpdIdentificationType { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-status-maintenance/div/div[1]/div/div/div[2]/span/input")]
        public IWebElement txtSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-status-maintenance/div/div[1]/div/div/div[3]/button[1]")]
        public IWebElement btnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-status-maintenance/div/div[1]/div/div/div[3]/button[3]")]
        public IWebElement btnChangeStatus { get; set; }

        // Pop up Elements 
        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-status-maintenance/div/div[2]/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/app-add-change-status/div[1]/div[1]/div[1]/span/p-dropdown")]
        public IWebElement dpdStatusType { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-status-maintenance/div/div[2]/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/app-add-change-status/div[1]/div[1]/div[2]/span/p-dropdown")]
        public IWebElement dpdBSPStatus { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-status-maintenance/div/div[2]/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/app-add-change-status/div[1]/div[1]/div[3]/span/textarea")]
        public IWebElement txtDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-status-maintenance/div/div[2]/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/app-add-change-status/div[1]/div[1]/div[4]/span/p-calendar")]
        public IWebElement ExpiryDate { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-status-maintenance/div/div[2]/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/app-add-change-status/div[1]/div[1]/div[4]/span/p-calendar/span/div/div/div[1]/div/select[1]")]
        public IWebElement CalenderMonth { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-status-maintenance/div/div[2]/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/app-add-change-status/div[1]/div[1]/div[4]/span/p-calendar/span/div/div/div[1]/div/select[2]")]
        public IWebElement CalenderYear { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-status-maintenance/div/div[2]/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/app-add-change-status/div[1]/div[1]/div[4]/span/p-calendar/span/div/div/div[2]/table/tbody/tr[3]/td[4]/a")]
        public IWebElement CalenderDay { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-status-maintenance/div/div[2]/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/app-add-change-status/div[1]/div[2]/div/p-fileupload/div/div[1]/span/input")]
        public IWebElement FileChoose { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-status-maintenance/div/div[2]/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/app-add-change-status/div[3]/div/button[2]")]
        public IWebElement btnSave { get; set; }



        public void SearchForChangeStatus(string nic)
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(3000);
            dpdIdentificationType.ButtonClick();
            Actions NicNo = new Actions(WebDriver.driver);
            NicNo.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(2000);
            
            txtSearch.EnterText(nic);
            Thread.Sleep(2000);

            btnSearch.ButtonClick();
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(6000);

            btnChangeStatus.ButtonClick();
            Thread.Sleep(3000);
        }
        public void ChangeStatus(string description, string attach)
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            dpdStatusType.ButtonClick();
            Actions acc = new Actions(WebDriver.driver);
            acc.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            dpdBSPStatus.ButtonClick();
            acc.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            txtDescription.EnterText(description);
            Thread.Sleep(2000);

            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            ExpiryDate.ButtonClick();
            CalenderMonth.ButtonClick();
            acc.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(1000);
            CalenderYear.ButtonClick();
            acc.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(1000);
            CalenderDay.ButtonClick();
            Thread.Sleep(2000);

            FileChoose.EnterText(attach);
            Thread.Sleep(3000);          
        }

        public void SaveStatus()
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            btnSave.ButtonClick();
            Thread.Sleep(3000);
        }

    }
}
