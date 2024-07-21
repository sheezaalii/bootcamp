﻿using BookStoreApi.DataAccessLayer;
using BookStoreApi.Models;
using System.Collections.Generic;

namespace BookStoreApi.BusinessLayer
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public Book GetBookById(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public void AddBook(Book book)
        {
            _bookRepository.AddBook(book);
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.UpdateBook(book);
        }

        public void DeleteBook(int id)
        {
            _bookRepository.DeleteBook(id);
        }

        public IEnumerable<Book> GetBooksByAuthor(string author)
        {
            return _bookRepository.GetBooksByAuthor(author);
        }
    }
}
