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
    class CompanyCreationCommon
    {
        public CompanyCreationCommon()
        {
            PageFactory.InitElements(WebDriver.driver, this);
        }        

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[3]/app-business-common-info-creation/form/div/p-tabview/div/div/p-tabpanel[1]/div/div[1]/div[1]/span/p-dropdown/div/div[4]/span")]
        public IWebElement dpdSearchBy { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[3]/app-business-common-info-creation/form/div/p-tabview/div/div/p-tabpanel[1]/div/div[1]/div[2]/span/input")]
        public IWebElement txtSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[3]/app-business-common-info-creation/form/div/p-tabview/div/div/p-tabpanel[1]/div/div[1]/div[3]/button[1]/span[2]")]
        public IWebElement btnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[3]/app-business-common-info-creation/form/div/p-tabview/div/div/p-tabpanel[1]/div/div[2]/div/div[1]/div[2]/div/div/div/div[1]/span/p-dropdown/div/div[4]/span")]
        public IWebElement dpdRelationType { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[3]/app-business-common-info-creation/form/div/p-tabview/div/div/p-tabpanel[1]/div/div[2]/div/div[1]/div[2]/div/div/div/div[2]/span/p-inputswitch/div/span")]
        public IWebElement swtRelatedParty { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[3]/app-business-common-info-creation/form/div/p-tabview/div/div/p-tabpanel[1]/div/div[2]/div/div[1]/div[2]/div/div/div/div[3]/span/textarea")]
        public IWebElement txtDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[3]/app-business-common-info-creation/form/div/p-tabview/div/div/p-tabpanel[1]/div/div[2]/div/div[1]/div[2]/div/div/div/div[4]/span/p-dropdown/div/div[4]/span")]
        public IWebElement dpdLegalNature { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[3]/app-business-common-info-creation/form/div/p-tabview/div/div/p-tabpanel[1]/div/div[2]/div/div[1]/div[2]/div/div/div/div[5]/span/input")]
        public IWebElement txtNumberOfShares { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[3]/app-business-common-info-creation/form/div/p-tabview/div/div/p-tabpanel[1]/div/div[2]/div/div[1]/div[2]/div/div/div/div[6]/div/span[1]/input")]
        public IWebElement txtVotingRights { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[3]/app-business-common-info-creation/form/div/p-tabview/div/div/p-tabpanel[1]/div/div[2]/div/div[1]/div[1]/div/div[2]/button[1]/span[2]")]
        public IWebElement btnAdd { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/div[3]/button[2]/span[2]")]
        public IWebElement btnNext { get; set; }

        public void FilltheCommonDetails(string nic, string description, string shares, string voting)
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(5000);

            Actions dropdown = new Actions(WebDriver.driver); 
            dpdSearchBy.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(2000);

            txtSearch.EnterText(nic);

            btnSearch.ButtonClick();
            Thread.Sleep(3000);

            IJavaScriptExecutor js = WebDriver.driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,250);");

            dpdRelationType.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(2000);

            swtRelatedParty.ButtonClick();
            Thread.Sleep(1000);

            txtDescription.EnterText(description);

            dpdLegalNature.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(2000);

            txtNumberOfShares.EnterText(shares);

            txtVotingRights.EnterText(voting);

            btnAdd.ButtonClick();
            Thread.Sleep(3000);
            js.ExecuteScript("window.scrollBy(0,-250);");

            btnNext.ButtonClick();
            Thread.Sleep(5000);

        }

    }
}
