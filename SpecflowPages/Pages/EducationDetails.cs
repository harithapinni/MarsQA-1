using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
     public class EducationDetails
    {
        public string CollegeName { get; set; }
        public string CountryOfCollege { get; set; }
        public string Title { get; set; }

        public string Degree{ get; set; }

        public string   YearOfGraduation{get; set; }

        public string EducationPOPupMSG { get; set; }

        private  static IWebElement EducationTab  => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));


        private  static IWebElement AddNewBtn => Driver.driver.FindElement(By.CssSelector(".right:nth-child(6) > .ui"));

        private  static IWebElement CollegNam => Driver.driver.FindElement(By.Name("instituteName"));

        private   static IWebElement CountryDrop1 => Driver.driver.FindElement(By.Name("country"));

        private static IWebElement TitleDrop2 => Driver.driver.FindElement(By.Name("title"));

        private  static IWebElement Degree1 => Driver.driver.FindElement(By.Name("degree"));

        private  static IWebElement YearOFGraddrop => Driver .driver.FindElement(By.Name("yearOfGraduation"));

        private  static IWebElement AddBtn => Driver.driver.FindElement(By.CssSelector(".sixteen > .teal"));

        public static IWebElement UpdateIcon1 => Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[6]/span[1]/i[1]"));

        private static IWebElement UpdateBtn1 => Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[3]/input[1]"));

        private   static IWebElement DeleteIcon => Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[6]/span[2]/i[1]"));
        
        private static string Alertpopuppath = "//div[@class='ns-box-inner']";
        public static IWebElement Alertpopup => Driver.driver.FindElement(By.XPath(Alertpopuppath));



        public void AddEducation()
        {
            Driver.TurnOnWait();
            EducationTab.Click();
            AddNewBtn.Click();
            CollegNam.SendKeys(CollegeName);
            SelectElement Countrycol= new SelectElement(CountryDrop1);
            Countrycol.SelectByValue(CountryOfCollege);
            SelectElement Tiltlecol = new SelectElement(TitleDrop2);
            Tiltlecol.SelectByValue(Title);
            Degree1.SendKeys(Degree);
            SelectElement YearGrad = new SelectElement(YearOFGraddrop);
            YearGrad.SelectByValue(YearOfGraduation);
            AddBtn.Click();
            EducationPOPupMSG = Alertpopup.Text;


        }


        public void UpdateEducation()
        {
            Driver.TurnOnWait();
            EducationTab.Click();
            UpdateIcon1.Click();
            CollegNam.Clear();
            CollegNam.SendKeys(CollegeName);
            SelectElement Countrycol = new SelectElement(CountryDrop1);
            Countrycol.SelectByValue(CountryOfCollege);
            SelectElement Tiltlecol = new SelectElement(TitleDrop2);
            Tiltlecol.SelectByValue(Title);
            Degree1.Clear();
            Degree1.SendKeys(Degree);
            SelectElement YearGrad = new SelectElement(YearOFGraddrop);
            YearGrad.SelectByValue(YearOfGraduation);
            UpdateBtn1.Click();
            EducationPOPupMSG = Alertpopup.Text;

        }


        public void DeleteEducation()
        {
            DeleteIcon.Click();
            EducationPOPupMSG = Alertpopup.Text;

        }

    }
}
