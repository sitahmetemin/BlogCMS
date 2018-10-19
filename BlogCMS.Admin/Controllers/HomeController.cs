using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BlogCMS.Admin.Models;

namespace BlogCMS.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewCreate()
        {
            return View();
        }

        public IActionResult Create()
        {
            TempData["Status"] = "succues";
            return Redirect("URL");
        }

        public IActionResult ViewUpdate()
        {
            return View();
        }

        public IActionResult Update()
        {
            TempData["Status"] = "succues";
            return Redirect("URL");
        }

        public IActionResult Delete()
        {
            TempData["Status"] = "succues";
            return Redirect("URL");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
