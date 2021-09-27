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
  public  class AddEducationStepMeth
    {
        AddEducation Educationobj = new AddEducation();

        [Given(@"seller enter university as ""(.*)""")]
        public void GivenSellerEnterUniversityAs(string university)
        {
            Educationobj.University = university;
        }

        [Given(@"choose country  as ""(.*)""")]
        public void GivenChooseCountryAs(string country)
        {
            Educationobj.Country = country;
        }

     

        [Given(@"title as ""(.*)""")]
        public void GivenTitleAs(string title)
        {
            Educationobj.Title = title;



        }
        [Given(@"degree as (.*)")]
        public void GivenDegreeAs(int degree)
        {
            Educationobj.Degree = degree;
        }

        [Given(@"choose year as (.*)")]
        public void GivenChooseYearAs(int graduationyr)
        {
            Educationobj.GraduationYear = graduationyr;
        }

        [When(@"click on Add button in Education")]
        public void WhenClickOnAddButtonInEducation()
        {
            Educationobj.CreateEducationDetails();
        }

        [Then(@"Education should be added to Education tab\. The alert message,""(.*)""should be displayed on the top right corner\.")]
        public void ThenEducationShouldBeAddedToEducationTab_TheAlertMessageShouldBeDisplayedOnTheTopRightCorner_(string message)
        {
            Assert.AreEqual(message, Educationobj.EducationMessage);
            Console.WriteLine("Test is passed");
        }
        [Given(@"seller Update university as ""(.*)""")]
        public void GivenSellerUpdateUniversityAs(string university)
        {
            Educationobj.University = university;
        }

        [Given(@"select country  as ""(.*)""")]
        public void GivenSelectCountryAs(string country)
        {
            Educationobj.Country = country;
        }

        [Given(@"choose title as ""(.*)""")]
        public void GivenChooseTitleAs(string title)
        {
            Educationobj.Title = title;
        }

        [Given(@"years degree as (.*)")]
        public void GivenYearsDegreeAs(int degree)
        {
            Educationobj.Degree = degree;
        }

        [Given(@"select year as (.*)")]
        public void GivenSelectYearAs(int graduationyr)
        {
            Educationobj.GraduationYear = graduationyr;
        }

        [When(@"click  Update button")]
        public void WhenClickAddButton()
        {
            Educationobj.UpdateEducationDetal();
        }
        [Then(@"Education should be updated\.The alert message,""(.*)""should be displayed on the top right corner\.")]
        public void ThenEducationShouldBeUpdated_TheAlertMessageShouldBeDisplayedOnTheTopRightCorner_(string message)
        {
            Assert.AreEqual(message, Educationobj.EducationMessage);
            Console.WriteLine("Test is passed");
        }
        /*[When(@"click  delete button")]
        public void WhenClickDeleteButton()
        {
            Educationobj.DeleteEducation();
        }

        [Then(@"Education should be deleted\.The alert message,""(.*)""should be displayed on the top right corner\.")]
        public void ThenEducationShouldBeDeleted_TheAlertMessageShouldBeDisplayedOnTheTopRightCorner_(string message)
        {
            Assert.AreEqual(message, Educationobj.EducationMessage);
            Console.WriteLine("Test is passed");
        }*/
        [When(@"click  delete button as""(.*)""")]
        public void WhenClickDeleteButtonAs(string university)
        {
            Educationobj.DeleteEducation();
        }

        [Then(@"Education should be deleted\.The alert message,""(.*)""should be displayed on the top right corner\.")]
        public void ThenEducationShouldBeDeleted_TheAlertMessageShouldBeDisplayedOnTheTopRightCorner_(string message)
        {
            Assert.AreEqual(message, Educationobj.EducationMessage);
            Console.WriteLine("Test is passed");
        }







    }
}
