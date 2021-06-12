using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RoleHomeWorkProject.Data;
using RoleHomeWorkProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleHomeWorkProject.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel model)
        {
            IdentityResult result = await _userManager.CreateAsync(new RoleHomeWorkProject.Data.User { Email = model.Email, Name = model.Name, UserName = model.Email }, model.Password);

            if (result.Succeeded) return RedirectToAction("Login");
            return RedirectToAction("Register");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password)
        {
            var result = await _signInManager.PasswordSignInAsync(userName, password, false, false);
            if (!result.Succeeded) return RedirectToAction("Login");
            return RedirectToAction("AddRole");
        }
        
        [Authorize]
        public async Task<IActionResult> AddRole()
        {


            User user = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name);

            if (!await _userManager.IsInRoleAsync(user, Roles.HR))
                await _userManager.AddToRoleAsync(user, Roles.HR);


            if (!await _userManager.IsInRoleAsync(user, Roles.IT))
                await _userManager.AddToRoleAsync(user, Roles.IT);

            if (!await _userManager.IsInRoleAsync(user, Roles.Marketing))
                await _userManager.AddToRoleAsync(user, Roles.Marketing);

            if (!await _userManager.IsInRoleAsync(user, Roles.OF))
                await _userManager.AddToRoleAsync(user, Roles.OF);

            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
