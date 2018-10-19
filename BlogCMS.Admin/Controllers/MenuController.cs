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

        public IActionResult Create()
        {
            ViewData["Status"] = "succues";
            return Redirect("URL");
        }

        public IActionResult ViewUpdate()
        {
            return View();
        }

        public IActionResult Update()
        {
            ViewData["Status"] = "succues";
            return Redirect("URL");
        }

        public IActionResult Delete()
        {
            ViewData["Status"] = "succues";
            return Redirect("URL");
        }
    }
}