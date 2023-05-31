using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoB_App
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }

        public Person()
        {
            ID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            DoB = DateTime.MinValue;
        }

        public Person(int id, string firstName, string lastName, DateTime dob)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            DoB = dob;
        }
    }
}
