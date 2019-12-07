using System;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Skills :Driver
    {
        Profile Skill = new Profile();
        [Given(@"I click on the skill tab under Profile page")]
        public void GivenIClickOnTheSkillTabUnderProfilePage()
        {
            //Wait
            TurnOnWait();

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")).Click();
        }
        
        [When(@"I added a new skill")]
        public void WhenIAddedANewSkill()
        {
            Skill.AddSkill();
        }
        [Then(@"that skill should be displayed on my listing")]
        public void ThenThatSkillShouldBeDisplayedOnMyListing()
        {
            Skill.DisplaySkill();
        }

        [When(@"I want to update an exsisting skill")]
        public void WhenIWantToUpdateAnExsistingSkill()
        {
            Skill.UpdateSkill();
        }
        [Then(@"that updated skill should be displayed on my listings")]
        public void ThenThatUpdatedSkillShouldBeDisplayedOnMyListings()
        {
            Skill.UpdateDisplaySkill();
        }

        [When(@"I want to delete an exsisting skill")]
        public void WhenIWantToDeleteAnExsistingSkill()
        {
            Skill.DeleteSkill();
        }
                              
        [Then(@"that skill should not be be displayed on my listing")]
        public void ThenThatSkillShouldNotBeBeDisplayedOnMyListing()
        {
            Skill.NotDispalySkill();
        }
    }
}
