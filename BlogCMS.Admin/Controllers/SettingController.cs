using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogCMS.Core;
using Microsoft.AspNetCore.Mvc;

namespace BlogCMS.Admin.Controllers
{
    public class SettingController : Controller
    {
        public IActionResult Index()
        {
            using (var _contex = new BlogCMSContext())
            {
                var model = _contex.Settings.First(z => z.Id == 1);
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult Update()
        {
            TempData["Status"] = "succues";
            return Redirect("URL");
        }
    }
}