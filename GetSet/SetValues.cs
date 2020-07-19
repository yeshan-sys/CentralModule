using CentralModule.Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralModule.GetSet
{
    public static class SetValues
    {
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
        }
        public static void ButtonClick(this IWebElement element)
        {
            Actions click = new Actions(WebDriver.driver);
            click.MoveToElement(element).Click().Perform();      
        }

        //SelectDropDown
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);           
        }

        public static void SelectAllValue(this IWebElement element)
        {
            element.SendKeys(Keys.Control + "a");
        }
    }
}
