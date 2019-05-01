using System;
using TechTalk.SpecFlow;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using NUnit.Framework;
using SpecflowPages.Utils;
using System.Threading;
using static SpecflowPages.CommonMethods;
using OpenQA.Selenium;


namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class AddMoreDetails
    {
        [When(@"I add more details in left panel fields")]
        public void WhenIAddMoreDetailsInLeftPanelFields()
        {
            ProfileDetails.AddMoreDetails();
        }
        
        [Then(@"that detail should be displayed on my listings")]
        public void ThenThatDetailShouldBeDisplayedOnMyListings()
        {
            try
            {
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.extent.StartTest("Add More Details ");
                Thread.Sleep(3000);
                string ActualResult = Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[3]")).Text;
                Assert.AreEqual("Full Time", ActualResult);
                CommonMethods.test.Log(LogStatus.Pass, "Details added Successfully ");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Details can be seen on left panel");
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("We are at wrong page ");
                CommonMethods.test.Log(LogStatus.Fail, "Problem in adding details " + ex.InnerException);
            }
        }
    }
}
