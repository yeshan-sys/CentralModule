using CentralModule.GetSet;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CentralModule.Objects
{
     class Login
    {
        public Login()
        {            
                PageFactory.InitElements(WebDriver.driver, this);           
        }

        //Element Definition
        [FindsBy(How = How.Id, Using = "float-username")]
        public IWebElement txtUsername { get; set; }

        [FindsBy(How = How.Id, Using = "float-password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/ng-component/div[1]/div[1]/div/form/div/div[3]/button")]
        public IWebElement btnLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/main/ng-component/p-confirmdialog/div/div[3]/button[1]")]
        public IWebElement btnYes { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-header/eclipse-header/header/nav/ul/li[3]/div/i")]
        public IWebElement dpdUserName { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-root/div/app-header/eclipse-header/header/nav/p-menu/div/ul/li[2]/a/span[2]")]
        public IWebElement btnLogOut { get; set; }
        public void EnterDataLogin(string username, string password)
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            txtUsername.SendKeys(username);
            txtPassword.SendKeys(password);
            Thread.Sleep(1000);
        }
        public void ClickLogin() => btnLogin.Click();

        public void Logout()
        {
            WebDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(2000);
            dpdUserName.ButtonClick();
            Thread.Sleep(2000);
            btnLogOut.ButtonClick();
        }
    }
}
