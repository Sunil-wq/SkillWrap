using Amazon.DynamoDBv2;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class Languages : Utils.Start
    {
        Profile Language = new Profile();
        [Given(@"I clicked on the Language tab under Profile page")]
        public void GivenIClickedOnTheLanguageTabUnderProfilePage()
        {
            //Wait
            TurnOnWait();
            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();

        }
        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {
            Language.AddLanguage();
                       

        }
        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {
            Language.DisplayLanguage();

        }
        [When(@"I want to edit exsisting language")]
        public void WhenIWantToEditExsistingLanguage()
        {
            Language.UpdateLanguage();

        }
        [Then(@"that updated language should be displayed on my listings")]
        public void ThenThatUpdatedLanguageShouldBeDisplayedOnMyListings()
        {
            Language.UpdateDisplayLanguage();
        }                
        [When(@"I want to delete exsisting language")]
        public void WhenIWantToDeleteExsistingLanguage()
        {
            Language.DeleteLanguage();

        }
        [Then(@"that language should not be be displayed on my listings")]
        public void ThenThatLanguageShouldNotBeBeDisplayedOnMyListings()
        {
            Language.NotDispaly();

        }




    }
}




