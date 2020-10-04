using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager
{
    public class Book
    {
        public string BookName { get; set; }
        public Author Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public BookGenre BookGenre { get; set; }

        public Book(string bookName, Author author, DateTime releaseDate, BookGenre bookGenre)
        {
            BookName = bookName;
            Author = author;
            ReleaseDate = releaseDate;
            BookGenre = bookGenre;
        }
    }

    public enum BookGenre
    {
        Fantasy,
        Adventure,
        Romance,
        Horror,
        Autobiography,
        HowTo
    }
}
