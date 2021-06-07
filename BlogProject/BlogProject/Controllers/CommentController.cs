using BlogProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers
{
    public class CommentController : Controller
    {
        private readonly BlogContext _context;

        public CommentController(BlogContext context)
        {
            _context = context;
        }

        public IActionResult Index(int id)
        {
            var blogs = from b in _context.Blogs select b;
            var blog = blogs.FirstOrDefault(x => x.Id == id);
            ViewBag.blog = blog;
            ViewBag.users = _context.Users.ToList();



            return View();
        }

        [HttpPost]
        public IActionResult Index(CommentViewModel model)
        {
            var blog = _context.Blogs.FirstOrDefault(x=>x.Id == model.BlogId);
            var adduser = _context.Users.FirstOrDefault(x => x.Id == model.UserId);
            Comment commment = new Comment();
            var stringDescrip = model.Description.ToString();
            commment.Description = stringDescrip;
            commment.Blog = blog;
            commment.User = adduser;


            
            
            _context.Users.Update(adduser);
            _context.Comments.Add(commment);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
