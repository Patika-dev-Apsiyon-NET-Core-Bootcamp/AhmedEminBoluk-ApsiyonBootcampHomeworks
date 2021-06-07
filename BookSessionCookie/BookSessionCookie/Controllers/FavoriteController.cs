using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSessionCookie.Controllers
{
    public class FavoriteController : Controller
    {
        public IActionResult Index()
        {
            string cookieName = string.Empty;
            if (Request.Cookies.ContainsKey("cookieBookName"))
                cookieName = Request.Cookies["cookieBookName"]; 
            ViewBag.cookieName = cookieName;
            return View();
        }
    }
}
