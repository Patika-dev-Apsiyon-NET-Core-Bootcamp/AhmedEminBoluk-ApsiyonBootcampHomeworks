using BookSessionCookie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookSessionCookie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Book> books = new List<Book>()
            {
                new Book
                {
                    BookName="Savaş Sanatı",
                    Writer="Sun Tzu",
                    PublishedYear=2014
                },
                new Book
                {
                    BookName="Hayvanlardan Tanrılara",
                    Writer="Yuval Noah Harari",
                    PublishedYear=2015
                },
                new Book
                {
                    BookName="Sokrates'in Savunması",
                    Writer="Platon",
                    PublishedYear=2012
                }
            };

            HttpContext.Session.Set<List<Book>>("books", books);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
