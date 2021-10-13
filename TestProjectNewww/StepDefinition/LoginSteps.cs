using System;
using TechTalk.SpecFlow;
using TestProjectNewww.PageObject;

namespace TestProjectNewww.StepDefinition
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginpage;
        public LoginSteps()
        {
           loginpage = new LoginPage();
        }

        [Given(@"I Navigate to https://opensource-demo\.orangehrmlive\.com/")]
        public void INavigateToWebsite()
        {
            loginpage.INavigateToWebsite();
        }

        [Given(@"I need to Login as Admin")]
        public void GivenINeedToLoginAsAdmin()
        {
            loginpage.ClickOnAdmin();
        }
       
        [Given(@"I Click on Admin")]
        public void GivenIClickOnAdmin()
        {
            loginpage.ClickOnAdmin();
        }
        
        [Given(@"I Click on Qualifications")]
        public void GivenIClickOnQualifications()
        {
            loginpage.ClickOnQualifications();
        }
        
        [Given(@"I Click on Skills")]
        public void GivenIClickOnSkills()
        {
            loginpage.ClickOnSkills();
        }
        
        [Given(@"I  I Click on Add")]
        public void GivenIIClickOnAdd()
        {
            loginpage.ClickOnAdd();
        }
        
        [Given(@"I Enter the skill name")]
        public void GivenIEnterTheSkillName()
        {
            loginpage.ClickOnSkills();
        }
        
        [Given(@"I Enter Description")]
        public void GivenIEnterDescription()
        {
            loginpage.IEnterDescription();
        }
        
        [When(@"I Click on Save")]
        public void WhenIClickOnSave()
        {
            loginpage.IClickOnSave();
        }
        
        
        [Then(@"I Confirm the skill as been successfully added")]
        public void ThenIConfirmTheSkillAsBeenSuccessfullyAdded()
        {
            loginpage.IConfirmSkillSuccessfully();
        }
    }
}
