using System.Collections.Generic;

namespace bankocr
{
    public class Supervisor : Person
    {
        private string email;
        private int phoneNumber;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        List<Supervisor> listSupervisors = new List<Supervisor>();
        public Supervisor()
        {

        }
        public Supervisor(string name, string inputEmail, int inputPhone) : base(name)
        {
            this.email = inputEmail;
            this.phoneNumber = inputPhone;
        }
        public List<Supervisor> returnlistOfSupervisors(List<Supervisor> inputListSupervisors)
        {
            foreach (var item in inputListSupervisors)
            {
                listSupervisors.Add(item);
            }
            return listSupervisors;
        }
    }
}