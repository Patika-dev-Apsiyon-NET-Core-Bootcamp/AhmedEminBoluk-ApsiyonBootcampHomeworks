using BlogProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers
{
    public class UserController : Controller
    {
        private readonly BlogContext _context;

        public UserController(BlogContext context)
        {
            _context = context;
        }

        public IActionResult AddUser()
        {
            ViewBag.users = _context.Users.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("AddUser");
        }
    }
}
