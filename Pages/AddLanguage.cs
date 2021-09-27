using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Pages
{  
    public class AddLanguage
    {
        public string Language{get; set;}
        public string Level { get; set; }
        public string LanguageMessage { get; set; }
        //Add language tab  Webelements
        private static IWebElement AddNewbtn => Driver.driver.FindElement(By.CssSelector(".ui:nth-child(2) > .row .ui .ui"));
        private static IWebElement AddLanguageText => Driver.driver.FindElement(By.Name("name"));
        private static IWebElement LanguageLevel => Driver.driver.FindElement(By.Name("level"));
        private static IWebElement Addbutton => Driver.driver.FindElement(By.CssSelector(".six > .teal"));
        private static string Alertpopuppath = "//div[@class='ns-box-inner']";
        private static IWebElement Alertpopup => Driver.driver.FindElement(By.XPath(Alertpopuppath));

        public void AddLanguagedetails()
        {   //click on addnewbtn
            AddNewbtn.Click();
            //assign input language text
            AddLanguageText.SendKeys(Language);
            //Select language level
            SelectElement objselect = new SelectElement(LanguageLevel);
            objselect.SelectByText(Level);
            //Click on Addbutton
            Addbutton.Click();
            Driver.TurnOnWait();
            //read message 
            LanguageMessage = Alertpopup.Text;
        }
        //Update Langauage details
        public void UpdateLanguageDetails()
        {   
            //Driver.driver.Navigate().Refresh();
            //edit pen icon 
  IWebElement EditPenBtn = Driver.driver.FindElement(By.CssSelector(".ui:nth-child(2) > .row:nth-child(1) .outline:nth-child(1)"));
   
            EditPenBtn.Click();
            //update btn element
  IWebElement UpdatePenBtn = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
           //clear languagetext field 
            AddLanguageText.Clear();
            //assign  input to Language text field
            AddLanguageText.SendKeys(Language);
            //create object
            SelectElement update = new SelectElement(LanguageLevel);
            update.SelectByValue(Level);
            Driver.TurnOnWait();
            UpdatePenBtn.Click();
            LanguageMessage = Alertpopup.Text;
        }
        public void Deletedetails()
        {
            IWebElement Cancelbutton = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]"));
            Cancelbutton.Click();
            //read popupmessage 
            LanguageMessage = Alertpopup.Text;
        }



    }
}
