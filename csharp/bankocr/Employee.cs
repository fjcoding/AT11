using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace bankocr
{
    public class EmployeeStore : Person
    {
        private int age;
        private Supervisor supervisor;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Supervisor _Supervisor
        {
            get { return supervisor; }
            set { supervisor = value; }
        }
        
        List<EmployeeStore> listEmployees = new List<EmployeeStore>();
        const int ageValidForWorking = 18;
        public EmployeeStore ()
        {

        }

        public EmployeeStore (string name, int inputAge, Supervisor inputSupervisor) : base(name)
        {
            this.age = inputAge;
            this._Supervisor = inputSupervisor;
        }

        public List<EmployeeStore> returnListOfEmployeesOlderThan18Years(List<EmployeeStore> inputlist)
        {
            foreach (var item in inputlist)
            {
                if (item.age >= ageValidForWorking)
                {
                    listEmployees.Add(item);
                }
            }
            return listEmployees;
        }

        public List<string> returnListOfEmployeesSortedByTheirName(List<EmployeeStore> inputlist)
        {
            List<string> listEmployeesNames = new List<string>();
            foreach (var item in inputlist)
            {
                listEmployeesNames.Add(item.Name);
            }
            listEmployeesNames.Sort();
            return listEmployeesNames;
        }

        public List<string> returnListOfEmployeesWithTheirNamescapitalized(
                                                    List<EmployeeStore> inputlist)
        {
            List<string> listOfCapitalisedNames = new List<string>();
            foreach (var item in inputlist)
            {
                string nameToUper = item.Name;
                listOfCapitalisedNames.Add(nameToUper.ToUpper());
            }
            return listOfCapitalisedNames;
        }

        public List<string> returnListOfEmployeesTheirNamesDescending(List<EmployeeStore> inputlist)
        {
            List<string> listOfDesendingNames = new List<string>();
            foreach (var item in inputlist)
            {
                listOfDesendingNames.Add(item.Name);
            }
            listOfDesendingNames.Sort();
            listOfDesendingNames.Reverse();
            return listOfDesendingNames;
        }
        public List<Supervisor> returnListOfSupervisorsWithTheirEmailAndPhoneWithEmployeesUnder18(
                                                                List<EmployeeStore> inputlist)
        {
            List<Supervisor> supervisorList = new List<Supervisor>();
            foreach (var item in inputlist)
            {
                if (item.age < 18)
                {
                    supervisorList.Add(item._Supervisor);
                }
            }
            var distinctList = supervisorList.GroupBy(sup => sup.Name)
                                    .Select(g => g.First())
                                    .ToList();
            return distinctList;
        }
        
        public List<string> returnListofEmployeesUnder18AndHisOrHerPotentialReplacementemployeeNotUnder18(
                                                                List<EmployeeStore> inputlist)
        {
            List<string> employeesList = new List<string>();
            List<EmployeeStore> listOlders=  new List<EmployeeStore>();
            List<EmployeeStore> listYunger=  new List<EmployeeStore>();
            foreach (var item in inputlist)
            {
                if (item.age < 18)
                {
                    listYunger.Add(item);
                    continue;
                }
                listOlders.Add(item);
            }
            int cont = 0;
            for (int item = 0; item < listYunger.Count; item++)
            {
                if (listYunger[item]._Supervisor.Name == listOlders[cont]._Supervisor.Name)
                {
                    employeesList.Add(listYunger[item].Name +"=>"+listOlders[cont].Name);
                    cont++;
                    continue;
                }
                employeesList.Add(listYunger[item].Name +"=>"+"NO REPLACEMENT AVAILABLE");
            }
            return employeesList;
        }
    }
}