using CentralModule.GetSet;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CentralModule.Objects
{
    class WorkBench
    {
        public WorkBench()
        {
            PageFactory.InitElements(WebDriver.driver, this);

        }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/complete-activities/div/div/p-tabview/div/div/p-tabpanel[1]/div/p-table/div/div[2]/table/tbody/tr[1]/td[1]")]
        public IWebElement bspIdRefNo { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/complete-activities/div/div/p-tabview/div/div/p-tabpanel[1]/div/p-table/div/div[2]/table/tbody/tr[1]/td[8]/a/span")]
        public IWebElement btnActionCompleted { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/incomplete-activities/div/div/p-tabview/div/div/p-table/div/div[2]/table/tbody/tr[1]/td[8]/a/span")]
        public IWebElement btnActionIncomplted { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-approvals/div/div/p-tabview/div/div/p-tabpanel[1]/div/p-table/div/div[2]/table/tbody/tr/td[10]/a/span")]
        public IWebElement btnActionApproval { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-inquiry/div/div/div[1]/form/div[2]/div/div[1]/span/input")]
        public IWebElement txtNic { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/incomplete-activities/summary-popup/p-dialog/div/div[2]/div[2]/p-scrollpanel/div/div[1]/div/div/span[2]/business-partner-info/div/div/div/div[2]/eclipse-bsp-card/p-card/div/div/div/div/div[2]/div[2]/div[1]/div[1]/div/h6[2]")]
        public IWebElement bspRef { get; set; }

        // Central Approval - Customer Inquiry Page Objects for Approve the Business partner

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-inquiry/div/div/div[1]/form/div[2]/div/div[2]/button[3]/span[2]")]
        public IWebElement btnApproveReject { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-inquiry/div/p-dialog/div/div[2]/div[1]/div[1]/p-checkbox/div/div[2]")]
        public IWebElement chkbxSelect { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-inquiry/div/p-dialog/div/div[2]/div[1]/div[2]/textarea")]
        public IWebElement txtComment { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/incomplete-activities/div/div/p-tabview/div/div/p-table/div/div[1]/div[1]/div/input")]
        public IWebElement txtGlobalFilter { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-approvals/div/div/p-tabview/div/div/p-tabpanel[1]/div/p-table/div/div[1]/div[1]/div/input")]
        public IWebElement txtGlobalFilterApproval { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/complete-activities/div/div/p-tabview/div/div/p-tabpanel[1]/div/p-table/div/div[1]/div[1]/div/input")]
        public IWebElement txtGlobalFilterCompleted { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-inquiry/div/p-dialog/div/div[2]/div[2]/div/button[2]")]
        public IWebElement btnApprove { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-inquiry/p-confirmdialog[1]/div/div[3]/p-footer/button")]
        public IWebElement btnOk { get; set; }

        //Status Maintenance 

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-approvals/summary-popup/p-dialog/div/div[2]/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div[1]/div/span/input")]
        public IWebElement txtCommentStatus { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-approvals/summary-popup/p-dialog/div/div[2]/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div[2]/div/p-checkbox/div/div[2]/span")]
        public IWebElement chkApprove { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-approvals/summary-popup/p-dialog/div/div[2]/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div[3]/div/button[1]/span[2]")]
        public IWebElement btnApproveStatus { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/incomplete-activities/summary-popup/p-dialog/div/div[1]/a[1]/span")]
        public IWebElement btnPopupClose { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/complete-activities/summary-popup/p-dialog/div/div[1]/a[1]/span")]
        public IWebElement btnPopupCompleted { get; set; }


        public void GetBspId(string nic)
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            DBConnection con = new DBConnection();
            con.SQLConnectionDetails();
            /*
             * *********************************
             * msd.BusinessPartner Table details
             * *********************************
             */
            con.query = "SELECT Code FROM msd.BusinessPartner " +
                                       "WHERE NICNo ='" + nic + "'";
            con.DataAdapterDetails();
            string code = con.RowsValue(0, 0);
            txtGlobalFilterCompleted.EnterText(code);
            Thread.Sleep(2000);

            btnActionCompleted.ButtonClick();
            Thread.Sleep(3000);
            WebDriver.driver.SwitchTo().Window(WebDriver.driver.WindowHandles.Last());
            Thread.Sleep(2000);
            string nicNo = txtNic.GetText();
            Thread.Sleep(1000);
            if (nicNo == nic)
            {
                Console.WriteLine("Business Partner Details are displayed on Completed activities in Workbench");
            }
            else
            {
                Console.WriteLine("Business Partner Details are not displayed on Completed activities in workbench");
            }
        }
        public void CheckIncompletedBusinessPartner(string nic)
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(3000);
            //bspRef.
            WebDriver.driver.SwitchTo().Window(WebDriver.driver.WindowHandles.Last());
            DBConnection con = new DBConnection();

            con.SQLConnectionDetails();
            /*
             * *********************************
             * msd.BusinessPartner Table details
             * *********************************
             */
            con.query = "SELECT Code FROM msd.BusinessPartner " +
                                       "WHERE NICNo ='" + nic + "'";
            con.DataAdapterDetails();
            string code = con.RowsValue(0, 0);

            txtGlobalFilter.EnterText(code);
            Thread.Sleep(2000);

            if (btnActionIncomplted.Enabled)
            {
                WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                btnActionIncomplted.ButtonClick();
                Console.WriteLine("BusinessPartner Update is displayed on Incompleted activities in Workbench");
                Thread.Sleep(2000);
                btnPopupClose.ButtonClick();

            }
            else
            {
                Console.WriteLine("Business partner creation is not displayed on Incompleted activities in workbench");
            }
        }
        public void CheckApprovalBusinessPartner(string nic)
        {
            Thread.Sleep(3000);
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            DBConnection con = new DBConnection();
            con.SQLConnectionDetails();
            /*
             * *********************************
             * msd.BusinessPartner Table details
             * *********************************
             */
            con.query = "SELECT Code FROM msd.BusinessPartner " +
                                       "WHERE NICNo ='" + nic + "'";
            con.DataAdapterDetails();
            string code = con.RowsValue(0, 0);

            txtGlobalFilterApproval.EnterText(code);
            Thread.Sleep(2000);

            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(3000);
            btnActionApproval.ButtonClick();
            Thread.Sleep(3000);
            WebDriver.driver.SwitchTo().Window(WebDriver.driver.WindowHandles.Last());
            string nicNo = txtNic.GetText();
            if (nicNo == nic)
            {
                Console.WriteLine("Business Partner aproval is displayed on Approvals in Workbench");
            }
            else
            {
                Console.WriteLine("Business partner creation is not displayed on Approvals in workbench");
            }
        }

        public void ApproveBusinessPartner()
        {
            WebDriver.driver.SwitchTo().Window(WebDriver.driver.WindowHandles[0]);
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000);

            Thread.Sleep(2000);
            btnActionApproval.ButtonClick();
        }
        public void ApproveInCentral(string comment)
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(3000);

            WebDriver.driver.SwitchTo().Window(WebDriver.driver.WindowHandles.Last());

            btnApproveReject.ButtonClick();
            Thread.Sleep(2000);

            chkbxSelect.ButtonClick();

            txtComment.EnterText(comment);
            Thread.Sleep(2000);

            btnApprove.ButtonClick();
            Thread.Sleep(5000);

            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            btnOk.ButtonClick();
        }
        public void ApprovalChangedStatus(string nic)
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(3000);

            WebDriver.driver.SwitchTo().Window(WebDriver.driver.WindowHandles.Last());
            DBConnection con = new DBConnection();

            con.SQLConnectionDetails();
            /*
             * *********************************
             * msd.BusinessPartner Table details
             * *********************************
             */
            con.query = "SELECT Code FROM msd.BusinessPartner " +
                                       "WHERE NICNo ='" + nic + "'";
            con.DataAdapterDetails();
            string code = con.RowsValue(0, 0);

            txtGlobalFilterApproval.EnterText(code);
            Thread.Sleep(2000);


            if (btnActionApproval.Enabled)
            {
                Console.WriteLine("BusinessPartner Update is displayed on Approvals in Workbench");
                Thread.Sleep(3000);
                WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                btnActionApproval.ButtonClick();
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("Business partner creation is not displayed on Approval in workbench");
            }
        }

        /* ***********************************************************
         * ******************STATUS MAINTENANCE***********************
         * ***********************************************************
         */
        public void ChangeStatusBusinessPartner(string comment)
        {
            txtCommentStatus.EnterText(comment);
            Thread.Sleep(2000);
            chkApprove.ButtonClick();
            btnApproveStatus.ButtonClick();
            Thread.Sleep(2000);
        }

        public void CompletedActivies(string nic)
        {
            Thread.Sleep(3000);
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            DBConnection con = new DBConnection();
            con.SQLConnectionDetails();
            /*  
             * *********************************
             * msd.BusinessPartner Table details
             * *********************************
             */
            con.query = "SELECT Code FROM msd.BusinessPartner " +
                                       "WHERE NICNo ='" + nic + "'";
            con.DataAdapterDetails();
            string code = con.RowsValue(0, 0);

            txtGlobalFilterCompleted.EnterText(code);
            Thread.Sleep(2000);

            if (btnActionCompleted.Enabled)
            {
                WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                btnActionCompleted.ButtonClick();
                Console.WriteLine("BusinessPartner Update is displayed on Completed activities in Workbench");
                Thread.Sleep(3000);
                WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                btnPopupCompleted.ButtonClick();
            }
            else
            {
                Console.WriteLine("Business partner creation is not displayed on Completed activities in workbench");
            }
        }

        public void CompanyCompletedActivities(string br)
        {
            Thread.Sleep(3000);
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            DBConnection con = new DBConnection();
            con.SQLConnectionDetails();
            /*  
             * *********************************
             * msd.BusinessPartnerExt Table details
             * *********************************
             */

            con.query = "SELECT BusinessPartnerId FROM msd.BusinessPartnerExt " +
                                       "WHERE BusinessRegistrationNo ='" + br + "'";
            con.DataAdapterDetails();
            string id = con.RowsValue(0, 0);

            con.query = "SELECT Code FROM msd.BusinessPartner " +
                                       "WHERE Id ='" + id + "'";

            con.DataAdapterDetails();
            string code = con.RowsValue(0, 0);

            txtGlobalFilterCompleted.EnterText(code);
            Thread.Sleep(2000);

            btnActionCompleted.ButtonClick();
            Thread.Sleep(3000);
            WebDriver.driver.SwitchTo().Window(WebDriver.driver.WindowHandles.Last());
            Thread.Sleep(2000);
            string brNo = txtNic.GetText();
            Thread.Sleep(1000);
            if (brNo == br)
            {
                Console.WriteLine("Business Partner Details are displayed on Completed activities in Workbench");
            }
            else
            {
                Console.WriteLine("Business Partner Details are not displayed on Completed activities in workbench");
            }
        }
    }
}
