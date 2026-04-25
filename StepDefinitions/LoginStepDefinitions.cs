using System;
using Reqnroll;

namespace ReqnrollProject_Nunit.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        [Given("I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            Console.WriteLine("On login page");
        }

        [When("I click on the logn link")]
        public void WhenIClickOnTheLognLink()
        {
            Console.WriteLine("Clicked on login link");
        }

        [When("I enter valid (.*) and (.*)")]
        public void WhenIEnterValidUsernameAndPassword(string username, string password)
        {
            Console.WriteLine("Username: " + username + "Password: " + password);
        }

        [When("I click on login")]
        public void WhenIClickOnLogin()
        {
            Console.WriteLine("Clicked on login button");
            Console.WriteLine("Performing login action");
        }

        [Then("I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            Console.WriteLine("Logged in successfully");
        }

    }
}
