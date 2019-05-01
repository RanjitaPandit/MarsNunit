using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using NUnit.Framework;
using SpecflowPages.Utils;
using System.Threading;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class AddProfileDetailsSteps
    {
        [Given(@"I clicked on the Profile link after logged in")]
        public void GivenIClickedOnTheProfileLinkAfterLoggedIn()
        {
            ProfileDetails.ClickonProfile();
            try
            {
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.extent.StartTest("Check are we on profile page ");
                Thread.Sleep(3000);
                Assert.AreEqual("Profile", ProfileDetails.localDriver.Title);
                CommonMethods.test.Log(LogStatus.Pass, "We are on Profile page ");
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("We are at wrong page ");
                CommonMethods.test.Log(LogStatus.Fail, "It's not a Profile page " + ex.InnerException);
            }
        }
        
        [Given(@"I clicked on the skills tab under Profile page")]
        public void GivenIClickedOnTheSkillsTabUnderProfilePage()
        {
            ProfileDetails.ClickonSkillsTab();
            Thread.Sleep(2000);
           
        }
        
        [When(@"I add a new skill")]
        public void WhenIAddANewSkill()
        {
            ProfileDetails.AddSkills();
            Thread.Sleep(4000);
        }

        [Then(@"that skill should be displayed on my listings")]
        public void ThenThatSkillShouldBeDisplayedOnMyListings()
        {
            try
            {
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.extent.StartTest("Add new skill");
                Thread.Sleep(3000);
                string ActualResult = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[1]")).Text;
                Assert.AreEqual("Selenium Webdriver", ActualResult);
                CommonMethods.test.Log(LogStatus.Pass, "Skill added Successfully ");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "NewSkillAdded");
                Thread.Sleep(3000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("We are at wrong page ");
                CommonMethods.test.Log(LogStatus.Fail, "Problem in adding new Skill " + ex.InnerException);
            }
        }
    }
}
