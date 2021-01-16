using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core_MVC_General.Controllers
{
    public class BookController : Controller
    {
        public static Dictionary<string, List<Book>> books = new Dictionary<string, List<Book>>();

        public IActionResult AddBook()
        {
            return View();
        }

        [Route("/book/{generalGenre}")]
        public IActionResult AddBook(string generalGenre, Book book)
        {

            //if (genre != null && !books.ContainsKey(genre))
            //{
            //    books[genre] = new List<Book>();
            //    books[genre].Add(book);
            //}

            //return Content($"General genre: {genre}, "
            //                + $"name: {book.Name}, page count: {book.PageCount}, "
            //                + $"book genre: {book.Genre}");
            string genre = book.Genre;
            if (!books.ContainsKey(genre))
            {
                books[genre] = new List<Book>();
            }
            books[genre].Add(book);
            return Content($"General genre: {genre}, "
                            + $"name: {book.Name}, page count: {book.PageCount}, "
                            + $"book genre: {book.Genre}");
        }
    }

    public class Book
    {
        public string Genre { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
    }
}