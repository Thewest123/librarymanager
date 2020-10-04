using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class Customer : User
    {
        public string Address { get; set; }

        public Customer(string firstName, string lastName) : base(Role.Customer)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Customer(string firstName, string lastName, DateTime birthDate) : base(Role.Customer)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
    }
}
