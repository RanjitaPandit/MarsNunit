using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;
using SpecflowPages.Utils;
using OpenQA.Selenium;
using static SpecflowPages.CommonMethods;
using System.Threading;
using SpecflowPages.Utils.Inputs;

namespace SpecflowPages.Utils
{
    public class ShareSkillDetails
    {
        public static IWebDriver localDriver = Driver.driver;

        //ShareSkills - gives complete detail of the user's skills
    
        public static void ClickonShareSkill()
        {
            CommonMethods.ButtonClick(localDriver, "XPath", XPathInput.shareSkillLink);
            //Thread.Sleep(3000);
        }

        public static void ServiceListingFields()
        {
           //localDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);

            CommonMethods.TextBox(localDriver, "XPath", XPathInput.titileField, SkillsInput.titleText);
            CommonMethods.TextBox(localDriver, "XPath", XPathInput.descriptionField, SkillsInput.description);
            CommonMethods.DropdownbyValue(localDriver, "XPath", XPathInput.ssDropdown1, SkillsInput.ssDropdown1Value);
            //Thread.Sleep(6000);
            CommonMethods.DropdownbyValue(localDriver, "XPath", XPathInput.ssDropdown2, SkillsInput.ssDropdown2IValue);
            CommonMethods.TextBox(localDriver, "XPath", XPathInput.tagsField, SkillsInput.tags);
            CommonMethods.RodioButton(localDriver, "XPath", XPathInput.serviceOneOff);
            //CommonMethods.RodioButton(localDriver, "XPah", XPathInput.locationOnsite);
            //Thread.Sleep(2000);
            
            //Calendar Element
            //CommonMethods.ElementVisible(localDriver, "XPath", XPathInput.startDate);
            CommonMethods.TextBox(localDriver, "XPath", XPathInput.startDate, SkillsInput.startDateValue);
            CommonMethods.TextBox(localDriver, "XPath", XPathInput.endDate, SkillsInput.endDateValue);
            //Thread.Sleep(3000);
            CommonMethods.ButtonClick(localDriver, "XPath", XPathInput.checkBoxMon);
            CommonMethods.TextBox(localDriver, "XPath", XPathInput.startTimeMon, SkillsInput.monStartTime);
            CommonMethods.TextBox(localDriver, "XPath", XPathInput.endTimeMon, SkillsInput.monEndTime);
            //Thread.Sleep(3000);
            CommonMethods.ButtonClick(localDriver, "XPath", XPathInput.checkBoxWed);
            CommonMethods.TextBox(localDriver, "XPath", XPathInput.startTimeWed, SkillsInput.wedStartTime);
            CommonMethods.TextBox(localDriver, "XPath", XPathInput.endTimeWed, SkillsInput.wedEndTime);
            Thread.Sleep(3000);

            CommonMethods.RodioButton(localDriver, "XPath", XPathInput.skillexRadBtn1);
            //CommonMethods.RodioButton(localDriver, "XPath", XPathInput.skillexRadBtn2);
            //CommonMethods.TextBox(localDriver, "XPath", XPathInput.creditField, SkillsInput.creditValue);
            CommonMethods.TextBox(localDriver, "XPath", XPathInput.skillExText, SkillsInput.skillExValue);
           // CommonMethods.UploadLink(localDriver, "XPath", XPathInput.uploadButton, SkillsInput.uplaodFilePath);
            Thread.Sleep(2000);
            CommonMethods.RodioButton(localDriver, "XPath", XPathInput.active);
        }
          
        public static void ClickonSaveButton()
        {
            CommonMethods.ButtonClick(localDriver, "XPath", XPathInput.saveButton);
            Thread.Sleep(5000);
        }

    }
}

