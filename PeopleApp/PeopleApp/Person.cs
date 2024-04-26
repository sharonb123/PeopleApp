using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp
{
    internal class Person:IComparable<Person>
    {
        private string name;
        private DateTime dob;
        private int age;

        public string Name { get => name; set => name = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public int Age { get => age; set => age = value; }

        public Person()
        {

        }

        public Person(string pName, DateTime pDob,int pAge)
        {
            this.Name = pName;
            this.Dob = pDob;
            this.Age = pAge;
        }
        public int CompareTo(Person p)
        {
            return p.Age.CompareTo(Age);
        }

        public void calculateAge(Person x)
        {
            Age = DateTime.Now.Year - x.Dob.Year;
        }
    }
}
