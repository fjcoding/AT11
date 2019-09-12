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
                new EmployeeStore("Alex", 16, new Supervisor("Ariana", "Ariana@gmail.com", 74717171)),
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
            int firstResultRow = 0;
            int secondResultRow = 1;
            int thirdResultRow = 2;
            var testEmployee = _employee.returnListOfEmployeesOlderThan18Years(employeeList);
            Assert.Equal("Sepp", testEmployee[firstResultRow].Name);
            Assert.Equal("Mike", testEmployee[secondResultRow].Name);
            Assert.Equal("Franz", testEmployee[thirdResultRow].Name);
        }

        [Fact]
        public void TestlistOfEmployeesOlderThan18YearsSortedByTheirName()
        {
            int firstResultRow = 0;
            int secondResultRow = 1;
            int thirdResultRow = 2;
            int fourthResultRow = 3;
            int fifthResultRow = 4;
            int sixthResultRow = 5;
            var testEmployee = _employee.returnListOfEmployeesSortedByTheirName(employeeList);
            Assert.Equal("Alex", testEmployee[firstResultRow]);
            Assert.Equal("Franz", testEmployee[secondResultRow]);
            Assert.Equal("Max", testEmployee[thirdResultRow]);
            Assert.Equal("Mike", testEmployee[fourthResultRow]);
            Assert.Equal("Nina", testEmployee[fifthResultRow]);
            Assert.Equal("Sepp", testEmployee[sixthResultRow]);
        }

        [Fact]
        public void TestReturnlistOfEmployeesWithTheirNamescapitalized()
        {
            int firstResultRow = 0;
            int secondResultRow = 1;
            int thirdResultRow = 2;
            int fourthResultRow = 3;
            int fifthResultRow = 4;
            int sixthResultRow = 5;
            var testEmployee = _employee.returnListOfEmployeesWithTheirNamescapitalized(employeeList);
            Assert.Equal("MAX", testEmployee[firstResultRow]);
            Assert.Equal("ALEX", testEmployee[secondResultRow]);
            Assert.Equal("SEPP", testEmployee[thirdResultRow]);
            Assert.Equal("NINA", testEmployee[fourthResultRow]);
            Assert.Equal("MIKE", testEmployee[fifthResultRow]);
            Assert.Equal("FRANZ", testEmployee[sixthResultRow]);
        }

        [Fact]
        public void TestlistOfEmployeesWithTheirNamesDescending()
        {
            int firstResultRow = 0;
            int secondResultRow = 1;
            int thirdResultRow = 2;
            int fourthResultRow = 3;
            int fifthResultRow = 4;
            int sixthResultRow = 5;
            var testEmployee = _employee.returnListOfEmployeesTheirNamesDescending(employeeList);
            Assert.Equal("Sepp", testEmployee[firstResultRow]);
            Assert.Equal("Nina", testEmployee[secondResultRow]);
            Assert.Equal("Mike", testEmployee[thirdResultRow]);
            Assert.Equal("Max", testEmployee[fourthResultRow]);
            Assert.Equal("Franz", testEmployee[fifthResultRow]);
            Assert.Equal("Alex", testEmployee[sixthResultRow]);
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

        [Fact]
        public void TestListofEmployeesUnder18AndHisOrHerPotentialReplacementemployeeNotUnder18()
        {
            int firstResultRow = 0;
            int secondResultRow = 1;
            int thirdResultRow = 2;
            var testEmployee = _employee
                                .returnListofEmployeesUnder18AndHisOrHerPotentialReplacementemployeeNotUnder18(
                                employeeList);
            Assert.Equal("Max=>Sepp", testEmployee[firstResultRow]);
            Assert.Equal("Alex=>NO REPLACEMENT AVAILABLE", testEmployee[secondResultRow]);
            Assert.Equal("Nina=>Mike", testEmployee[thirdResultRow]);
        }
    }
}