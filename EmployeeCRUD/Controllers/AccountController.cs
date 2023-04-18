using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeeCRUD.Data;
using EmployeeCRUD.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.Extensions.Options;

namespace EmployeeCRUD.Controllers
{
    public class AccountController : Controller
    {
        private readonly IOptions<List<Account>> _users;

        public AccountController(IOptions<List<Account>> users)
        {

            _users = users;
        }




        // GET: Account/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Account userToLogin)
        {
            if (userToLogin.UserName == "Admin" && userToLogin.Password == "Admin@123")
            {
                
                return Redirect("/Employee/Index");
            }



            //var user = _users.Value.Find(c => c.UserName == userToLogin.UserName && c.Password == userToLogin.Password);

            //if (!(user is null))
            //{
            //    var claims = new List<Claim>
            //{
            //    new Claim(ClaimTypes.Name,userToLogin.UserName),
            //    new Claim("FullName", userToLogin.UserName),
            //    new Claim(ClaimTypes.Role, "Administrator"),
            //};

            //    var claimsIdentity = new ClaimsIdentity(
            //        claims, CookieAuthenticationDefaults.AuthenticationScheme);

            //    var authProperties = new AuthenticationProperties
            //    {

            //        RedirectUri = "/Employee/Index",

            //    };

            //    await HttpContext.SignInAsync(
            //        CookieAuthenticationDefaults.AuthenticationScheme,
            //        new ClaimsPrincipal(claimsIdentity),
            //        authProperties);
            //}

            ViewBag.Message = string.Format("Invalid Credentials..!!");
            return Redirect("/Account/Create");
            
        }

    }
}
