using System;
using TechTalk.SpecFlow;

namespace Stocker.Tests.AcceptanceTests
{
    [Binding]
    public class FeatureExampleSteps
    {
        [Given(@"I am a normal user")]
        public void GivenIAmANormalUser()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I want to use the stock application")]
        public void GivenIWantToUseTheStockApplication()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter the url www\.stocker\.com")]
        public void WhenIEnterTheUrlWww_Stocker_Com()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see the home page")]
        public void ThenIShouldSeeTheHomePage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
