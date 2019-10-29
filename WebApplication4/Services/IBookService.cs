using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Services
{
   public interface IBookService
    {
        Book AddBook(int year, string title);
        IList<Book> GetAll();
    }
}
