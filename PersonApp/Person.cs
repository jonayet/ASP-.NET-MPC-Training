using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Person
    {
        private string firstName;
        private string middleName = "";
        private string lastName = "";

        public string FirstName
        {
            set { firstName = value; }
        }
        

        public string MiddleName
        {
            set { middleName = value; }
        }

        public string LastName
        {
            set { lastName = value; }
        }

        public Person()
        {
            
        }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person(string firstName, string middleName, string lastName)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
        }

        public string GetFullName()
        {
            return firstName + " " + middleName + " " + lastName;
        }

        public string GetReverseName()
        {
            string fullName = GetFullName();
            string reverseName = "";

            for (int i = fullName.Length - 1; i >= 0; i--)
            {
                reverseName += fullName[i];
            }
            return reverseName;
        }
    }
}
