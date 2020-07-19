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
    class CompanyCreationOther
    {
        public CompanyCreationOther()
        {
            PageFactory.InitElements(WebDriver.driver, this);
        }

        //Navigation of Company Creation

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[4]/app-business-other-info-creation/form/div/div/div[1]/p-fileupload/div/div[1]/span/input")]
        public IWebElement FileBrAttachment { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/span[4]/app-business-other-info-creation/form/div/div/div[2]/p-fileupload/div/div[1]/span/input")]
        public IWebElement FileMasterAttachment { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/div[4]/button[2]")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-business-creation/div/p-confirmdialog/div/div[3]/p-footer/button/span[2]")]
        public IWebElement btnOk { get; set; }

        public void AddAttahcment(string brAttachment)
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(5000);

            FileBrAttachment.EnterText(brAttachment);
            Thread.Sleep(2000);

            FileMasterAttachment.EnterText(brAttachment);
            Thread.Sleep(5000);                
        }

        public void SaveCompany()
        {
            btnSave.ButtonClick();
            Thread.Sleep(6000);

            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            btnOk.ButtonClick();
            Thread.Sleep(5000);
        }

    }
}
