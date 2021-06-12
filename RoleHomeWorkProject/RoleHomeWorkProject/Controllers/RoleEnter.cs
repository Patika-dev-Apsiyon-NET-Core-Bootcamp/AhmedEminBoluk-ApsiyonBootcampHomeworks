using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleHomeWorkProject.Controllers
{
    public class RoleEnter : Controller
    {
        [RefreshLogin]
        [AuthorizeByRole(Roles.HR, Roles.IT, Roles.Marketing, Roles.OF)]
        public IActionResult FourRole()
        {
            return View();
        }

        [AuthorizeByRole(Roles.SEC)]
        public IActionResult Security()
        {
            return View();
        }
    }
}
