using System;
using TechTalk.SpecFlow;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using NUnit.Framework;
using System.Threading;
using SpecflowPages.Utils;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class OtherSellerSearch
    {
        [Given(@"I have logged in with different user")]
        public void GivenIHaveLoggedInWithDifferentUser()
        {
            SecondUser.OtherSeller();
            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(2000);
                CommonMethods.test = CommonMethods.extent.StartTest("Check are we on Profile page ");
                Assert.AreEqual("Profile", SecondUser.localDriver.Title);
                CommonMethods.test.Log(LogStatus.Pass, "We are on Profile page ");
                Thread.Sleep(2000);
            }
            catch (Exception exp)
            {
                Console.WriteLine("We are at wrong page ");
                CommonMethods.test.Log(LogStatus.Fail, "It's not a Profile page" + exp.InnerException);
            }
        }
        
        [Given(@"I searched for the skill under Profile Page")]
        public void GivenISearchedForTheSkillUnderProfilePage()
        {
            SecondUser.SearchSellerDetails();
        }
        
        [Given(@"I checked the results on the search page")]
        public void GivenICheckedTheResultsOnTheSearchPage()
        {
            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(2000);
                CommonMethods.test = CommonMethods.extent.StartTest("Check Search Result page");
                Assert.AreEqual("Search", SecondUser.localDriver.Title);
                CommonMethods.test.Log(LogStatus.Pass, "We are at Search page ");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Search Page");
                Thread.Sleep(2000);
            }
            catch (Exception ex1)
            {
                Console.WriteLine("We are at wrong page ");
                CommonMethods.test.Log(LogStatus.Fail, "It's not a search page " + ex1.InnerException);
            }
        }
        
        [When(@"I clicked on searched profile")]
        public void WhenIClickedOnSearchedProfile()
        {
            SecondUser.ClickonProfile();
        }
        
        [Then(@"the searched profile should be displayed")]
        public void ThenTheSearchedProfileShouldBeDisplayed()
        {
            try
            {
                CommonMethods.ExtentReports();
                Thread.Sleep(2000);
                CommonMethods.test = CommonMethods.extent.StartTest("Check Service Detail page");
                Assert.AreEqual("Service Detail", SecondUser.localDriver.Title);
                CommonMethods.test.Log(LogStatus.Pass, "We are at service Detail page ");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Service Detail");
                Thread.Sleep(4000);
            }
            catch (Exception ex2)
            {
                Console.WriteLine("We are at wrong page ");
                CommonMethods.test.Log(LogStatus.Fail, "It's not a Service Detail page " + ex2.InnerException);
            }
        }
    }
}
