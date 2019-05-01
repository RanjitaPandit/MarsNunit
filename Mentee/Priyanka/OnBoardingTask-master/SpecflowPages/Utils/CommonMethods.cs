using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace SpecflowPages
{
    public class CommonMethods
    {
        //Screenshots
        #region screenshots
        public class SaveScreenShotClass
        {
            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ConstantUtils.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                fileName.Append(".jpeg");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Jpeg);
                return fileName.ToString();
            }
        }
        #endregion


        //ExtentReports
        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;
        public static void ExtentReports()
        {
            extent = new ExtentReports(ConstantUtils.ReportsPath, false, DisplayOrder.NewestFirst);
            extent.LoadConfig(ConstantUtils.ReportXMLPath);
        }

        #endregion


        //Element Present
        #region Element Present
        //Method to check the element is showing on screen
        public static bool ElementVisible(IWebDriver driver, string Locator, string Lvalue)
        {
            try
            {
                if (Locator == "Id")
                    return driver.FindElement(By.Id(Lvalue)).Displayed && driver.FindElement(By.Id(Lvalue)).Enabled;
                else if (Locator == "XPath")
                    return driver.FindElement(By.XPath(Lvalue)).Displayed && driver.FindElement(By.XPath(Lvalue)).Enabled;
                else if (Locator == "CSS")
                    return driver.FindElement(By.CssSelector(Lvalue)).Displayed && driver.FindElement(By.CssSelector(Lvalue)).Enabled;
                else
                {
                    Console.WriteLine("Invalid Locator value");
                    return false;
                }
            }
            catch (NoSuchElementException)
            {
                return false;

            }
        }
        public static bool isElementPresent(By by)
        {
            try
            {
                Driver.driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        #endregion


        //Element TextBox
        #region TextBox
        public static void TextBox(IWebDriver driver, string elementLocatorType, string locatorValue, string value)
        {
            switch (elementLocatorType)
            {
                case "XPath":
                    driver.FindElement(By.XPath(locatorValue)).SendKeys(value);
                    break;
                case "Id":
                    driver.FindElement(By.Id(locatorValue)).SendKeys(value);
                    break;
                default:
                case "Class":
                    driver.FindElement(By.ClassName(locatorValue)).SendKeys(value);
                    break;
            }
        }

        internal static void UploadLink(IWebDriver localDriver, string v, string uploadButton, string uplaodFilePath)
        {
            throw new NotImplementedException();
        }

        #endregion

        //Element Button
        #region ButtonClick
        public static void ButtonClick(IWebDriver driver, string elementLocatorType, string locatorValue)
        {
            switch (elementLocatorType)
            {
                case "XPath":
                    driver.FindElement(By.XPath(locatorValue)).Click();
                    break;
                case "Id":
                    driver.FindElement(By.Id(locatorValue)).Click();
                    break;
                default:
                case "Class":
                    driver.FindElement(By.ClassName(locatorValue)).Click();
                    break;
            }
        }

        #endregion

        //Element Dropdown by Value
        #region Dropdown
        public static void DropdownbyValue(IWebDriver driver, string elementLocatorType, string locatorValue, string value)
        {
            switch (elementLocatorType)
            {
                case "XPath":
                    var optionXPath = driver.FindElement(By.XPath(locatorValue));
                    var selectElement = new SelectElement(optionXPath);
                    Thread.Sleep(5000);
                    selectElement.SelectByText(value);
                    break;
                case "Id":
                    var optionId = driver.FindElement(By.Id(locatorValue));
                    var selectElementId = new SelectElement(optionId);
                    Thread.Sleep(5000);
                    selectElementId.SelectByIndex(2);
                    break;
                default:
                case "Class":
                    var optionClass = driver.FindElement(By.Id(locatorValue));
                    var selectElementClass = new SelectElement(optionClass);
                    Thread.Sleep(5000);
                    selectElementClass.SelectByIndex(4); ;
                    break;
            }
        }
        #endregion

        //Element RadioButton
        #region RadioButton
        public static void RodioButton(IWebDriver driver, string elementLocatorType, string locatorValue)
        {
            switch (elementLocatorType)
            {
                case "XPath":
                    driver.FindElement(By.XPath(locatorValue)).Click();
                    break;
                case "Id":
                    driver.FindElement(By.Id(locatorValue)).Click();
                    break;
                default:
                case "Class":
                    driver.FindElement(By.ClassName(locatorValue)).Click();
                    break;
            }
        }
        #endregion

        //Element DatePicker

    }
}