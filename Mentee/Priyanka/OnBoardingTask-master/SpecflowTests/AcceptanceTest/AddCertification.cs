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
    public class AddCertification
    {
        [Given(@"I clicked on the Certifications tab under Profile page")]
        public void GivenIClickedOnTheCertificationsTabUnderProfilePage()
        {
            ProfileDetails.ClickonCertificationsTab();
      
        }
        
        [When(@"I add Certification details")]
        public void WhenIAddCertificationDetails()
        {
            ProfileDetails.AddCertifications();
        }
        
        [Then(@"that Certification detail should be displayed on my listings")]
        public void ThenThatCertificationDetailShouldBeDisplayedOnMyListings()
        {
            try
            {
                CommonMethods.ExtentReports();
                CommonMethods.test = CommonMethods.extent.StartTest("Add Certification Details");
                Thread.Sleep(3000);
                string ActualResult = Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[1]")).Text;
                Assert.AreEqual("ISTQB", ActualResult);
                CommonMethods.test.Log(LogStatus.Pass, "Certification details added Successfully ");
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Successfully added new certification");
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
