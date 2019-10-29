using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Services;
using WebApplication4.ViewModels;

namespace WebApplication4.Controllers
{
    public class BookController:Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult All()
        {
            var books = _bookService.GetAll();
            var bookViewModels = books.Select(x => new BookViewModel()
            {
                Title = x.Title,
                Year = x.Year
            }).ToList();
            return View(bookViewModels);
        }
        public IActionResult Add(string title,int year)
        {
            _bookService.AddBook(year,title);
            return new RedirectToActionResult("All", "Book", null);
        }
    }
}
