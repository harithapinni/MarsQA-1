using MarsQA_1.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Step_definition
{
    [Binding]
    class AddSkillMeth
    {
        AddSkills Skillsobj = new AddSkills();

        [Given(@"seller enter skill as ""(.*)""")]
        public void GivenSellerEnterSkillAs(string Skill)
        {
            Skillsobj.Skill = Skill;
        }

        [Given(@"choose skill level as ""(.*)""")]
        public void GivenChooseSkillLevelAs(string SkillLevel)
        {
            Skillsobj.SkillLevel = SkillLevel;
        }

        [When(@"click on Add button")]
        public void WhenClickOnAddButton()
        {
            Skillsobj.Skilldetails();
        }

        [Then(@"skill should be added to your profile\. The alert message,""(.*)""should be displayed on the top right corner\.")]
        public void ThenSkillShouldBeAddedToYourProfile_TheAlertMessageShouldBeDisplayedOnTheTopRightCorner_(string message)
        {
            Assert.AreEqual(message, Skillsobj.SkillMessage);
            Console.WriteLine("Test is passed");
        }

        [Given(@"seller update skill as ""(.*)""")]
        public void GivenSellerUpdateSkillAs(string Skill)
        {
            Skillsobj.Skill = Skill;
        }

        [Given(@"update skill level as ""(.*)""")]
        public void GivenUpdateSkillLevelAs(string SkillLevel)
        {
            Skillsobj.SkillLevel = SkillLevel;
        }

        [When(@"click on update skill button")]
        public void WhenClickOnUpdateSkillButton()
        {
            Skillsobj.UpdateSkillDetails();
        }

        [Then(@"skill should be updated\.The alert message,""(.*)""should be displayed on the top right corner\.")]
        public void ThenSkillShouldBeUpdated_TheAlertMessageShouldBeDisplayedOnTheTopRightCorner_(string message)
        {
            Assert.AreEqual(message, Skillsobj.SkillMessage);
            Console.WriteLine("Test is passed");
        }
        [When(@"click on delete skill button as ""(.*)""")]
        public void WhenClickOnDeleteSkillButtonAs(string Skill)
        {
            Skillsobj.Deletedetails();
        }

        [Then(@"skill should be deleted\.The alert message,""(.*)""should be displayed on the top right corner\.")]
        public void ThenSkillShouldBeDeleted_TheAlertMessageShouldBeDisplayedOnTheTopRightCorner_(string message)
        {
            Assert.AreEqual(message, Skillsobj.SkillMessage);
            Console.WriteLine("Test is passed");
        }


       

    }
}
