using System;
using Xunit;
using bankocr;
using System.Collections.Generic;
using System.Collections;

namespace Employee.Test
{
    public class UnitTestEmployee
    {
        public readonly EmployeeStore _employee;
        List<EmployeeStore> employeeList = new List<EmployeeStore>()
            {
                new EmployeeStore("Max", 17, new Supervisor("Ariana", "Ariana@gmail.com", 74717171)),
                // new EmployeeStore("Alex", 16, new Supervisor("Ariana", "Ariana@gmail.com", 74717171)),
                new EmployeeStore("Sepp", 18, new Supervisor("Ariana", "Ariana@gmail.com", 74717171)),
                new EmployeeStore("Nina", 15, new Supervisor("Benita", "Benita@gmail.com", 69696587)),
                new EmployeeStore("Mike", 51, new Supervisor("Benita", "Benita@gmail.com", 69696587)),
                new EmployeeStore("Franz", 21, new Supervisor("Franco", "Franco@gmail.com", 60987415))
            };
        ArrayList datos = new ArrayList();
        public UnitTestEmployee()
        {
            _employee = new EmployeeStore();
        }

        [Fact]
        public void TestInsertEmployeeReturnName()
        {
            EmployeeStore testEmployee;
            testEmployee = new EmployeeStore("Max", 17, new Supervisor("Ariana", "Ariana@gmail.com", 74717171));
            Assert.Equal("Max", testEmployee.Name);
        }

        [Fact]
        public void TestlistOfEmployeesOlderThan18Years()
        {
            int secondExpectedRow = 1;
            int fourthExpectedRow = 3;
            int firstResultRow = 0;
            int secondResultRow = 1;
            var testEmployee = _employee.returnListOfEmployeesOlderThan18Years(employeeList);
            Assert.Equal("Sepp", testEmployee[0].Name);
            Assert.Equal("Mike", testEmployee[1].Name);
            Assert.Equal("Franz", testEmployee[2].Name);
        }

        [Fact]
        public void TestlistOfEmployeesOlderThan18YearsSortedByTheirName()
        {
            int firstResultRow = 0;
            int secondResultRow = 1;
            var testEmployee = _employee.returnListOfEmployeesSortedByTheirName(employeeList);
            Assert.Equal("Franz", testEmployee[firstResultRow]);
            Assert.Equal("Max", testEmployee[secondResultRow]);
            Assert.Equal("Mike", testEmployee[2]);
            Assert.Equal("Nina", testEmployee[3]);
            Assert.Equal("Sepp", testEmployee[4]);
        }

        [Fact]
        public void TestReturnlistOfEmployeesWithTheirNamescapitalized()
        {
            int firstResultRow = 0;
            int secondResultRow = 1;
            var testEmployee = _employee.returnListOfEmployeesWithTheirNamescapitalized(employeeList);
            Assert.Equal("MAX", testEmployee[firstResultRow]);
            Assert.Equal("SEPP", testEmployee[secondResultRow]);
            Assert.Equal("NINA", testEmployee[2]);
            Assert.Equal("MIKE", testEmployee[3]);
            Assert.Equal("FRANZ", testEmployee[4]);
        }

        [Fact]
        public void TestlistOfEmployeesWithTheirNamesDescending()
        {
            int firstResultRow = 0;
            int secondResultRow = 1;
            var testEmployee = _employee.returnListOfEmployeesTheirNamesDescending(employeeList);
            Assert.Equal("Sepp", testEmployee[firstResultRow]);
            Assert.Equal("Nina", testEmployee[secondResultRow]);
            Assert.Equal("Mike", testEmployee[2]);
            Assert.Equal("Max", testEmployee[3]);
            Assert.Equal("Franz", testEmployee[4]);
        }

        [Fact]
        public void TestlistOfSupervisorsWithTheirEmailAndPhoneWithEmployeesUnder18()
        {
            int firstResultRow = 0;
            int secondResultRow = 1;
            var testEmployee = _employee
                                .returnListOfSupervisorsWithTheirEmailAndPhoneWithEmployeesUnder18(employeeList);
            Assert.Equal("Ariana@gmail.com", testEmployee[firstResultRow].Email);
            Assert.Equal(74717171, testEmployee[firstResultRow].PhoneNumber);
            Assert.Equal("Benita@gmail.com", testEmployee[secondResultRow].Email);
            Assert.Equal(69696587, testEmployee[secondResultRow].PhoneNumber);
        }
    }
}