using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogCMS.Admin.Controllers
{
    public class FileManagerController : Controller
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
    }
}