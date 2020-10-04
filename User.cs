using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class User
    {
        private int Id { get; }
        private Role Role { get; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => FirstName + " " + LastName;

        public DateTime BirthDate { get; set; }

        public User(Role role)
        {
            Role = role;
        }
    }


    public enum Role
    {
        Customer,
        Employee,
        Author,
        Admin
    }
}
