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

        public IActionResult ViewUpdate(int Id)
        {
            using (var _context = new BlogCMSContext())
            {
                var menu = _context.Menus.FirstOrDefault(x => x.Id == Id);
                return View(menu);
            }
        }

        [HttpPost]
        public IActionResult Update(Menu menu)
        {
            using (var _context = new BlogCMSContext())
            {
                _context.Menus.Update(menu);
                var sayac = _context.SaveChanges();
                if (sayac > 0)
                {
                    TempData["Status"] = "success";
                    return Redirect("/Menu");
                }
                TempData["Status"] = "error";
                return Redirect("/Menu");
            }
            
        }

        public IActionResult Delete(int Id)
        {
            using (var _context = new BlogCMSContext())
            {
                var silinecek = _context.Menus.FirstOrDefault(x => x.Id == Id);
                _context.Remove(silinecek);
                var sayac = _context.SaveChanges();
                if (sayac > 0)
                {
                    TempData["Status"] = "success";
                    return Redirect("/Menu");
                }

                TempData["Status"] = "error";
                return Redirect("/Menu");
            }
        }
    }
}