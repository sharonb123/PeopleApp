using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp
{
    internal class Handler
    {
        public List<Person> People = new List<Person>()
        {
            new Student { Name ="Susan", Dob = DateTime.Parse("1988/09/08")},
            new Lecturer { Name ="John", Dob = DateTime.Parse("1978/04/08")},
            new Lecturer { Name ="Sam", Dob = DateTime.Parse("1999/05/08")}
        };
       
    }
}
