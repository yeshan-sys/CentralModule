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
    class BSPUpdateBasicInfor
    {
        public BSPUpdateBasicInfor()
        {
            PageFactory.InitElements(WebDriver.driver, this);
        }

        // Customer Inquiry Page Objects

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-inquiry/div/div/div[1]/form/div[2]/div/div[1]/span/input")]
        public IWebElement txtNICSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-inquiry/div/div/div[1]/form/div[2]/div/div[2]/button[1]")]
        public IWebElement btnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-customer-inquiry/div/div/div[1]/form/div[2]/div/div[2]/button[3]")]
        public IWebElement btnUpdate { get; set; }

        //BSP First Page Objects

        [FindsBy(How = How.Name, Using = "nicNo")]
        public IWebElement txtNIC { get; set; }

        [FindsBy(How = How.Name, Using = "nicNoConfirm")]
        public IWebElement txtNICConfirm { get; set; }

        [FindsBy(How = How.Name, Using = "nicIssuedDate")]
        public IWebElement txtNICIssueDate { get; set; }

        [FindsBy(How = How.Name, Using = "bsptype")]
        public IWebElement Major { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/span[1]/app-customer-basic-info-update/form/div/div/div[1]/div[1]/div/p-card/div/div/div/div[3]/div/div[1]/div[2]/div[3]/span/p-calendar/span/div/div/div[1]/div/select[1]")]
        public IWebElement Month { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/span[1]/app-customer-basic-info-update/form/div/div/div[1]/div[1]/div/p-card/div/div/div/div[3]/div/div[1]/div[2]/div[3]/span/p-calendar/span/div/div/div[1]/div/select[2]")]
        public IWebElement Year { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/span[1]/app-customer-basic-info-update/form/div/div/div[1]/div[1]/div/p-card/div/div/div/div[3]/div/div[1]/div[2]/div[3]/span/p-calendar/span/div/div/div[2]/table/tbody/tr[1]/td[6]/a")]
        public IWebElement Day { get; set; }

        [FindsBy(How = How.Name, Using = "countryId")]
        public IWebElement dpdCountryId { get; set; }

        [FindsBy(How = How.Name, Using = "firstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "middleNames")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "lastName")]
        public IWebElement txtLastName { get; set; }

        [FindsBy(How = How.Name, Using = "placeOfBirth")]
        public IWebElement txtPlaceOfBirth { get; set; }

        [FindsBy(How = How.Name, Using = "maritalStatus")]
        public IWebElement dpdMaritalStatus { get; set; }

        [FindsBy(How = How.Name, Using = "religion")]
        public IWebElement dpdReligion { get; set; }

        [FindsBy(How = How.Name, Using = "race")]
        public IWebElement dpdRace { get; set; }

        [FindsBy(How = How.Name, Using = "nationalityId")]
        public IWebElement dpdNationality { get; set; }

        [FindsBy(How = How.Name, Using = "customerCategories")]
        public IWebElement dpdCustomerCategories { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/span[1]/app-customer-basic-info-update/form/div/div/div[1]/div[2]/div[2]/p-card/div/div/div/div/div[4]/span/p-dropdown")]
        public IWebElement dpdSupplierType { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/div[1]/button")]
        public IWebElement btnNext { get; set; }

        //Contact Details Page objects
        
        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/span[2]/app-customer-contact-info-update/div/div/div[1]/form/p-card/div/div/div/div[2]/div/table/tbody/tr/td[4]/a")]
        public IWebElement btnAddressAction { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/span[2]/app-customer-contact-info-update/div/div/div[1]/form/p-card/div/div/div/div[1]/div[2]/div/div[1]/span/input")]
        public IWebElement txtFAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/span[2]/app-customer-contact-info-update/div/div/div[1]/form/p-card/div/div/div/div[1]/div[2]/div/div[2]/span/input")]
        public IWebElement txtSAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/span[2]/app-customer-contact-info-update/div/div/div[1]/form/p-card/div/div/div/div[1]/div[2]/div/div[3]/span/input")]
        public IWebElement txtTAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/span[2]/app-customer-contact-info-update/div/div/div[1]/form/p-card/div/div/div/div[1]/div[4]/button")]
        public IWebElement btnUpdateAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/span[2]/app-customer-contact-info-update/div/div/div[2]/p-card/div/div/div/div/div[1]/form/div/div[1]/span/p-dropdown")]
        public IWebElement dpdContactType { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/span[2]/app-customer-contact-info-update/div/div/div[2]/p-card/div/div/div/div/div[1]/form/div/div[3]/span/p-inputmask/input")]
        public IWebElement txtTelNo { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/div[2]/button[2]")]
        public IWebElement btnCOntactNext { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/span[2]/app-customer-contact-info-update/div/div/div[2]/p-card/div/div/div/div/div[1]/form/div/div[4]/button")]
        public IWebElement btnAddTelNo { get; set; }

        //Common details Page Objects

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/div[3]/button[2]")]
        public IWebElement btnCommonNext { get; set; }

        //Final Page Objects

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/span[4]/app-customer-other-info-update/div/div[1]/div[2]/div[2]/p-fileupload/div/div[1]/span/input")]
        public IWebElement btnFileUpload { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/div[4]/button[2]")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-update/div/p-confirmdialog/div/div[3]/p-footer/button/span[2]")]
        public IWebElement btnOk { get; set; }

        /*
         * *************************
         * Search a business Partner
         * *************************
         */
        public void SearchBusinessPartner(string nic)
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            txtNICSearch.ButtonClick();
            txtNICSearch.EnterText(nic);
            Thread.Sleep(2000);
            btnSearch.ButtonClick();

            Thread.Sleep(3000);
            btnUpdate.ButtonClick();
        }

        /*
         * *************************************
         * Update Business Partner Basic Details
         * *************************************
         */
        public void UpdateBasicDetails(string firstName, string middleName, string lastName, string birthPlace)
        {            
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000);

            txtFirstName.SendKeys(Keys.Control + "a");
            txtFirstName.SendKeys(Keys.Delete);
            txtFirstName.Clear();
            txtFirstName.EnterText(firstName);

            txtMiddleName.SendKeys(Keys.Control + "a");
            txtMiddleName.SendKeys(Keys.Delete);
            txtMiddleName.Clear();
            txtMiddleName.EnterText(middleName);

            txtLastName.SendKeys(Keys.Control + "a");
            txtLastName.SendKeys(Keys.Delete);
            txtLastName.Clear();
            txtLastName.EnterText(lastName);

            txtPlaceOfBirth.SendKeys(Keys.Control + "a");
            txtPlaceOfBirth.SendKeys(Keys.Delete);
            txtPlaceOfBirth.Clear();
            txtPlaceOfBirth.EnterText(birthPlace);
            Thread.Sleep(2000);

            btnNext.ButtonClick();
            Thread.Sleep(2000);
        }
        /*
         * ***************************************
         * Update Business Partner Contact Details
         * ***************************************
         */
        public void UpdateContactDetails(string addF, string addS, string addT, Int64 tel)
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000);
            Thread.Sleep(3000);
            txtTAddress.ButtonClick();

            IJavaScriptExecutor js = WebDriver.driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,250);");

            btnAddressAction.ButtonClick();
            Thread.Sleep(2000);
            txtFAddress.SelectAllValue();
            txtFAddress.EnterText(addF);

            txtSAddress.SelectAllValue();
            txtSAddress.EnterText(addS);

            txtTAddress.SelectAllValue();
            txtTAddress.EnterText(addT);

            btnUpdateAddress.ButtonClick();

            Thread.Sleep(2000);
            Actions ContactType = new Actions(WebDriver.driver);
            ContactType.MoveToElement(dpdContactType).Click().Perform();

            ContactType.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(2000);
            txtTelNo.ButtonClick();
            Thread.Sleep(3000);
            txtTelNo.EnterText(tel.ToString());

            btnAddTelNo.ButtonClick();
            Thread.Sleep(2000);
            btnCOntactNext.ButtonClick();
            Thread.Sleep(2000);           
        }

        public void UpdateCommonDetails()
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);
            btnCommonNext.ButtonClick();           
        }

        public void UpdateFinalStepDetails(string attach)
        {
            btnFileUpload.EnterText(attach);
            Thread.Sleep(2000);            
        }

        public void SaveBusinessPartner()
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(5000);
            btnSave.ButtonClick();           
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(5000);
            btnOk.ButtonClick();
        }
    }
}
