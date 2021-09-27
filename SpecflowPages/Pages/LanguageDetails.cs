using MarsQA_1.Helpers;
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
   public class LanguageDetails
    {   // clicking "AddNew" action button

        public string Language { get; set; }

        public string Level { get; set; }

        public string LanguageMessage { get; set; }


        private static IWebElement AddNewBtn => Driver.driver.FindElement(By.CssSelector(".ui:nth-child(2) > .row .ui .ui"));
        private static IWebElement EntrLang => Driver.driver.FindElement(By.Name("name"));
        private static IWebElement DropDown => Driver.driver.FindElement(By.Name("level"));
        private static IWebElement AddBtn => Driver.driver.FindElement(By.CssSelector(".six > .teal"));

        private static IWebElement UpdateIcon => Driver.driver.FindElement(By.CssSelector("div.twelve.wide.column.scrollTable>div.form-wrapper>table.ui.fixed.table>tbody>tr>td.right.aligned>span.button>i.outline.write.icon"));
        private static IWebElement UpdateVal => Driver.driver.FindElement(By.Name("name"));
        private static IWebElement UpdateBtn => Driver.driver.FindElement(By.CssSelector(".buttons-wrapper > .teal"));
        private static IWebElement DeleteIcon => Driver.driver.FindElement(By.XPath(" //i[@class='remove icon']"));

        private static string Alertpopuppath = "//div[@class='ns-box-inner']";
        public static IWebElement Alertpopup => Driver.driver.FindElement(By.XPath(Alertpopuppath));



        public  void AddLang()
        {


            AddNewBtn.Click();
            //ExcelLibHelper.PopulateInCollection( @"MarsQA-1\SpecflowTests\Data\Data.xlsx", "Languages");
            EntrLang.SendKeys(Language);
            SelectElement LevelSelect = new SelectElement(DropDown);
            LevelSelect.SelectByValue(Level);
            AddBtn.Click();
            Driver.TurnOnWait();
            LanguageMessage = Alertpopup.Text;

        }

        public void UpdateLang()
        {
            Driver.TurnOnWait();
            UpdateIcon.Click();
            EntrLang.Clear();
            UpdateVal.SendKeys(Language);
            SelectElement LevelSelect1 = new SelectElement(DropDown);
            LevelSelect1.SelectByValue(Level);
            UpdateBtn.Click();
            LanguageMessage = Alertpopup.Text;

        }



        public void DeleteLang()

        {

            Driver.TurnOnWait();
            DeleteIcon.Click();
            LanguageMessage = Alertpopup.Text;

        }

       



   }    }

