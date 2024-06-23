using PruebaBackend_GrupoMock_Gustavo_Romero.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class BookService
{
    private static List<Book> _books = new List<Book>
{
    new Book
    {
        Id = 1,
        Title = "The Great Gatsby",
        Author = "F. Scott Fitzgerald",
        Genre = "Fiction",
        PublishDate = new DateTime(1925, 4, 10)
    },
    new Book
    {
        Id = 2,
        Title = "To Kill a Mockingbird",
        Author = "Harper Lee",
        Genre = "Fiction",
        PublishDate = new DateTime(1960, 7, 11)
    },
    new Book
    {
        Id = 3,
        Title = "1984",
        Author = "George Orwell",
        Genre = "Science Fiction",
        PublishDate = new DateTime(1949, 6, 8)
    },
    new Book
    {
        Id = 4,
        Title = "Pride and Prejudice",
        Author = "Jane Austen",
        Genre = "Fiction",
        PublishDate = new DateTime(1813, 1, 28)
    },
    new Book
    {
        Id = 5,
        Title = "Moby-Dick",
        Author = "Herman Melville",
        Genre = "Fiction",
        PublishDate = new DateTime(1851, 10, 18)
    },
    new Book
    {
        Id = 6,
        Title = "The Catcher in the Rye",
        Author = "J.D. Salinger",
        Genre = "Fiction",
        PublishDate = new DateTime(1951, 7, 16)
    },
    new Book
    {
        Id = 7,
        Title = "To the Lighthouse",
        Author = "Virginia Woolf",
        Genre = "Fiction",
        PublishDate = new DateTime(1927, 5, 5)
    },
    new Book
    {
        Id = 8,
        Title = "The Lord of the Rings",
        Author = "J.R.R. Tolkien",
        Genre = "Fantasy",
        PublishDate = new DateTime(1954, 7, 29)
    },
    new Book
    {
        Id = 9,
        Title = "Jane Eyre",
        Author = "Charlotte Brontë",
        Genre = "Fiction",
        PublishDate = new DateTime(1847, 10, 16)
    },
    new Book
    {
        Id = 10,
        Title = "Frankenstein",
        Author = "Mary Shelley",
        Genre = "Science Fiction",
        PublishDate = new DateTime(1818, 1, 1)
    },
    new Book
    {
        Id = 11,
        Title = "The Grapes of Wrath",
        Author = "John Steinbeck",
        Genre = "Fiction",
        PublishDate = new DateTime(1939, 4, 14)
    },
    new Book
    {
        Id = 12,
        Title = "One Hundred Years of Solitude",
        Author = "Gabriel García Márquez",
        Genre = "Fiction",
        PublishDate = new DateTime(1967, 5, 30)
    },
    new Book
    {
        Id = 13,
        Title = "The Great Divorce",
        Author = "C.S. Lewis",
        Genre = "Fiction",
        PublishDate = new DateTime(1945, 5, 9)
    },
    new Book
    {
        Id = 14,
        Title = "The Kite Runner",
        Author = "Khaled Hosseini",
        Genre = "Fiction",
        PublishDate = new DateTime(2003, 5, 29)
    }
};

    public List<Book> GetBooks()
    {
        try
        {
            return _books.ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error getting books: {ex.Message}");
            throw;
        }
    }

    public Book GetBook(int id)
    {
        try
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error getting book with ID {id}: {ex.Message}");
            throw;
        }
    }

    public Book CreateBook(Book book)
    {
        try
        {
            book.Id = _books.Count + 1;
            _books.Add(book);
            return book;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating book: {ex.Message}");
            throw;
        }
    }

    public void UpdateBook(int id, Book book)
    {
        try
        {
            var existingBook = _books.FirstOrDefault(b => b.Id == id);
            if (existingBook != null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.Genre = book.Genre;
                existingBook.PublishDate = book.PublishDate;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating book with ID {id}: {ex.Message}");
            throw;
        }
    }

    public void DeleteBook(int id)
    {
        try
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                _books.Remove(book);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error deleting book with ID {id}: {ex.Message}");
            throw;
        }
    }
}