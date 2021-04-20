using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ProFinal99.Data;
using ProFinal99.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProFinal99.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext context;
        public HomeController(ILogger<HomeController> logger,AppDbContext _context)
        {
            context = _context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Register()
        {
            ViewBag.Roles = new SelectList(context.Roles, "RoleId", "RoleName");
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user) {

            try
            {
                if (ModelState.IsValid)
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                    return RedirectToAction("Login");
                }

            }
            catch (Exception ex)
            {

                ViewBag.Err=ex.Message;
            }
            return View(user);
        
        }
        
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            try
            {
                var query = context.Users.Where(x => x.UserName.Equals(user.UserName) && x.Password.Equals(user.Password));
                if (query.Any() && query!=null)
                {
                    HttpContext.Session.SetString("name", user.UserName);
                    return RedirectToAction("Index", "Home", new { area = "Administrators" });
                }
                return View(user);
            }
            catch (Exception ex)
            {

                ViewBag.errMsg = ex.Message;
            }
            return View(user);
        }
    }
}
