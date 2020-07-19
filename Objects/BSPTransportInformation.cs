using CentralModule.GetSet;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralModule.Objects
{
    class BSPTransportInformation
    {
        public BSPTransportInformation()
        {
            PageFactory.InitElements(WebDriver.driver, this);

        }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[3]/app-customer-common-info/form/div/p-tabview/div/div/p-tabpanel[1]/div/div/div[1]/div/div[1]/span/p-dropdown")]
        public IWebElement dpdIntroducerType { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[3]/app-customer-common-info/form/div/p-tabview/div/div/p-tabpanel[1]/div/div/div[1]/div/div[2]/span/p-dropdown")]
        public IWebElement dpdsector { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[3]/app-customer-common-info/form/div/p-tabview/div/div/p-tabpanel[1]/div/div/div[1]/div/div[3]/span/p-dropdown")]
        public IWebElement dpdOccupation { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[3]/app-customer-common-info/form/div/p-tabview/div/div/p-tabpanel[1]/div/div/div[1]/div/div[4]/span/p-dropdown")]
        public IWebElement dpdSubOccupation { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[3]/app-customer-common-info/form/div/p-tabview/div/div/p-tabpanel[1]/div/div/div[3]/div[1]/div[1]/div/div/span/p-dropdown")]
        public IWebElement dpdTransportType { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[3]/app-customer-common-info/form/div/p-tabview/div/div/p-tabpanel[1]/div/div/div[3]/div[1]/div[2]/div/span/input")]
        public IWebElement txtDistanceK { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[3]/app-customer-common-info/form/div/p-tabview/div/div/p-tabpanel[1]/div/div/div[3]/div[1]/div[3]/div/span/input")]
        public IWebElement txtDistanceM { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[3]/app-customer-common-info/form/div/p-tabview/div/div/p-tabpanel[1]/div/div/div[3]/div[1]/div[4]/div/span/input")]
        public IWebElement txtTransportCost { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[3]/app-customer-common-info/form/div/p-tabview/div/div/p-tabpanel[1]/div/div/div[3]/div[3]/div/button[1]")]
        public IWebElement btnAddTransport { get; set; }   

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/div[3]/button[2]")]
        public IWebElement btnNext { get; set; }

        public void FillCommonDetails(int km, int m, int cost)
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);

            txtDistanceK.ButtonClick();
            txtDistanceK.EnterText(km.ToString());
            txtDistanceM.EnterText(m.ToString());
            txtTransportCost.EnterText(cost.ToString());
            txtDistanceK.ButtonClick();

            btnAddTransport.ButtonClick();

            Actions TransportType = new Actions(WebDriver.driver);
            TransportType.MoveToElement(dpdTransportType).Click().Perform();

            TransportType.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            Actions IntroducerType = new Actions(WebDriver.driver);
            IntroducerType.MoveToElement(dpdIntroducerType).Click().Perform();

            IntroducerType.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            Actions sector = new Actions(WebDriver.driver);
            sector.MoveToElement(dpdsector).Click().Perform();

            sector.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            Actions Occupation = new Actions(WebDriver.driver);
            Occupation.MoveToElement(dpdOccupation).Click().Perform();

            Occupation.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            Actions SubOccupation = new Actions(WebDriver.driver);
            SubOccupation.MoveToElement(dpdSubOccupation).Click().Perform();

            SubOccupation.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            txtDistanceK.ButtonClick();

            btnAddTransport.ButtonClick();

            btnNext.ButtonClick();

           // return new BusinessPartnerCreationLastPageObjects();
        }

    }
}
