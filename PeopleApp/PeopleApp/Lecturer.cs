using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp
{
    internal class Lecturer:Person
    {
        public Lecturer()
        {

        }

        public Lecturer(string pName, DateTime pDob, int pAge):base(pName, pDob, pAge)
        {
                
        }
    }
}
