using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;
using Microsoft.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace EasyBlog.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Login()
        {
            ClaimsIdentity identity = new ClaimsIdentity("easyBlog");
            identity.AddClaim(new Claim(ClaimTypes.Sid, "00001"));
            identity.AddClaim(new Claim(ClaimTypes.Name, "tim lv"));
            identity.AddClaim(new Claim(ClaimTypes.Role, "author"));
            ClaimsPrincipal user = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(user);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}