using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class Book
    {
        public string title;
        public string author;
        public string isbn;

        public Book(string Title, string Author, string Isbn)
        {
            title = Title;
            author = Author;
            isbn = Isbn;
        }
    }

    public class Library
    {
        public List<Book> books = new List<Book>();

        //add new book
        public void AddBook(Book book)
        {
            books.Add(book);

        }

        //remove book
        public void RemoveBook(string isbn)
        {
            books.RemoveAll(b => b.isbn == isbn);
        }

        //show books
        public void DisplayBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.title);
            }
        }
    }
}
