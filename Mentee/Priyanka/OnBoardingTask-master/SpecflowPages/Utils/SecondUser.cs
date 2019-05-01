using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using SpecflowPages.Utils.Inputs;

namespace SpecflowPages.Utils
{
    public class SecondUser
    {
        public static IWebDriver localDriver = Driver.driver;

        public static void OtherSeller()
        {
            Driver.NavigateUrl();
            Thread.Sleep(5000);
            CommonMethods.ButtonClick(localDriver, "XPath", SecondUserInput.signIn);
            Thread.Sleep(2000);
            CommonMethods.TextBox(localDriver, "XPath", SecondUserInput.emailId, SecondUserInput.mailID);
            CommonMethods.TextBox(localDriver, "XPath", SecondUserInput.password, SecondUserInput.pwd);
            CommonMethods.ButtonClick(localDriver, "XPath", SecondUserInput.loginButton);
            Thread.Sleep(2000);
        }

        public static void SearchSellerDetails()
        {
            CommonMethods.TextBox(localDriver, "XPath", SecondUserInput.searchSkills, SecondUserInput.searchValue);
            CommonMethods.ButtonClick(localDriver, "XPath", SecondUserInput.searchIcon);
            Thread.Sleep(2000);
        }

        public static void ClickonProfile()
        {
            CommonMethods.ButtonClick(localDriver, "XPath", SecondUserInput.serviceInfo);
            Thread.Sleep(2000);
        }
               
    }
}
