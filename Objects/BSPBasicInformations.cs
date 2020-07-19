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
    class BSPBasicInformations
    {
        public BSPBasicInformations()
        {
            PageFactory.InitElements(WebDriver.driver, this);
        }
      
        [FindsBy(How = How.Name, Using = "nicNo")]
        public IWebElement txtNIC { get; set; }

        [FindsBy(How = How.Name, Using = "nicNoConfirm")]
        public IWebElement txtNICConfirm { get; set; }

        [FindsBy(How = How.Name, Using = "nicIssuedDate")]
        public IWebElement txtNICIssueDate { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[1]/app-customer-basic-info/form/div/div/div[1]/div[1]/div/p-card/div/div/div/div[1]/div[3]/div/div/span[4]/p-radiobutton/div/div[2]/span")]
        public IWebElement Major { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[1]/app-customer-basic-info/form/div/div/div[1]/div[1]/div/p-card/div/div/div/div[2]/div/div[1]/div[2]/div[3]/span/p-calendar/span/div/div/div[1]/div/select[1]")]
        public IWebElement Month { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[1]/app-customer-basic-info/form/div/div/div[1]/div[1]/div/p-card/div/div/div/div[2]/div/div[1]/div[2]/div[3]/span/p-calendar/span/div/div/div[1]/div/select[2]")]
        public IWebElement Year { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[1]/app-customer-basic-info/form/div/div/div[1]/div[1]/div/p-card/div/div/div/div[2]/div/div[1]/div[2]/div[3]/span/p-calendar/span/div/div/div[2]/table/tbody/tr[3]/td[4]/a")]                                          
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

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[1]/app-customer-basic-info/form/div/div/div[1]/div[2]/div[1]/p-card/div/div/div/div[3]/div[3]/span/p-dropdown/div/div[3]/label")]
        public IWebElement dpdRace { get; set; }

        [FindsBy(How = How.Name, Using = "nationalityId")]
        public IWebElement dpdNationality { get; set; }

        [FindsBy(How = How.Name, Using = "customerCategories")]
        public IWebElement dpdCustomerCategories { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[1]/app-customer-basic-info/form/div/div/div[1]/div[2]/div[2]/p-card/div/div/div/div/div[4]/span/p-dropdown/div/div[3]/label")]
        public IWebElement dpdSupplierType { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/div[1]/button")]

        public IWebElement btnNext { get; set; }

        public void FillMandatoryData(string nic, string date, string firstName, string middleName, string lastName, string birthPlace)
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000);

            Thread.Sleep(3000);           
            txtNIC.EnterText(nic);
            txtNICConfirm.EnterText(nic);
            Major.ButtonClick();
            Thread.Sleep(2000);
            txtNICConfirm.ButtonClick();

            Actions acc = new Actions(WebDriver.driver);
            txtNICIssueDate.ButtonClick();
            Thread.Sleep(2000);
            //txtNICIssueDate.EnterText(date); 
            Month.ButtonClick();
            acc.SendKeys(Keys.ArrowUp).SendKeys(Keys.Enter).Perform();
            Year.ButtonClick();
            Thread.Sleep(2000);
            acc.SendKeys(Keys.ArrowUp).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(2000);
            Day.ButtonClick();
            /*
            Month.SelectDropDown(month);
            Year.SelectDropDown(year.ToString());
            Day.ButtonClick(); */

            dpdCountryId.ButtonClick();

            Actions SelectCountry = new Actions(WebDriver.driver );
            SelectCountry.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Actions nicchange = new Actions(WebDriver.driver );
            nicchange.MoveToElement(txtNICConfirm).Click().Perform();

            txtFirstName.EnterText(firstName);
            txtMiddleName.EnterText(middleName);
            txtLastName.EnterText(lastName);
            txtPlaceOfBirth.EnterText(birthPlace);

            Thread.Sleep(2000);
            Actions Marital = new Actions(WebDriver.driver );
            Marital.MoveToElement(dpdMaritalStatus).Click().Perform();

            Marital.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            Actions CustomerCategories = new Actions(WebDriver.driver);
            CustomerCategories.MoveToElement(dpdCustomerCategories).Click().Perform();

            CustomerCategories.SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            Actions Nationality = new Actions(WebDriver.driver);
            Nationality.MoveToElement(dpdNationality).Click().Perform();

            Nationality.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            Actions SupplierType = new Actions(WebDriver.driver);
            SupplierType.MoveToElement(dpdSupplierType).Click().Perform();

            SupplierType.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            Actions Religion = new Actions(WebDriver.driver);
            Religion.MoveToElement(dpdReligion).Click().Perform();

            Religion.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            Actions Race = new Actions(WebDriver.driver);
            Race.MoveToElement(dpdRace).Click().Perform();

            Race.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            Actions Nationality1 = new Actions(WebDriver.driver);
            Nationality1.MoveToElement(dpdNationality).Click().Perform();

            Nationality1.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            Actions next = new Actions(WebDriver.driver);
            next.MoveToElement(btnNext).Click().Perform();

           // return new BusinessPartnerCreationSecondPageObjects();
        }
    }
}
