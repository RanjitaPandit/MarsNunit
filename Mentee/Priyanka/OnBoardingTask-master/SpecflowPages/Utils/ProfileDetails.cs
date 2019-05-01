using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using SpecflowPages.Utils.Inputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecflowPages.Utils
{
    public class ProfileDetails
    {
        public static IWebDriver localDriver = Driver.driver;

        public static void ClickonProfile()
        {
            CommonMethods.ButtonClick(localDriver, "XPath", ProfileDetailInput.profileTab);
            Thread.Sleep(3000);
        }

        public static void ClickonDescriptionLink()
        {
            CommonMethods.ButtonClick(localDriver, "XPath", ProfileDetailInput.descriptionIcon);
        }

        public static void AddDescription()
        {
            CommonMethods.TextBox(localDriver, "XPath", ProfileDetailInput.descriptionField, ProfileDetailInput.descriptionValue);
            CommonMethods.ButtonClick(localDriver, "XPath", ProfileDetailInput.descriptionSave);
        }


        public static void ClickonSkillsTab()
        {
            CommonMethods.ButtonClick(localDriver, "XPath", ProfileDetailInput.skillTab);
            Thread.Sleep(3000);
        }

        public static void AddSkills()
        {
            CommonMethods.ButtonClick(localDriver, "XPath", ProfileDetailInput.addNewSkillsToAdd);
            CommonMethods.TextBox(localDriver, "XPath", ProfileDetailInput.addSkillField, ProfileDetailInput.addSkillValue);
            CommonMethods.DropdownbyValue(localDriver, "XPath", ProfileDetailInput.chooseSkillDropdown, ProfileDetailInput.chooseSkillValue1);
            CommonMethods.ButtonClick(localDriver, "XPath", ProfileDetailInput.addFilledSkill);
        }

        public static void ClickonEducationTab()
        {
            CommonMethods.ButtonClick(localDriver, "XPath", ProfileDetailInput.educationTab);
            Thread.Sleep(3000);
        }

        public static void AddEducationDetails()
        {
            CommonMethods.ButtonClick(localDriver, "XPath", ProfileDetailInput.addEducationToAdd);
            CommonMethods.TextBox(localDriver, "XPath", ProfileDetailInput.collegeName, ProfileDetailInput.collegeNameValue);
            CommonMethods.DropdownbyValue(localDriver, "XPath", ProfileDetailInput.countryofCollege, ProfileDetailInput.countryCollegeValue);
            CommonMethods.DropdownbyValue(localDriver, "XPath", ProfileDetailInput.titile, ProfileDetailInput.titleValue);
            CommonMethods.TextBox(localDriver, "XPath", ProfileDetailInput.degree, ProfileDetailInput.degreeValue);
            CommonMethods.DropdownbyValue(localDriver, "XPath", ProfileDetailInput.yearOfGrad, ProfileDetailInput.yearofGradValue);
            CommonMethods.ButtonClick(localDriver, "XPath", ProfileDetailInput.addFilledEducation);
        }

        public static void ClickonCertificationsTab()
        {
            CommonMethods.ButtonClick(localDriver, "XPath", ProfileDetailInput.certificationTab);
            Thread.Sleep(3000);
        }

        public static void AddCertifications()
        {
            CommonMethods.ButtonClick(localDriver, "XPath", ProfileDetailInput.addCertificationToAdd);
            CommonMethods.TextBox(localDriver, "XPath", ProfileDetailInput.certificateField, ProfileDetailInput.certificateFieldValue);
            CommonMethods.TextBox(localDriver, "XPath", ProfileDetailInput.certificateFrom, ProfileDetailInput.certificateFromValue);
            CommonMethods.DropdownbyValue(localDriver, "XPath", ProfileDetailInput.certificationYear, ProfileDetailInput.certifiedInYear);
            CommonMethods.ButtonClick(localDriver, "XPath", ProfileDetailInput.addFilledCertificationDetails);
        }

        public static void AddMoreDetails()
        {
            CommonMethods.ButtonClick(localDriver, "XPath", ProfileDetailInput.availabilityLink);
            CommonMethods.DropdownbyValue(localDriver, "XPath", ProfileDetailInput.availabilityDropDown, ProfileDetailInput.availabilityFullTime);
            Thread.Sleep(2000);
            CommonMethods.ButtonClick(localDriver, "XPath", ProfileDetailInput.hoursLink);
            CommonMethods.DropdownbyValue(localDriver, "XPath", ProfileDetailInput.availabilityHourDD, ProfileDetailInput.availabilityHour2);
            Thread.Sleep(2000);
            CommonMethods.ButtonClick(localDriver, "XPath", ProfileDetailInput.earnTargetLink);
            CommonMethods.DropdownbyValue(localDriver, "XPath", ProfileDetailInput.earnTargetDD, ProfileDetailInput.earnTargetVal2);
            Thread.Sleep(2000);
        }
    }
}
