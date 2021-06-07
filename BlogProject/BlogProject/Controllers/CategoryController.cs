using BlogProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly BlogContext _context;

        public CategoryController(BlogContext context)
        {
            _context = context;
        }

        public IActionResult AddCategory()
        {
            ViewBag.categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("AddCategory");
        }
    }
}
