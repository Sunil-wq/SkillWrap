using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowPages
{
    public class ConstantUtils
    {
        //Base Url
        public static string Url = "http://www.skillswap.pro/";

        //ScreenshotPath
        //  public static string ScreenshotPath = @"C:\Users\Owner\source\repos\SpecflowTests-Base\SpecflowTests-Base\SpecflowTests\SpecflowPages\TestReports\Screenshots\";

        //ExtentReportsPath
        // public static string ReportsPath = @"C:\Users\Owner\source\repos\SpecflowTests-Base\SpecflowTests-Base\SpecflowTests\SpecflowPages\TestReports\Test.html";

        //ReportXML Path
        //  public static string ReportXMLPath = @"C:\Users\Owner\source\repos\SpecflowTests-Base\SpecflowTests-Base\SpecflowTests\SpecflowPages\TestReports\ReportXML.xml";


        //specflowTests/bin/Debug
        public static String strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        public static string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);

        //ScreenshotPath
        public static string ScreenshotPath = System.IO.Path.Combine(strWorkPath, "Screenshots");
      
        //ExtentReportsPath
        public static string ReportsPath = System.IO.Path.Combine(strWorkPath, "ReportHTML.html");

        //ReportXML Path
        public static string ReportXMLPath = System.IO.Path.Combine(strWorkPath, "ReportXML.xml");



    }
}
