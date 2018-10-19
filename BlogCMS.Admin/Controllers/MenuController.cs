using System;
using Microsoft.AspNetCore.Mvc;

namespace BlogCMS.Admin.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create()
        {
            ViewData["Status"] = "succues";
            return Redirect("URL");
        }

        public IActionResult ViewUpdate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update()
        {
            ViewData["Status"] = "succues";
            return Redirect("URL");
        }

        public IActionResult Delete(int Id)
        {
            ViewData["Status"] = "succues";
            return Redirect("URL");
        }
    }
}