using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Book newBook = new Book();




            newBook.BookID = 123;
            newBook.BookTitle=" C#";
            newBook.AuthorName=" Doglouys";
            newBook.Page=39;
            newBook.PublicationYear=2020;
            newBook.Balane=100.20;


            Console.WriteLine( newBook.BookID );
            Console.WriteLine( newBook.BookTitle );
            Console.WriteLine( newBook.AuthorName );
            Console.WriteLine( newBook.Page );
            Console.WriteLine( newBook.PublicationYear );
            Console.WriteLine( newBook.Balane  );


        }
    }
}
