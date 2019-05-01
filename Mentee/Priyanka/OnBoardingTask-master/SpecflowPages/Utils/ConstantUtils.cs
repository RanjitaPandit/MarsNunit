using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowPages
{
    public class ConstantUtils
    {
        //Base Url
        public static string Url = "http://www.skillswap.pro/";

        //public static string CurrentDirectory { get; set; }

        // This will get the current WORKING directory (i.e. \bin\Debug)
        // static string workingDirectory = Environment.CurrentDirectory;
        // or: Directory.GetCurrentDirectory() gives the same result
        // This will get the current PROJECT directory
        //static string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

        static string workingDirectory = Environment.CurrentDirectory;
        static string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

        //ScreenshotPath
        //public static string ScreenshotPath = @"C:\Users\chand\Desktop\Remote\Onboarding and Competition Tasks\Mars\SpecflowTests-Base\SpecflowTests-Base\SpecflowTests\SpecflowPages\TestReports\Screenshots\";
        //public static string ScreenshotPath = @"E:\2019 MVP\SpecflowTests-Base\SpecflowTests-Base\SpecflowTests-Base\SpecflowTests\SpecflowPages\TestReports\Screenshots";
        public static string ScreenshotPath = Directory.GetCurrentDirectory() + @"\TestResults\Screenshots\";
        
        
        //DirectoryInfo directory = new DirectoryInfo(Path.GetFullPath(Path.Combine(currentDir, @"..\..\" + localPath)));

            
        //ExtentReportsPath
        //public static string ReportsPath = @"C:\Users\chand\Desktop\Remote\Onboarding and Competition Tasks\Mars\SpecflowTests-Base\SpecflowTests-Base\SpecflowTests\SpecflowPages\TestReports\Test.html";
        public static string ReportsPath = Directory.GetCurrentDirectory() + @"\ReportHTML.html";

        //ReportXML Path
        //public static string ReportXMLPath = @"C:\Users\chand\Desktop\Remote\Onboarding and Competition Tasks\Mars\SpecflowTests-Base\SpecflowTests-Base\SpecflowTests\SpecflowPages\TestReports\ReportXML.xml";
        public static string ReportXMLPath = Directory.GetCurrentDirectory() + @"\ReportXML.xml";



    }
}
