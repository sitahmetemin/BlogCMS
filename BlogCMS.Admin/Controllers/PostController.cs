using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogCMS.Admin.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            if (TempData["Status"] != null)
            {
                ViewData["Status"] = TempData["Status"];
            }
            return View();
        }

        public IActionResult ViewCreate()
        {
            return View();
        }

        public IActionResult Create()
        {
            TempData["Status"] = "success";
            return Redirect("URL");
        }

        public IActionResult ViewUpdate()
        {
            return View();
        }

        public IActionResult Update()
        {
            TempData["Status"] = "success";
            return Redirect("URL");
        }

        public IActionResult Delete()
        {
            TempData["Status"] = "success";
            return Redirect("URL");
        }
    }
}