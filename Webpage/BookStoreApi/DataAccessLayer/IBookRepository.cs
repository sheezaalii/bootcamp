// IBookRepository.cs
using BookStoreApi.Models;
using System.Collections.Generic;

namespace BookStoreApi.DataAccessLayer
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
        IEnumerable<Book> GetBooksByAuthor(string author);
    }
}
