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
    class BSPAttchment
    {
        public BSPAttchment()
        {
            PageFactory.InitElements(WebDriver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[4]/app-customer-other-info/div/div/div[1]/p-fileupload/div/div[1]/span/input")]
        public IWebElement btnFileUpload { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/div[4]/button[2]")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/p-confirmdialog/div/div[3]/p-footer/button")]
        public IWebElement btnOk { get; set; }

        public void AttachFile(string attach)
        {
            btnFileUpload.EnterText(attach);
            Thread.Sleep(2000);

            btnSave.ButtonClick();
            Thread.Sleep(2000);

           // return new CentralPageObjects();
        }
        public void SaveBusinessPartner()
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(5000);
            btnSave.ButtonClick();
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);           
            btnOk.ButtonClick();
        }      
    }
}
