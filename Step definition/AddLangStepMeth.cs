using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Step_definition
{
    [Binding]
    public  class AddLangStepMeth
    {

        MarsQA_1.Pages.AddLanguage profileLanguageobj = new Pages.AddLanguage();
        [Given(@"seller enter language as ""(.*)""")]
        public void GivenSellerEnterLanguageAs(string Language)
        {
            profileLanguageobj.Language = Language;
        }

        [Given(@"choose language level as ""(.*)""")]
        public void GivenChooseLanguageLevelAs(string Level)
        {
            
            profileLanguageobj.Level = Level;
        }

        [When(@"click on Add action button")]
        public void WhenClickOnAddActionButton()
        {
            profileLanguageobj.AddLanguagedetails();
        }

        [Then(@"language should be added to your profile\. The alert message,""(.*)""should be displayed on the top right corner\.")]
        public void ThenLanguageShouldBeAddedToYourProfile_TheAlertMessageShouldBeDisplayedOnTheTopRightCorner_(string message)
        { 
           Assert.AreEqual(message, profileLanguageobj.LanguageMessage);
            Console.WriteLine(message);
        }

        [Given(@"seller update language as ""(.*)""")]
        public void GivenSellerUpdateLanguageAs(string Language)
        {
            profileLanguageobj.Language = Language;
        }

        [Given(@"update language level as ""(.*)""")]
        public void GivenUpdateLanguageLevelAs(string Level)
        {
            profileLanguageobj.Level = Level;
        }

        [When(@"click on Update button")]
        public void WhenClickOnUpdateButton()
        {
            profileLanguageobj.UpdateLanguageDetails();
        }

        [Then(@"language should be updated\. The alert message,""(.*)""should be displayed on the top right corner\.")]
        public void ThenLanguageShouldBeUpdated_TheAlertMessageShouldBeDisplayedOnTheTopRightCorner_(string message)
        {
            Assert.AreEqual(message, profileLanguageobj.LanguageMessage);
            Console.WriteLine("Test is Passed");

            
        }

        [When(@"seller choose to delete a language ""(.*)""")]
        public void WhenSellerChooseToDeleteALanguage(string Language)
        {
            profileLanguageobj.Deletedetails();
        }

        [Then(@"language should be deleted\. The alert message,""(.*)""should be displayed on the top right corner\.")]
        public void ThenLanguageShouldBeDeleted_TheAlertMessageShouldBeDisplayedOnTheTopRightCorner_(string message)
        {
            Assert.AreEqual(message, profileLanguageobj.LanguageMessage);
            Console.WriteLine("Test is Passed");

        }


    }
}
