using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Pages
{ [Binding]
    public class AddEducation
    {
        public string Country { get; set; }
        public string University { get; set; }
        public string Title { get; set; }
        public int Degree { get; set; }
        public int GraduationYear { get; set; }
        public string EducationMessage { get; set; }
       
        private static IWebElement EducationTab => Driver.driver.FindElement(By.XPath("//a[@data-tab='third']"));
        private static IWebElement AddNewBtn => Driver.driver.FindElement(By.CssSelector(".right:nth-child(6) > .ui"));
        private static IWebElement UniversityName => Driver.driver.FindElement(By.Name("instituteName"));
        private static IWebElement Countryofcoll => Driver.driver.FindElement(By.Name("country"));
        //private static IWebElement Countryofcoll => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
        private static IWebElement TitleDropdown => Driver.driver.FindElement(By.Name("title"));
        private static IWebElement Degreeno => Driver.driver.FindElement(By.Name("degree"));
        private static IWebElement YearOfGraduation => Driver.driver.FindElement(By.Name("yearOfGraduation"));
        private static IWebElement AddBtn => Driver.driver.FindElement(By.CssSelector(".sixteen > .teal"));
        //public static IWebElement UpdateIcon1 => Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[6]/span[1]/i[1]"));
        //private static IWebElement DeleteIcon => Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[6]/span[2]/i[1]"));
        private static string Alertpopuppath = "//div[@class='ns-box-inner']";
        public static IWebElement Alertpopup => Driver.driver.FindElement(By.XPath(Alertpopuppath));
     
        //private static IWebElement Cancelbtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));

        public void CreateEducationDetails()
        {
            EducationTab.Click();
            AddNewBtn.Click();
            UniversityName.SendKeys(University);   
      SelectElement countrydrop = new SelectElement(Countryofcoll);
            countrydrop.SelectByText(Country);
      SelectElement Titledrop = new SelectElement(TitleDropdown);
            Titledrop.SelectByValue(Title);
            Degreeno.SendKeys(Degree.ToString());
       SelectElement GraduationYr1 = new SelectElement(YearOfGraduation);
            GraduationYr1.SelectByValue(GraduationYear.ToString());
            AddBtn.Click();
            Driver.TurnOnWait();
            EducationMessage = Alertpopup.Text;

        }
        public void UpdateEducationDetal()
        {
            EducationTab.Click();  
 IWebElement Editbtn = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
            Editbtn.Click();
            UniversityName.Clear();
            UniversityName.SendKeys(University);
  SelectElement Titledrop1 = new SelectElement(TitleDropdown);
            Titledrop1.SelectByValue(Title);
            Degreeno.Clear();
            Degreeno.SendKeys(Degree.ToString());
 SelectElement GraduationYr = new SelectElement(YearOfGraduation);
            GraduationYr.SelectByValue(GraduationYear.ToString());
IWebElement Updatebtn = Driver.driver.FindElement(By.XPath("//div[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input"));
 SelectElement coundrop = new SelectElement(Countryofcoll);
            coundrop.SelectByValue(Country);
            Driver.TurnOnWait();
            Updatebtn.Click();
            EducationMessage = Alertpopup.Text;
        }
        
        public void DeleteEducation()
        {
            EducationTab.Click();
            IWebElement Cancelbtn = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[2]/i"));
            Driver.TurnOnWait();
            Cancelbtn.Click();
            EducationMessage = Alertpopup.Text;
        }


    }

}
