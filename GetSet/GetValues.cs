using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralModule.GetSet
{
    public static class GetValues
    {
        public static string GetText(this IWebElement element)
        {
           return element.GetAttribute("value");
        }

    }
}
