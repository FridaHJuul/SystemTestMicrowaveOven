using System;
using TechTalk.SpecFlow;

namespace Microware.Test.Accept
{
    [Binding]
    public class MicrowavePowerSteps
    {
        [Given(@"the oven is reset")]
        public void GivenTheOvenIsReset()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press the power button (.*) time\(s\)")]
        public void WhenIPressThePowerButtonTimeS(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press the time button (.*) time\(s\)")]
        public void WhenIPressTheTimeButtonTimeS(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the display should show (.*)")]
        public void ThenTheDisplayShouldShow(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
