using System;
using Reqnroll;

namespace EmployeeManagementBDD.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given("I have browser with OrangeHRM application")]
        public void GivenIHaveBrowserWithOrangeHRMApplication()
        {
            
        }

        [When("I enter username as {string}")]
        public void WhenIEnterUsernameAs(string username)
        {
            Console.WriteLine("when"+username);
        }

        [When("I enter password as {string}")]
        public void WhenIEnterPasswordAs(string password)
        {
            Console.WriteLine("when" + password);
        }

        [When("I click on login")]
        public void WhenIClickOnLogin()
        {
            Console.WriteLine("login");
        }

        [Then("I should access to portal with header as {string}")]
        public void ThenIShouldAccessToPortalWithHeaderAs(string expectedValue)
        {
            Console.WriteLine("expected value"+ expectedValue);
        }
        [Then("I should get the error message as {string}")]
        public void ThenIShouldGetTheErrorMessageAs(string InvalidCredentials)
        {
          Console.WriteLine(InvalidCredentials);
        }

    }
}
