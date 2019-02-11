using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Pages
{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.CssSelector, Using = "div:nth-child(1) div.first-section div.ui.secondary.menu.inverted:nth-child(1) div.right.item > a.item")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.CssSelector, Using = "body.dimmable.dimmed:nth-child(2) div.ui.page.modals.dimmer.transition.visible.active:nth-child(17) div.ui.tiny.modal.transition.visible.active div.content.one.column.stackable.center.aligned.page.grid div:nth-child(1) div.ui.large.form.error div.field:nth-child(2) > input:nth-child(1)")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.CssSelector, Using = "body.dimmable.dimmed:nth-child(2) div.ui.page.modals.dimmer.transition.visible.active:nth-child(17) div.ui.tiny.modal.transition.visible.active div.content.one.column.stackable.center.aligned.page.grid div:nth-child(1) div.ui.large.form.error div.field:nth-child(3) > input:nth-child(1)")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        private IWebElement LoginBtn { get; set; }

        #endregion

        internal void LoginSteps()
        {
            //extent Reports
            Base.test = Base.extent.StartTest("Login Test");

            //Populate the Excel sheet
            Global.GlobalDefinitions.ExcelLib.PopulateInCollection(Global.Base.ExcelPath, "SignIn");

            //Navigate to the Url
            Global.GlobalDefinitions.driver.Navigate().GoToUrl(Global.GlobalDefinitions.ExcelLib.ReadData(2,"Url"));

            //Click on Sign In tab
            SignIntab.Click();
            Thread.Sleep(500);

            //Enter the data in Username textbox
            Email.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2,"Username"));
            Thread.Sleep(500);

            //Enter the password 
            Password.SendKeys(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            //Click on Login button
            LoginBtn.Click();
            Thread.Sleep(1500);

          /*  string text = Global.GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div/a")).Text;

            if (text == "MarsLogo")
            {
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Login Successful");
            }
            else
                Global.Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Login Unsuccessful");

*/        }
    }
}