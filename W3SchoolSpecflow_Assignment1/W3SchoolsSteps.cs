using System;
using TechTalk.SpecFlow;

namespace W3SchoolSpecflow_Assignment1
{
    [Binding]
    public class W3SchoolsSteps
    {
        HomePage Hp = new HomePage();
        [Given(@"I am at W(.*)Schools HomePage")]
        public void GivenIAmAtWSchoolsHomePage(int p0)
        {
            Hp.W3SchoolsHomePage();
        }
        
        [Given(@"I Click Learn HTML")]
        public void GivenIClickLearnHTML()
        {
            Hp.ClickLearnHTMLLink();
        }
        
        [Given(@"I Click On Try It YourSelf")]
        public void GivenIClickOnTryItYourSelf()
        {
            Hp.ClickTryItYourSelfButton();
        }
        
        [When(@"I press Run")]
        public void WhenIPressRun()
        {
            Hp.ClickRunButton();
        }
        
        [Then(@"I should get desired result")]
        public void ThenIShouldGetDesiredResult()
        {
            Hp.result();
        }
    }
}
