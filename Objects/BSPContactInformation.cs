﻿using CentralModule.GetSet;
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
    class BSPContactInformation
    {
        public BSPContactInformation()
        {
            PageFactory.InitElements(WebDriver.driver, this);
        }

        [FindsBy(How = How.Name, Using = "address1")]
        public IWebElement txtAddress1 { get; set; }

        [FindsBy(How = How.Name, Using = "address2")]
        public IWebElement txtAddress2 { get; set; }

        [FindsBy(How = How.Name, Using = "address3")]
        public IWebElement txtAddress3 { get; set; }

        [FindsBy(How = How.Name, Using = "province")]
        public IWebElement dpdprovince { get; set; }

        [FindsBy(How = How.Name, Using = "district")]
        public IWebElement dpddistrict { get; set; }

        [FindsBy(How = How.Name, Using = "city")]
        public IWebElement dpdcity { get; set; }

        [FindsBy(How = How.Name, Using = "secretarial")]
        public IWebElement dpdsecretarial { get; set; }

        [FindsBy(How = How.Name, Using = "gramaSevaVasama")]
        public IWebElement dpdgramaSevaVasama { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[2]/app-customer-contact-info/div/div/div[1]/form/p-card/div/div/div/div[1]/div[4]/button/span[2]")]
        public IWebElement btnAddAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[2]/app-customer-contact-info/div/div/div[2]/p-card/div/div/div/div/div[1]/form/div/div[1]/span/p-dropdown")]
        public IWebElement dpdContactType { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[2]/app-customer-contact-info/div/div/div[2]/p-card/div/div/div/div/div[1]/form/div/div[2]/span/p-dropdown")]
        public IWebElement dpdCountry { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[2]/app-customer-contact-info/div/div/div[2]/p-card/div/div/div/div/div[1]/form/div/div[3]/span/p-inputmask/input")]
        public IWebElement txtTelNo { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/span[2]/app-customer-contact-info/div/div/div[2]/p-card/div/div/div/div/div[1]/form/div/div[4]/button")]
        public IWebElement btnAddTelNo { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/div[2]/button[2]/span[2]")]
        public IWebElement btnNext { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/app-bsp-customer-creation/div/div[7]/button[2]")]
        public IWebElement btnNext2 { get; set; }


        public void FillContactDetails(string address1, string address2, string address3, Int64 telNo)
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(25);

            txtAddress1.EnterText(address1);
            txtAddress2.EnterText(address2);
            txtAddress3.EnterText(address3);

            Actions province = new Actions(WebDriver.driver);
            province.MoveToElement(dpdprovince).Click().Perform();

            province.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            Actions district = new Actions(WebDriver.driver);
            district.MoveToElement(dpddistrict).Click().Perform();

            district.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            Actions dcity = new Actions(WebDriver.driver);
            dcity.MoveToElement(dpdcity).Click().Perform();

            dcity.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            district.MoveToElement(dpddistrict).Click().Perform();

            district.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            dcity.MoveToElement(dpdcity).Click().Perform();

            dcity.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            Actions secretarial = new Actions(WebDriver.driver);
            secretarial.MoveToElement(dpdsecretarial).Click().Perform();

            secretarial.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            Actions gramaSevaVasama = new Actions(WebDriver.driver);
            gramaSevaVasama.MoveToElement(dpdgramaSevaVasama).Click().Perform();

            gramaSevaVasama.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

            txtAddress3.ButtonClick();

            IJavaScriptExecutor js = WebDriver.driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,250);");

            Actions AddAddress1 = new Actions(WebDriver.driver);
            AddAddress1.MoveToElement(btnAddAddress).Click().Perform();
            //btnAddAddress.ButtonClick();

            Thread.Sleep(2000);
            Actions ContactType = new Actions(WebDriver.driver);
            ContactType.MoveToElement(dpdContactType).Click().Perform();

            ContactType.SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(2000);
            txtTelNo.ButtonClick();
            Thread.Sleep(4000);
            txtTelNo.EnterText(telNo.ToString());
            Thread.Sleep(2000);
            btnAddTelNo.ButtonClick();

            Actions Next = new Actions(WebDriver.driver);
            Next.MoveToElement(btnNext).Click().Perform();

          //  return new BusinessPartnerCreationThirdPageObjects();
        }
    }
}
