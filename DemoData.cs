using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class DemoData
    {
        public List<Book> Books { get; set; }
        public List<Author> Authors { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Customer> Customers { get; set; }

        public DemoData()
        {
            // Inicializace listů
            Books = new List<Book>();
            Authors = new List<Author>();
            Employees = new List<Employee>();
            Customers = new List<Customer>();

            // DEMO AUTOŘI
            Author george = new Author("George", "Orwell", new DateTime(1950, 8, 4))
            {
                DeathDate = new DateTime(1993, 12, 24)
            };

            Author macha = new Author("Karel Hynek", "Mácha", new DateTime(1940, 12, 3));
            Author erben = new Author("Jaromír", "Erben", new DateTime(1919, 1, 7));

            Authors.Add(erben);
            Authors.Add(macha);
            Authors.Add(george);

            // DEMO KNIHY
            Books.Add(new Book("1984", george, new DateTime(1990, 10, 23), BookGenre.Adventure));
            Books.Add(new Book("První máj", macha, new DateTime(2004, 7, 1), BookGenre.Romance));
            Books.Add(new Book("Radkovo dobrodružství", macha, new DateTime(2020, 8, 10), BookGenre.Adventure));
            Books.Add(new Book("Kytice", erben, new DateTime(2005, 1, 1), BookGenre.Horror));
            Books.Add(new Book("Květnice", erben, new DateTime(2006, 1, 1), BookGenre.Autobiography));

            // DEMO ZAMĚSTNANCI
            Employees.Add(new Employee("Jan", "Černý"));
            Employees.Add(new Employee("Adam", "Přibyl"));

            // DEMO ZÁKAZNÍCI
            Customers.Add(new Customer("Jan", "Novák", new DateTime(1994, 05, 12)));
            Customers.Add(new Customer("Petr", "Novotný", new DateTime(2001, 11, 05)));
            Customers.Add(new Customer("Karel", "Štěpnička", new DateTime(1983, 08, 01)));
        }
    }
}
