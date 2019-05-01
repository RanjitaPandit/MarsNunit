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
    public class AddEducationSteps
    {
        [Given(@"I clicked on the Education tab under Profile page")]
        public void GivenIClickedOnTheEducationTabUnderProfilePage()
        {
            ProfileDetails.ClickonEducationTab();
            Thread.Sleep(3000);
        }
        
        [When(@"I add Education details")]
        public void WhenIAddEducationDetails()
        {
            ProfileDetails.AddEducationDetails();
            Thread.Sleep(3000);
        }
        
        [Then(@"that Education details should be displayed on my listings")]
        public void ThenThatEducationDetailsShouldBeDisplayedOnMyListings()
        {
            try
            {
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.extent.StartTest("Add Education Details");
                Thread.Sleep(3000);
                string ActualResult = Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]")).Text;
                Assert.AreEqual("GIT", ActualResult);
                CommonMethods.test.Log(LogStatus.Pass, "Education detail added Successfully ");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "New Education details are Added");
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("We are at wrong page ");
                CommonMethods.test.Log(LogStatus.Fail, "Problem in adding Education details " + ex.InnerException);
            }
        }
    }
}
