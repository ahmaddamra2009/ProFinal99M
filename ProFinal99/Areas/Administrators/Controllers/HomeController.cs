using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProFinal99.Areas.Administrators.Controllers
{
    [Area("Administrators")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("name") != null)
            {
                ViewBag.uName = HttpContext.Session.GetString("name");
                return View();
            }
            return RedirectToAction("Login", "Home", new { area = "" });

        }
    }
}
