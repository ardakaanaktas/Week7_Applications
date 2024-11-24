using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Join_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Authors> authors = new List<Authors>();
            authors.Add(new Authors { AuthorId = 1, Name = "Orhan Pamuk" });
            authors.Add(new Authors { AuthorId = 2, Name = "Elif Şafak" });
            authors.Add(new Authors { AuthorId = 3, Name = "Ahmet Ümit" });

            List<Books> books = new List<Books>();
            books.Add(new Books { BookId = 1, Title = "Kar", AuthorId = 1 });
            books.Add(new Books { BookId = 2, Title = "İstanbul", AuthorId = 1 });
            books.Add(new Books { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 });
            books.Add(new Books { BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3 });

            var result = from book in books // Joining two tables
                         join author in authors on book.AuthorId equals author.AuthorId //By using join keyword and authorId, we can join two tables
                         select new
                         {
                             book.Title, // Selecting the columns we want to see
                             author.Name // Selecting the columns we want to see
                         };

            result.ToList().ForEach(x => Console.WriteLine($"Book Title: {x.Title}, Author Name: {x.Name}")); // Printing the result
        }
    }
}
