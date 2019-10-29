using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.ViewModels
{
    public class AllBookViewModel
    {
        public IList<Book> Books { get; set; }

        public DateTime CurrentTime { get; set; }
    }
}
