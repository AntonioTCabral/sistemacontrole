using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pratice.Models;

namespace Pratice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var userInfo = HttpContext.Session.GetString("SessionUser");
            if (string.IsNullOrEmpty(userInfo))
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return View("Index");
            }
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
