﻿using BookStoreApi.Models;

namespace BookStoreApi.BusinessLayer
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
        IEnumerable<Book> GetBooksByAuthor(string author);
    }
}
