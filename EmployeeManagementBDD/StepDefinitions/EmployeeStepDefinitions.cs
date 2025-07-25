using EmployeeManagementBDD.Hooks;
using EmployeeManagementBDD.Pages;
using OpenQA.Selenium;
using Reqnroll;
using System;

namespace EmployeeManagementBDD.StepDefinitions
{
    [Binding]
    public class EmployeeStepDefinitions
    {
        private readonly MainPage _mainPage;
        private readonly PIMPage _pIMPage;
        private readonly AddEmployeePage _addEmployeePage;
        public EmployeeStepDefinitions(MainPage mainPage,PIMPage pIMPage,AddEmployeePage addEmployeePage)
        {
          _mainPage = mainPage;
           _pIMPage = pIMPage;
            _addEmployeePage = addEmployeePage;
          
        }

        [When("I click on PIM menu")]
        public void WhenIClickOnPIMMenu()
        {
            _mainPage.ClickOnPIMMenu();
        }

        [When("I click on  Add Employee menu")]
        public void WhenIClickOnAddEmployeeMenu()
        {
            _pIMPage.ClickOnAddEmployee();

        }

        [When("I fill the employee form")]
        public void WhenIFillTheEmployeeForm(DataTable dataTable)
        {
            Console.WriteLine(dataTable.RowCount);

            Console.WriteLine(dataTable.Rows[0][0]);
            Console.WriteLine(dataTable.Rows[0][1]);
            Console.WriteLine(dataTable.Rows[0][2]);

            Console.WriteLine(dataTable.Rows[0]["firstName"]);
            Console.WriteLine(dataTable.Rows[0]["middleName"]);
            Console.WriteLine(dataTable.Rows[0]["lastName"]);
            _addEmployeePage.FillEmployeeDetails(dataTable.Rows[0]["firstName"],
             dataTable.Rows[0]["middleName"], dataTable.Rows[0]["lastName"]);
        }

        [When("I click on save employee")]
        public void WhenIClickOnSaveEmployee()
        {
            _addEmployeePage.ClickOnSave(); 
        }

        [Then("i should get the profile name as {string}")]
        public void ThenIShouldGetTheProfileNameAs(string expectedProfile)
        {
            
        }

        [Then("I should get all field with filld data")]
        public void ThenIShouldGetAllFieldWithFilldData()
        {
            
        }
    }
}
