using System.Collections.Generic;

namespace bankocr
{
    public class EmployeeStore
    {
        private string name;
        private int age;
        List<EmployeeStore> returnList = new List<EmployeeStore>();
        List<string> returnNamesList = new List<string>();
        const int ageValidForWorking = 18;
        public EmployeeStore()
        {

        }
        public EmployeeStore(string inputName, int inputAge)
        {
            this.name = inputName;
            this.age = inputAge;
        }

        public List<EmployeeStore> resturnAllList(List<EmployeeStore> inputlist)
        {
            return inputlist;
        }

        public List<EmployeeStore> returnListOfEmployeesOlderThan18Years(List<EmployeeStore> inputlist)
        {
            foreach (var item in inputlist)
            {
                if (item.age >= ageValidForWorking)
                {
                    returnList.Add(item);
                }
            }
            return returnList;
        }

        public List<string> returnListOfEmployeesSortedByTheirName(List<EmployeeStore> inputlist)
        {
            foreach (var item in inputlist)
            {
                if (item.age >= ageValidForWorking)
                {
                    returnNamesList.Add(item.name);
                }
            }
            return returnNamesList;
        }

        public List<string> returnListOfEmployeesTheirNamescapitalized(List<EmployeeStore> inputlist)
        {
            foreach (var item in inputlist)
            {
                if (item.age >= ageValidForWorking)
                {
                    string nameToUpper = item.name;
                    returnNamesList.Add(nameToUpper.ToUpper());
                }
            }
            return returnNamesList;
        }

        public List<string> returnListOfEmployeesTheirNamesDescending(List<EmployeeStore> inputlist)
        {
            string nameToUpper = "";
            foreach (var item in inputlist)
            {
                if (item.age >= ageValidForWorking)
                {
                    nameToUpper = item.name;
                    returnNamesList.Add(nameToUpper.ToUpper());
                }
                returnNamesList.Sort();
            }
            return returnNamesList;
        }
    }
}