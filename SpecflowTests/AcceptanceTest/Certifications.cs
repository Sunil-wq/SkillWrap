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
    public class Certifications :Driver
    {
        Profile Certification = new Profile();
        [Given(@"I click on the Certification tab under Profile page")]
        public void GivenIClickOnTheCertificationTabUnderProfilePage()
        {
            //Wait
            TurnOnWait();

            // Click on Profile tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();
        }
        
        [When(@"I enter Certifications detail")]
        public void WhenIEnterCertificationsDetail()
        {
            Certification.AddCertification();

        }
        [Then(@"that Certification detail should be displayed on my listings")]
        public void ThenThatCertificationDetailShouldBeDisplayedOnMyListings()
        {
            Certification.DisplayCertification();
        }

        [When(@"I want to update exsisting Certifications")]
        public void WhenIWantToUpdateExsistingCertifications()
        {
            Certification.UpdateCertification();
        }
        [Then(@"that updated Certification detail should be displayed on my listings")]
        public void ThenThatUpdatedCertificationDetailShouldBeDisplayedOnMyListings()
        {
            Certification.UpdateDisplayCertification();
        }

        [When(@"I want to delete the exsisting Certifications")]
        public void WhenIWantToDeleteTheExsistingCertifications()
        {
            Certification.DeleteCertification();
        }
                                     
        [Then(@"that Certification detail should not be be displayed on my listings")]
        public void ThenThatCertificationDetailShouldNotBeBeDisplayedOnMyListings()
        {
            Certification.NotDispalyCertification();
        }
    }
}
