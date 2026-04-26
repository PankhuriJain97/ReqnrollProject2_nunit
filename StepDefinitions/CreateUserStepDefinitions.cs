using ExecuteAutomation.Reqnroll.Dynamics;
using Reqnroll;
using ReqnrollProject2_Nunit.Models;
using System;
using System.Runtime.ConstrainedExecution;

namespace ReqnrollProject2_Nunit.StepDefinitions
{
    [Binding]
    public class CreateUserStepDefinitions
    {
        [Given("I navigate to http:\\/\\/eaapp.somee.com\\/")]
        public void GivenINavigateToHttpEaapp_Somee_Com()
        {
            Console.WriteLine("Navigating to http://eaapp.somee.com/");
        }

        [When("I click on the register link")]
        public void WhenIClickOnTheRegisterLink()
        {
            Console.WriteLine("Clicked on register link");
        }

        [When("I enter user details as follows :")]
        public void WhenIEnterUserDetailsAsFollows(DataTable dataTable)
        {
           //  var user = dataTable.Rows;

            //way 1 - to get data from datatable into variable
            foreach (var value in dataTable.Rows)
            {
                Console.WriteLine($"The Username is {value["Username"]}");
                Console.WriteLine($"The Email Adress is {value["Email Address"]}");
                Console.WriteLine($"The password is {value["Password"]}");
                Console.WriteLine($"The confirm password is {value["Confirm Password"]}");
            }

            //way 2 - to get data from datatable into record
            // var userDetails = dataTable.CreateInstance<UserDetails>();
            //Console.WriteLine($"The Username is {userDetails.Username}");
            //Console.WriteLine($"The Email Address is {userDetails.EmailAddress}");
            //Console.WriteLine($"The Password is {userDetails.Password}");
            //Console.WriteLine($"The Confirm Password is {userDetails.ConfirmPassword}");
            
            var userDetails = dataTable.CreateSet<UserDetails>();

            foreach(var data in userDetails)
            {
                Console.WriteLine($"The Username is {data.Username}");
                Console.WriteLine($"The Email Address is {data.EmailAddress}");
                Console.WriteLine($"The Password is {data.Password}");
                Console.WriteLine($"The Confirm Password is {data.ConfirmPassword}");
            }
        }


        [When("I click on Create Account button")]
        public void WhenIClickOnCreateAccountButton()
        {
            Console.WriteLine("Clicked on Create Account button");
        }

        [Then("I should be registered successfully")]
        public void ThenIShouldBeRegisteredSuccessfully()
        {
            Console.WriteLine("Registered successfully");
        }

        [When("I enter user details with dynamic data table as follows :")]
        public void WhenIEnterUserDetailsWithDynamicDataTableAsFollows(DataTable dataTable)
        {
            //use dynamic data table to avoid creating record for each scenario outline
            
            dynamic userDetails = dataTable.CreateDynamicSet();

            foreach(var data in userDetails)
            {
                Console.WriteLine($"The Username is {data.Username}");
                Console.WriteLine($"The Email Address is {data.EmailAddress}");
                Console.WriteLine($"The Password is {data.Password}");
                Console.WriteLine($"The Confirm Password is {data.ConfirmPassword}");
            }
        }


    }
}
