using BlogProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogContext _context;

        public BlogController(BlogContext context)
        {
            _context = context;
        }

        public IActionResult AddBlog()
        {
            ViewBag.blogsCategory = _context.Categories.ToList();
            ViewBag.blogs = _context.Blogs.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(BlogViewModel model)
        {
            Blog blog = new Blog();
            blog.BlogContent = model.BlogContent;
            blog.BlogTitle = model.BlogTitle;
            blog.Categories = new List<Category>();
            foreach (var item in model.SelectedCategories)
            {
                Category category = new Category { Id = item };
                _context.Categories.Attach(category);
                blog.Categories.Add(category);
            }

            _context.Blogs.Add(blog);
            _context.SaveChanges();
            return RedirectToAction("AddBlog");
        }


    }
}
