using BookStoreApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreApi.DataAccessLayer
{
    public class BookRepository : IBookRepository
    {
        private static List<Book> Books = new List<Book>
        {
            new Book { Id = 1, Title = "NOVEL 2: Textbook (3rd Edition)", Author = "Author 1", Description = "Description of NOVEL 2", ImageUrl = "Pictures/books/1.jpeg" },
            new Book { Id = 2, Title = "WEBTOON 1: Textbook (3rd Edition)", Author = "Author 2", Description = "Description of WEBTOON 1", ImageUrl = "Pictures/books/2.jpeg" },
            new Book { Id = 3, Title = "GENKI 1: Textbook (2nd Edition)", Author = "Author 3", Description = "Description of GENKI 1", ImageUrl = "Pictures/books/3.jpeg" },
            new Book { Id = 4, Title = "MANGA 1: Textbook (1st Edition)", Author = "Author 4", Description = "Description of NOVEL 2", ImageUrl = "Pictures/books/4.jpeg" },
            new Book { Id = 5, Title = "NOVEL 2: Textbook (3rd Edition)", Author = "Author 5", Description = "Description of NOVEL 2", ImageUrl = "Pictures/books/5.jpeg" },
            new Book { Id = 6, Title = "WEBTOON 1: Textbook (3rd Edition)", Author = "Author 6", Description = "Description of WEBTOON 1", ImageUrl = "Pictures/books/6.jpeg" },
            new Book { Id = 7, Title = "GENKI 1: Textbook (2nd Edition)", Author = "Author 7", Description = "Description of GENKI 1", ImageUrl = "Pictures/books/7.jpeg" },
            new Book { Id = 8, Title = "COMIC 1: Textbook (3rd Edition)", Author = "Author 8", Description = "Description of NOVEL 2", ImageUrl = "Pictures/books/8.jpeg" },
            new Book { Id = 9, Title = "NOVEL 2: Textbook (3rd Edition)", Author = "Author 9", Description = "Description of NOVEL 2", ImageUrl = "Pictures/books/9.jpeg" },
            //new Book { Id = 10, Title = "MESSY FIRES 1: Textbook (3rd Edition)", Author = "Author 10", Description = "Description of WEBTOON 1", ImageUrl = "Pictures/books/10.jpeg" },
            //new Book { Id = 11, Title = "MOONTOWN 1: Textbook (4th Edition)", Author = "Author 11", Description = "Description of GENKI 1", ImageUrl = "Pictures/books/11.jpeg" },
            //new Book { Id = 12, Title = "COMIC 1: Textbook (3rd Edition)", Author = "Author 12", Description = "Description of NOVEL 2", ImageUrl = "Pictures/books/12.jpeg" },
            //new Book { Id = 13, Title = "WEBTOON 1: Textbook (3rd Edition)", Author = "Author 2", Description = "Description of WEBTOON 1", ImageUrl = "Pictures/books/13.jpeg" },
            //new Book { Id = 14, Title = "GENKI 1: Textbook (2nd Edition)", Author = "Author 3", Description = "Description of GENKI 1", ImageUrl = "Pictures/books/14.jpeg" },
            //new Book { Id = 15, Title = "MANGA 1: Textbook (1st Edition)", Author = "Author 4", Description = "Description of NOVEL 2", ImageUrl = "Pictures/books/15.jpeg" },

        };

        public IEnumerable<Book> GetAllBooks()
        {
            return Books;
        }

        public Book GetBookById(int id)
        {
            return Books.FirstOrDefault(b => b.Id == id);
        }

        public void AddBook(Book book)
        {
            book.Id = Books.Max(b => b.Id) + 1;
            Books.Add(book);
        }

        public void UpdateBook(Book book)
        {
            var existingBook = Books.FirstOrDefault(b => b.Id == book.Id);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.Description = book.Description;
                existingBook.ImageUrl = book.ImageUrl;
            }
        }

        public void DeleteBook(int id)
        {
            var book = Books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                Books.Remove(book);
            }
        }

        public IEnumerable<Book> GetBooksByAuthor(string author)
        {
            return Books.Where(b => b.Author.Equals(author, System.StringComparison.OrdinalIgnoreCase));
        }
    }
}
