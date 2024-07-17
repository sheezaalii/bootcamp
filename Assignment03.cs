using System;
using System.Collections.Generic; // using List


namespace MyApp
{
    internal class Program
    {
        class Book
        {
            public string Title;
            public string Author;
            public int BookID;

            public void Display_info()
            {
                Console.WriteLine($"\nTitle: {Title}");
                Console.WriteLine($"Author: {Author}");
                Console.WriteLine($"BookID: {BookID}");
            }
        }

        class Person
        {
            public string Name;
            public int Age;
            public int PersonID;
        }
        class Library
        {
            public string LibraryName;
            public int LibraryID;
            private List<Book> bookList = new List<Book>();
            public void AddBook(Book book)
            { 
                bookList.Add( book );
                Console.WriteLine($"Book '{book.Title}' added to the library.");
            }
            public void RemoveBook(int bookID) 
            { 
                Book bookToRemove = null;
                foreach (var book in bookList)
                {
                    if(book.BookID == bookID)

                    {
                        bookToRemove = book;
                        break;
                    }
                }

            if(bookToRemove != null)
                {
                    bookList.Remove(bookToRemove);
                    Console.WriteLine($"\nBook with ID #{bookID} removed from the library.");
                }
                else
                {
                    Console.WriteLine($"\nBook with ID # {bookID} not found in the library.");
                }
            }

            public void ViewBookList() 
            {
                Console.WriteLine("bookList in Library: ");
                foreach(var book in bookList)
                {
                    book.Display_info();
                }
            }
        }
        static void Main(string[] args)
        {
            Book sciFiction = new Book { Title = "Interstellar", Author = "Robert", BookID = 1234 };  //obj1 of Book class
            sciFiction.Display_info();
            Console.WriteLine();
            Book comedy = new Book { Title = "Friends", Author = "sara", BookID = 1238 };  //obj1 of Book class
            Book action = new Book { Title = "Sherlock", Author = "John", BookID = 2345 };   // obj3 of Book class

            Library national = new Library();
            national.LibraryName = "National Library";
            national.LibraryID = 0001;

            national.AddBook(sciFiction);
            national.AddBook(comedy);
            national.AddBook(action);

            Console.WriteLine();
            national.ViewBookList();

            national.RemoveBook(1234);
        }
    }
}