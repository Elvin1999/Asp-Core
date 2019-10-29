using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Services
{
    public class BookService : IBookService
    {
        private readonly IList<Book> _books;
        public Book AddBook(int year, string title)
        {
            var book = new Book()
            {
                Id = _books.Count + 1,
                Title = title,
                Year = year
            };
            _books.Add(book);
            return book;
        }
        public BookService()
        {
            _books = new List<Book>()
            {
                new Book(){ Id=1, Title="AAAAA", Year=2011 },
                new Book(){ Id=2, Title="BBBBB", Year=2011 },
                new Book(){ Id=3, Title="CCCCC", Year=2011 },
                new Book(){ Id=4, Title="DDDDD", Year=2011 },
            };
        }
        public IList<Book> GetAll()
        {
            return _books;
        }
    }
}
