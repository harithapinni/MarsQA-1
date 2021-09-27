using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class SkillDetails

    {

        public string AddSkill { get; set; }


         public string SkillLevel { get; set; }

         public string SkillMessage { get; set; }
        public static IWebElement SkillTab => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        public static IWebElement AddNewSkill => Driver.driver.FindElement(By.CssSelector(".ui:nth-child(3) .ui .ui"));

        public static IWebElement EnterSkills => Driver.driver.FindElement((By.Name("name")));


        public static IWebElement DropDown1 => Driver.driver.FindElement(By.Name("level"));

        public static IWebElement AddSkillBtn => Driver.driver.FindElement(By.CssSelector(".buttons-wrapper > .teal"));

        public static IWebElement DeleteIcon => Driver.driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));


        private static string Alertpopuppath = "//div[@class='ns-box-inner']";
        public static IWebElement Alertpopup => Driver.driver.FindElement(By.XPath(Alertpopuppath));



        public void AddskillDeatails()
        {
            //slecting Skill tab
            Driver.TurnOnWait();
            SkillTab.Click();
            AddNewSkill.Click();
            //seller enter skills in the fields.
            EnterSkills.SendKeys(AddSkill);
            SelectElement skilllev = new SelectElement(DropDown1);
            skilllev.SelectByValue(SkillLevel);
            AddSkillBtn.Click();
            SkillMessage = Alertpopup.Text;
        }

        public void UpdateSkillDetails()
        {
            //Updating SELLER skill by clicking pen icon
            Driver.TurnOnWait();
            SkillTab.Click();
            IWebElement SkillUpdateIcon = Driver.driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[6]/tr[1]/td[3]/span[1]/i[1]"));
            SkillUpdateIcon.Click();
            EnterSkills.Clear();
            EnterSkills.SendKeys(AddSkill);
            SelectElement skilllev2 = new SelectElement(DropDown1);
            skilllev2.SelectByValue(SkillLevel);
            IWebElement UpdateBtn = Driver.driver.FindElement(By.CssSelector(".buttons-wrapper > .teal"));
            UpdateBtn.Click();
            SkillMessage = Alertpopup.Text;

        }

        public static void ValidateEditskill()
        {
            Driver.driver.Navigate().Refresh();
            IWebElement CreateSkil = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            CreateSkil.Click();
            Driver.TurnOnWait();
            IWebElement upskillnm = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[6]/tr/td[1]"));
            Assert.That(upskillnm.Text == "programming in restsharp", "actual skill and expcted skill did not match");
           
        }

        public void DeleteSkill()
        {
            Driver.TurnOnWait();
            SkillTab.Click();
            DeleteIcon.Click();
            SkillMessage = Alertpopup.Text;
        }

        //protected bool IsDisplayed(By locator, int maxWaitTime)
        //{
        //    try
        //    {
        //        WebDriverWait wait = new WebDriverWait(Driver.driver, System.TimeSpan.FromSeconds(maxWaitTime));
        //        wait.Until(Driver.driver => Driver.driver.FindElement(locator));
        //        return true;
        //    }
        //    catch (OpenQA.Selenium.WebDriverTimeoutException)
        //    {
        //        return false;
        //    }

       


    }



}

    






