﻿using System;
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
            private static int nextBookID = 1; // Static field to hold the next available BookID

            public Book()
            {
                BookID = nextBookID; // Assign the current nextBookID to the BookID
                nextBookID++; // Increment nextBookID for the next book
            }

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
                bookList.Add(book);
                Console.WriteLine($"Book '{book.Title}' added to the library.");
            }

            public void RemoveBook(int bookID)
            {
                Book bookToRemove = null;
                foreach (var book in bookList)
                {
                    if (book.BookID == bookID)
                    {
                        bookToRemove = book;
                        break;
                    }
                }

                if (bookToRemove != null)
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
                Console.WriteLine("Books in Library:");
                foreach (var book in bookList)
                {
                    book.Display_info();
                }
            }
        }

        static void Main(string[] args)
        {
            // Create instances of Book class
            Book sciFiction = new Book { Title = "Interstellar", Author = "Robert" };
            sciFiction.Display_info();
            Console.WriteLine();

            Book comedy = new Book { Title = "Friends", Author = "Sara" };
            Book action = new Book { Title = "Sherlock", Author = "John" };

            // Create instance of Library class
            Library national = new Library
            {
                LibraryName = "National Library",
                LibraryID = 1
            };

            // Add books to the library
            national.AddBook(sciFiction);
            national.AddBook(comedy);
            national.AddBook(action);

            Console.WriteLine();
            national.ViewBookList();

            // Remove a book from the library
            national.RemoveBook(sciFiction.BookID);
        }
    }
}