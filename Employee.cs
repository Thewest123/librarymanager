using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class Employee : User
    {
        public string Address { get; set; }

        public Employee(string firstName, string lastName) : base(Role.Employee)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
