﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class Author : User
    {
        public DateTime DeathDate { get; set; }

        public Author(string firstName, string lastName, DateTime birthDate) : base(Role.Author)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
    }
}
