using BookStoreApi.BusinessLayer;
using BookStoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookStoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            var books = _bookService.GetAllBooks();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            var book = _bookService.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public ActionResult<Book> AddBook(Book newBook)
        {
            _bookService.AddBook(newBook);
            return CreatedAtAction(nameof(GetBooks), new { id = newBook.Id }, newBook);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, Book updatedBook)
        {
            if (id != updatedBook.Id)
            {
                return BadRequest();
            }

            var existingBook = _bookService.GetBookById(id);
            if (existingBook == null)
            {
                return NotFound();
            }

            _bookService.UpdateBook(updatedBook);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = _bookService.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }

            _bookService.DeleteBook(id);
            return NoContent();
        }

        [HttpGet("author/{authorName}")]
        public ActionResult<IEnumerable<Book>> GetBooksByAuthor(string authorName)
        {
            var books = _bookService.GetBooksByAuthor(authorName);
            return Ok(books);
        }
    }
}
