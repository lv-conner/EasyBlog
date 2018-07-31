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
using Easyblog.Dto;
using EasyBlog.Services;

namespace EasyBlog.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountServices _accountService;
        public AccountController(IAccountServices accountServices)
        {
            _accountService = accountServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDto loginDto,string returnUrl)
        {
            ClaimsIdentity identity = new ClaimsIdentity("easyBlog");
            identity.AddClaim(new Claim(ClaimTypes.Sid, "00001"));
            identity.AddClaim(new Claim(ClaimTypes.Name, "tim lv"));
            identity.AddClaim(new Claim(ClaimTypes.Role, "author"));
            ClaimsPrincipal user = new ClaimsPrincipal(identity);
            AuthenticationProperties properties = new AuthenticationProperties();
            properties.IsPersistent = loginDto.RememberMe;
            properties.ExpiresUtc = new DateTimeOffset(DateTime.Now, TimeSpan.FromMinutes(20));
            await HttpContext.SignInAsync(user,properties);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(UsersDto user)
        {
            _accountService.Signup(user.Name, user.Password);
            return RedirectToAction(nameof(Index), "Host");
        }
    }
}