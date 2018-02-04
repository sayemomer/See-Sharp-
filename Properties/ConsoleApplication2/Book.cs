using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Book
    {

        private int bookID;
        private string bookTitle;
        private string authorName;
        private int page;
        private int publicationYear;
        private double balance;



        public int BookID
        {

            set { this.bookID = value; }
            get { return bookID; }


        }


        public string BookTitle
        {

            set { this.bookTitle = value; }
            get { return bookTitle; }
        }


        public string AuthorName
        {

            set { this.authorName = value; }
            get { return authorName; }
        }



        public int Page
        {
            set { this.page = value; }
            get { return page; }

        }



        public int PublicationYear
        {
            set { this.publicationYear = value; }
            get { return publicationYear; }

        }



        public double Balane
        {
            set { this.balance = value; }
            get { return balance; }


        }
    }
}
