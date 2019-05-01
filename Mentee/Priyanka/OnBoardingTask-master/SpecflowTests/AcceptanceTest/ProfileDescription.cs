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
    public class ProfileDescription
    {
        [Given(@"I clicked on the Description link under Profile page")]
        public void GivenIClickedOnTheDescriptionLinkUnderProfilePage()
        {
            ProfileDetails.ClickonDescriptionLink();
        }
        
        [When(@"I add Description details")]
        public void WhenIAddDescriptionDetails()
        {
            ProfileDetails.AddDescription();
            Thread.Sleep(2000);
        }
        
        [Then(@"that Description detail should be displayed on my listings")]
        public void ThenThatDescriptionDetailShouldBeDisplayedOnMyListings()
        {
            try
            {
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.extent.StartTest("Add Profile Description ");
                Thread.Sleep(3000);
                string ActualResult = Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/div/div/div/span")).Text;
                Assert.AreEqual("I am a Tester with good knowledge of Selenium Web Driver and C sharp", ActualResult);
                CommonMethods.test.Log(LogStatus.Pass, "Profile Description added Successfully ");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Description is Added");
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
