using System;
using TechTalk.SpecFlow;
using SpecflowPages.Utils;
using System.Threading;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using NUnit.Framework;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class ShareSkills
    {
        [Given(@"I clicked on the ShareSkill link under Profile page")]
        public void GivenIClickedOnTheShareSkillLinkUnderProfilePage()
        {
            Thread.Sleep(3000);
            ShareSkillDetails.ClickonShareSkill();
            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(2000);
                CommonMethods.test = CommonMethods.extent.StartTest("Testing Share Skill link ");
                Assert.AreEqual("ServiceListing", ShareSkillDetails.localDriver.Title);
                CommonMethods.test.Log(LogStatus.Pass, "We are on Service Listing Page");
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("We are at wrong page");
                CommonMethods.test.Log(LogStatus.Fail, "We are not at Service Listing Page " + ex.InnerException);
            }
        }
        
        [Given(@"I entered all the details on service listing page")]
        public void GivenIEnteredAllTheDetailsOnServiceListingPage()
        {
            ShareSkillDetails.ServiceListingFields();
        }
        
        [When(@"I click on save")]
        public void WhenIClickOnSave()
        {
            ShareSkillDetails.ClickonSaveButton();
        }
        
        [Then(@"the profile should be displayed under Manage Listings tab")]
        public void ThenTheProfileShouldBeDisplayedUnderManageListingsTab()
        {
            ManageListings.ClickonManageListings();
            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(2000);
                CommonMethods.test = CommonMethods.extent.StartTest("Testing Manage Listings link ");
                Assert.AreEqual("ListingManagement", ManageListings.localDriver.Title);
                CommonMethods.test.Log(LogStatus.Pass, "We are at Manage Listing page ");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Manage Listing");
                Thread.Sleep(2000);
            }
            catch (Exception Exp)
            {
                Console.WriteLine("It's a wrrong page ");
                CommonMethods.test.Log(LogStatus.Fail, "We are not at Manage Listing page " + Exp.InnerException);
            }
        }
    }
}
