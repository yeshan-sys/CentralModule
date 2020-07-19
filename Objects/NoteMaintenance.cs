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
    class NoteMaintenance
    {
        public NoteMaintenance()
        {
            PageFactory.InitElements(WebDriver.driver, this);

        }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/div[1]/div/form/div/div[1]/span/p-dropdown/div/div[4]/span")]
        public IWebElement dpdSearchBy { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/div[1]/div/form/div/div[2]/span/input")]
        public IWebElement txtSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/div[1]/div/form/div/div[3]/button[1]/span[2]")]
        public IWebElement btnSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/div[1]/div/form/div/div[3]/button[3]/span[2]")]
        public IWebElement btnAddNote { get; set; }

        //Elements of Add note Pop up

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div/form/div[1]/span/p-dropdown/div/div[4]/span")]
        public IWebElement dpdFacilityType { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div/form/div[3]/span/p-dropdown/div/div[4]/span")]
        public IWebElement dpdMainType { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div/form/div[4]/span/p-dropdown/div/div[4]/span")]
        public IWebElement dpdSubType { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div/form/div[5]/span/p-calendar/span/button/span[1]")]
        public IWebElement Effcalender { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div/form/div[5]/span/p-calendar/span/div/div/div[1]/div/select[1]")]
        public IWebElement Effmonth { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div/form/div[5]/span/p-calendar/span/div/div/div[1]/div/select[2]")]
        public IWebElement Effyear { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div/form/div[5]/span/p-calendar/span/div/div/div[2]/table/tbody/tr[3]/td[4]/a")]
        public IWebElement Effday { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div/form/div[6]/span/p-calendar/span/button/span[1]")]
        public IWebElement Expcalender { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div/form/div[6]/span/p-calendar/span/div/div/div[1]/div/select[1]")]
        public IWebElement Expmonth { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div/form/div[6]/span/p-calendar/span/div/div/div[1]/div/select[2]")]
        public IWebElement Expyear { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div/form/div[6]/span/p-calendar/span/div/div/div[2]/table/tbody/tr[4]/td[4]/a")]
        public IWebElement Expday { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div/form/div[8]/span/p-calendar/span/button/span[1]")]
        public IWebElement Rmdcalender { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div/form/div[8]/span/p-calendar/span/div/div[1]/div[1]/div/select[1]")]
        public IWebElement Rmdmonth { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div/form/div[8]/span/p-calendar/span/div/div[1]/div[1]/div/select[2]")]
        public IWebElement Rmdyear { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div/form/div[8]/span/p-calendar/span/div/div[1]/div[2]/table/tbody/tr[4]/td[4]/a")]
        public IWebElement Rmdday { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div/form/div[7]/span/p-dropdown/div/div[4]/span")]
        public IWebElement dpdSeverity { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/div[1]/div/form/div[9]/span/textarea")]
        public IWebElement txtNote { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-notes/div/div/app-add-notes/p-dialog/div/div[2]/p-scrollpanel/div/div[1]/div/div/p-footer/div/div/button[2]/span[2]")]
        public IWebElement btnSave { get; set; }

        public void SearchBusinessPartner(string nic)
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(3000);
            Actions dropdown = new Actions(WebDriver.driver); 

            dpdSearchBy.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(2000);

            txtSearch.EnterText(nic);

            btnSearch.ButtonClick();
            Thread.Sleep(5000);
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            btnAddNote.ButtonClick();
            Thread.Sleep(2000);
        }
        public void SaveAddNote(string note)
        {
            Actions dropdown = new Actions(WebDriver.driver);
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(3000);
            dpdFacilityType.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            dpdMainType.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).Perform();
            Thread.Sleep(2000);

            dpdSubType.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).Perform();

            Effcalender.ButtonClick();
            Thread.Sleep(1000);
            Effmonth.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).Perform();
            Effyear.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).Perform();
            Effday.ButtonClick();
            Thread.Sleep(2000);

            Expcalender.ButtonClick();
            Thread.Sleep(1000);
            Expmonth.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Expyear.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).Perform();
            Expday.ButtonClick();
            Thread.Sleep(2000);

            dpdSeverity.ButtonClick();
            dropdown.SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).Perform();
            Thread.Sleep(2000);

            txtNote.EnterText(note);
            Thread.Sleep(2000);
       
            btnSave.ButtonClick();
            Thread.Sleep(2000);
        }







    }
}
