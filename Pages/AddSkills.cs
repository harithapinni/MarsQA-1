using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Pages
{
    public class AddSkills
    {
        public string Skill { get; set; }
        public string SkillLevel { get; set; }
        public string SkillMessage { get; set; }
        //Add Skill tab webelements
        private static IWebElement Skilltab => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        private static IWebElement AddNewSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement AddSkillInput => Driver.driver.FindElement((By.Name("name")));
        //Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        private static IWebElement Skilldropdown => Driver.driver.FindElement(By.Name("level"));
        //Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
        private static IWebElement AddBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        private static string SkillAlertMsg = "//div[@class='ns-box-inner']";
        private static IWebElement AlertMsg => Driver.driver.FindElement(By.XPath(SkillAlertMsg));

        public void Skilldetails()

        {   //Skill tab 
            
            Skilltab.Click();
            //AddNewSkill
            AddNewSkill.Click();
            //Input for Skill field 
            AddSkillInput.SendKeys(Skill);
            //select level from the dropdown
            SelectElement objselect = new SelectElement(Skilldropdown);
            objselect.SelectByText(SkillLevel);
            Skilldropdown.Click();
            //Click on add button, record should be added
            AddBtn.Click();
            Driver.TurnOnWait();
            SkillMessage = AlertMsg.Text;
        }

        //Update Langauage details
        public void UpdateSkillDetails()
        {
            Skilltab.Click();
            //edit pen icon 
IWebElement Editicon = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            //click on editbutton
            Editicon.Click();
            //clear languagetext field 
            AddSkillInput.Clear();
            //assign  input to Language text field
            AddSkillInput.SendKeys(Skill);
            //create object
 SelectElement update = new SelectElement(Skilldropdown);
            update.SelectByValue(SkillLevel);
            //update btn element
IWebElement Updatebutton = Driver.driver.FindElement(By.XPath("//input[@value='Update'][1]"));
                //Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[6]/tr/td/div/span/input[1]"));
            Updatebutton.Click();
            Driver.TurnOnWait();
            SkillMessage = AlertMsg.Text;
        }

        public void Deletedetails()
        {
            Skilltab.Click();
            IWebElement Deletebutton = Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            Deletebutton.Click();
            //read popupmessage 
            SkillMessage = AlertMsg.Text;
        }



    }
}
