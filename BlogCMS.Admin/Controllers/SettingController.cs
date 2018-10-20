using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogCMS.Core;
using BlogCMS.Entites.Conrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogCMS.Admin.Controllers
{
    public class SettingController : Controller
    {
        public IActionResult Index()
        {
            using (var _contex = new BlogCMSContext())
            {
                if (TempData["Status"] != null)
                {
                    ViewData["Status"] = TempData["Status"];
                }
                var model = _contex.Settings.First(z => z.Id == 1);
                return View(model);
            }
        }

        public IActionResult Update(Setting setting)
        {
            var _context = new BlogCMSContext();
            setting.Id = 1;
            _context.Settings.Update(setting);
            if(_context.SaveChanges() > 0)
            {
                TempData["Status"] = "success";
                return RedirectToAction("Index");
            }

            TempData["Status"] = "error";
            return Redirect("/Setting");
        }
    }
}