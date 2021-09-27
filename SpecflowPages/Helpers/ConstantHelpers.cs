﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class ConstantHelpers
    {
        //Base Url
        public static string Url = "http://localhost:5000";

        //ScreenshotPath
        //public static string ScreenshotPath = "";
        public static string ScreenshotPath = getCodeDirectory() + @"\TestReports\Screenshots\";
        //ExtentReportsPath
        //public static string ReportsPath = "";
        public static string ReportsPath = getCodeDirectory() + @"\TestReports\Report.html";
        //ReportXML Path
        //public static string ReportXMLPath = "";
        public static string ReportXMLPath = getCodeDirectory() + @"\TestReports\XML";
        public static string getCodeDirectory()
        {
            var filepath = System.AppDomain.CurrentDomain.BaseDirectory;
            return filepath + @"..\..\";
        }

        /*//ScreenshotPath
        public static string ScreenshotPath = "";

        //ExtentReportsPath
        public static string ReportsPath = "";

        //ReportXML Path
        public static string ReportXMLPath = "";*/
    }

   

}
