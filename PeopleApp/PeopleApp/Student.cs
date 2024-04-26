using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp
{
    internal class Student:Person
    {
        public Student()
        {

        }
        public Student(string pName, DateTime pDob, int pAge):base(pName, pDob, pAge)
        {

        }

    }
}
