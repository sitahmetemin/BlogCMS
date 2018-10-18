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
    }
}