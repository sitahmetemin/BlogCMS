using System;
using System.Linq;
using BlogCMS.Core;
using BlogCMS.Entites.Conrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogCMS.Admin.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            using (var context = new BlogCMSContext())
            {
                if (TempData["Status"] != null)
                {
                    ViewData["Status"] = TempData["Status"];
                }
                var model = context.Menus.Where(a => a.DeletedAt == null).ToList();
                return View(model);
            }
            
        }

        public IActionResult ViewCreate()
        {
            using (var context = new BlogCMSContext())
            {
                var model = context.Menus.Where(z => z.DeletedAt == null).ToList();
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult Create(Menu menu)
        {
            using (var _context = new BlogCMSContext())
            {
                _context.Add(menu);
                _context.SaveChanges();
                TempData["Status"] = "success";
                return Redirect("/Menu");
            }
            
        }

        public IActionResult ViewUpdate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update()
        {
            TempData["Status"] = "success";
            return Redirect("URL");
        }

        public IActionResult Delete(int Id)
        {
            TempData["Status"] = "success";
            return Redirect("URL");
        }
    }
}