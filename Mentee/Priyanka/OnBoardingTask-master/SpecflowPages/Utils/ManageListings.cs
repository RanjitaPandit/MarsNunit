using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SpecflowPages.Utils.Inputs;

namespace SpecflowPages.Utils
{
    public class ManageListings
    {
        public static IWebDriver localDriver = Driver.driver;

        public static void ClickonManageListings()
        {
            CommonMethods.ButtonClick(localDriver, "XPath", Inputs.ListingsInput.manageListingsLink);
            Thread.Sleep(3000);
        }
    }
}
