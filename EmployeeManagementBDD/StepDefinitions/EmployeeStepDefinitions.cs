using EmployeeManagementBDD.Hooks;
using EmployeeManagementBDD.Pages;
using NUnit.Framework;
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
        private readonly PersonalDetailsPage _personalDetailsPage;
        private static DataTable _dataTable;
        private readonly ScenarioContext _scenarioContext;  
        public EmployeeStepDefinitions(MainPage mainPage,PIMPage pIMPage,AddEmployeePage addEmployeePage,PersonalDetailsPage personalDetailsPage,ScenarioContext scenariocontext)
        {
          _mainPage = mainPage;
           _pIMPage = pIMPage;
           _addEmployeePage = addEmployeePage;
           _personalDetailsPage = personalDetailsPage;
            _scenarioContext = scenariocontext;
            
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
           EmployeeModel empModel= dataTable.CreateInstance<EmployeeModel>();
            //var emps=dataTable.CreateSet<EmployeeModel>();
           // dynamic dynEmp = dataTable.CreateInstance<object>();
            //Console.WriteLine(dynEmp.FirstName);


            _scenarioContext.Add("employeeDt", dataTable);
            //_scenarioContext.Add("session","c# selenium");
            //Console.WriteLine(dataTable);
            //Console.WriteLine(dataTable.RowCount);

            //Console.WriteLine(dataTable.Rows[0][0]);
            //Console.WriteLine(dataTable.Rows[0][1]);
            //Console.WriteLine(dataTable.Rows[0][2]);

            //Console.WriteLine(dataTable.Rows[0]["firstname"]);
            //Console.WriteLine(dataTable.Rows[0]["middlename"]);
            //Console.WriteLine(dataTable.Rows[0]["lastname"]);
            ////_addEmployeePage.FillEmployeeDetails(dataTable.Rows[0]["firstname"],
             //dataTable.Rows[0]["middlename"], dataTable.Rows[0]["lastname"]);

            _addEmployeePage.FillEmployeeDetails(empModel.FirstName,empModel.MiddleName, empModel.LastName);
        }

        [When("I click on save employee")]
        public void WhenIClickOnSaveEmployee()
        {
            _addEmployeePage.ClickOnSave(); 
        }

        [Then("i should get the profile name as {string}")]
        public void ThenIShouldGetTheProfileNameAs(string expectedProfileName)
        {
            string actualProfileName = _personalDetailsPage.GetProfileName(expectedProfileName);
            Assert.That(actualProfileName,Is.EqualTo(expectedProfileName));
            
        }

        [Then("I should get all field with filld data")]
        public void ThenIShouldGetAllFieldWithFilldData()
        {
            if(_scenarioContext.TryGetValue("employeeDt",out DataTable dt))
            {
                Console.WriteLine(dt.Rows[0]["firstname"]);
                Console.WriteLine(dt.Rows[0]["middlename"]);
                Console.WriteLine(dt.Rows[0]["lastname"]);
            }
            if(_scenarioContext.TryGetValue("session", out string output))
            {
                Console.WriteLine(output);
            }
           
        }
    }
}
