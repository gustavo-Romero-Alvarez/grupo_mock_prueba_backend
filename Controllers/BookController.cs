using Microsoft.AspNetCore.Mvc;
using PruebaBackend_GrupoMock_Gustavo_Romero.Models;
using System.Collections.Generic;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly BookService _bookService;

    public BooksController()
    {
        _bookService = new BookService();
    }

    [HttpGet]
    public ActionResult<IEnumerable<Book>> GetBooks()
    {
        return _bookService.GetBooks();
    }

    [HttpGet("{id}")]
    public ActionResult<Book> GetBook(int id)
    {
        var book = _bookService.GetBook(id);
        if (book == null)
        {
            return NotFound();
        }
        return book;
    }

    [HttpPost]
    public ActionResult<Book> CreateBook(Book book)
    {
        var createdBook = _bookService.CreateBook(book);
        return CreatedAtAction(nameof(GetBook), new { id = createdBook.Id }, createdBook);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateBook(int id, Book book)
    {
        _bookService.UpdateBook(id, book);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBook(int id)
    {
        _bookService.DeleteBook(id);
        return NoContent();
    }
}