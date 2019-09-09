using System;
using Xunit;
using bankocr;
using System.Collections.Generic;

namespace Employee.Test
{
    public class UnitTestEmployee
    {
        public readonly EmployeeStore _employee;
        List<EmployeeStore> employeeList = new List<EmployeeStore>()
            {
                new EmployeeStore("Max", 17),
                new EmployeeStore("Sepp", 18),
                new EmployeeStore("Nina", 15),
                new EmployeeStore("Mike", 51)
            };
        public UnitTestEmployee()
        {
            _employee = new EmployeeStore();
        }

        [Fact]
        public void TestGetlistOfAllEmployees()
        {
            var result =  _employee.resturnAllList(employeeList);
            Assert.Equal(employeeList, result);
        }

        [Fact]
        public void TestlistOfEmployeesOlderThan18Years()
        {
            int secondExpectedRow = 1;
            int fourthExpectedRow = 3;
            int firstResultRow = 0;
            int secondResultRow = 1;
            var result = _employee.returnListOfEmployeesOlderThan18Years(employeeList);
            Assert.Equal(employeeList[secondExpectedRow], result[firstResultRow]);
            Assert.Equal(employeeList[fourthExpectedRow], result[secondResultRow]);
        }

        [Fact]
        public void TestlistOfEmployeesOlderThan18YearsSortedByTheirName()
        {
            int firstResultRow = 0;
            int secondResultRow = 1;
            var result = _employee.returnListOfEmployeesSortedByTheirName(employeeList);
            Assert.Equal("Sepp", result[firstResultRow].ToString());
            Assert.Equal("Mike", result[secondResultRow].ToString());
        }

        [Fact]
        public void TestlistOfEmployeesTheirNamescapitalized()
        {
            int firstResultRow = 0;
            int secondResultRow = 1;
            var result = _employee.returnListOfEmployeesTheirNamescapitalized(employeeList);
            Assert.Equal("SEPP", result[firstResultRow].ToString());
            Assert.Equal("MIKE", result[secondResultRow].ToString());
        }

        [Fact]
        public void TestlistOfEmployeesTheirNamesDescending()
        {
            int firstResultRow = 0;
            int secondResultRow = 1;
            var result = _employee.returnListOfEmployeesTheirNamesDescending(employeeList);
            Assert.Equal("MIKE", result[firstResultRow].ToString());
            Assert.Equal("SEPP", result[secondResultRow].ToString());
        }
    }
}