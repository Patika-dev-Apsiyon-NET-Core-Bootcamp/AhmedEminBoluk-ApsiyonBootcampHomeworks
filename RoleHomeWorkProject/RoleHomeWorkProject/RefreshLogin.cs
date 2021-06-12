using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using RoleHomeWorkProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoleHomeWorkProject
{
    public class RefreshLogin : ActionFilterAttribute
    {
        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (context.HttpContext.User == null)
                return;
            var userManager = context.HttpContext.RequestServices.GetRequiredService<UserManager<User>>();
            var signManager = context.HttpContext.RequestServices.GetRequiredService<SignInManager<User>>();

            var user = await userManager.GetUserAsync(context.HttpContext.User);

            if (signManager.IsSignedIn(context.HttpContext.User))
            {
                await signManager.RefreshSignInAsync(user);
            }
            //executing
            await next();
            //executed
        }
    }
}
