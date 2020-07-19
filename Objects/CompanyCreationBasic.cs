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
    class CompanyCreationBasic
    {
        public CompanyCreationBasic()
        {
            PageFactory.InitElements(WebDriver.driver, this);
        }

        //Navigation of Company Creation

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[1]/div/p-card/div/div/div/div/div[1]/div[1]/span/input")]
        public IWebElement txtBRNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[1]/div/p-card/div/div/div/div/div[1]/div[2]/span/input")]
        public IWebElement txtConBRNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[1]/div/p-card/div/div/div/div/div[2]/div[1]/span/p-dropdown/div/div[4]/span")]
        public IWebElement dpdCorporateStatus { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[1]/div/p-card/div/div/div/div/div[3]/div[1]/span/p-multiselect/div/div[3]/span")]
        public IWebElement dpdCorporateType { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[1]/div/p-card/div/div/div/div/div[3]/div[1]/span/p-multiselect/div/div[4]/div[2]/ul/p-multiselectitem[1]/li/div/div")]
        public IWebElement chkClient { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[1]/div/p-card/div/div/div/div/div[2]/div[2]/span/p-dropdown/div/div[4]/span")]
        public IWebElement dpdCountry { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[2]/div[1]/p-card/div/div/div/div/div[1]/div[1]/span/p-dropdown/div/div[4]/span")]
        public IWebElement dpdBusinessType { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[2]/div[1]/p-card/div/div/div/div/div[2]/div[1]/span/p-dropdown/div/div[4]/span")]
        public IWebElement dpdCorporateGrade { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[2]/div[1]/p-card/div/div/div/div/div[1]/div[2]/span/input")]
        public IWebElement txtCorporateName { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[2]/div[1]/p-card/div/div/div/div/div[2]/div[2]/span/input")]
        public IWebElement txtCorporateOtherName { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[2]/div[1]/p-card/div/div/div/div/div[1]/div[3]/span/p-calendar/span/button/span[1]")]
        public IWebElement RegistrationDate { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[2]/div[1]/p-card/div/div/div/div/div[1]/div[3]/span/p-calendar/span/div/div/div[1]/div/select[1]")]
        public IWebElement RegMonth { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[2]/div[1]/p-card/div/div/div/div/div[1]/div[3]/span/p-calendar/span/div/div/div[1]/div/select[2]")]
        public IWebElement RegYear { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[2]/div[1]/p-card/div/div/div/div/div[1]/div[3]/span/p-calendar/span/div/div/div[2]/table/tbody/tr[3]/td[4]/a")]
        public IWebElement RegDate { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[2]/div[2]/p-card/div/div/div/div/div/div[1]/span/p-dropdown/div/div[4]/span")]
        public IWebElement dpdLanguage { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[2]/div[2]/p-card/div/div/div/div/div/div[2]/span/p-dropdown/div/div[4]/span")]
        public IWebElement dpdSector { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[2]/div[2]/p-card/div/div/div/div/div/div[3]/span/p-multiselect/div/div[3]/span")]
        public IWebElement dpdCommunicationMode { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[2]/div[2]/p-card/div/div/div/div/div/div[3]/span/p-multiselect/div/div[4]/div[1]/div[1]/div[2]")]
        public IWebElement chkCommunication { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[1]/app-business-basic-info-creation/form/div/div/div/div[2]/div[2]/p-card/div/div/div/div/div/div[4]/span/p-dropdown/div/div[4]/span")]
        public IWebElement dpdSupplierType { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/div[1]/button/span[2]")]
        public IWebElement btnNext { get; set; }

        public void FillBasicInformation(string br, string name, string othername)
        {
            Thread.Sleep(5000);
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(3000);

            txtBRNumber.EnterText(br);
            txtConBRNumber.EnterText(br);

            Actions dropdown = new Actions(WebDriver.driver);

            dpdCorporateStatus.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(2000);

            dpdCountry.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(2000);

            dpdCorporateType.ButtonClick();
            Thread.Sleep(2000);
            chkClient.ButtonClick();
            Thread.Sleep(5000);

            txtCorporateName.ButtonClick();
            Thread.Sleep(2000);

            dpdBusinessType.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(1000);

            IJavaScriptExecutor js = WebDriver.driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,200);");
            Thread.Sleep(1000);

            dpdCorporateGrade.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(2000);

            txtCorporateName.EnterText(name);
            txtCorporateOtherName.EnterText(othername);
            Thread.Sleep(2000);

            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Actions acc = new Actions(WebDriver.driver);
            RegistrationDate.ButtonClick();
            Thread.Sleep(2000);
            RegMonth.ButtonClick();
            acc.SendKeys(Keys.ArrowUp).SendKeys(Keys.Enter).Perform();
            RegYear.ButtonClick();
            acc.SendKeys(Keys.ArrowUp).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(2000);
            RegDate.ButtonClick();

            dpdLanguage.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(2000);

            dpdSector.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(1000);

            dpdCommunicationMode.ButtonClick();
            chkCommunication.ButtonClick();
            Thread.Sleep(1000);

            txtCorporateName.ButtonClick();
            dpdSupplierType.ButtonClick(); 
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(2000);

            IJavaScriptExecutor jsc = WebDriver.driver as IJavaScriptExecutor;
            jsc.ExecuteScript("window.scrollBy(0,-200);");
            Thread.Sleep(2000);

            btnNext.ButtonClick();
            Thread.Sleep(3000);
        }


    }
}
