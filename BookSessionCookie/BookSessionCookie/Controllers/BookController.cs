using BookSessionCookie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSessionCookie.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            List<Book> books = HttpContext.Session.Get<List<Book>>("books");
            return View(books);
        }

        [HttpPost]
        public IActionResult Index(string bookName)
        {
            //string cookieName = string.Empty;
           // if (Request.Cookies.ContainsKey("cookieBookName"))
               // cookieName = Request.Cookies["cookieBookName"];    
            //else
           // {
                Response.Cookies.Append("cookieBookName", bookName);
            //}
            return RedirectToAction("Index","Favorite");
        }
    }
}
