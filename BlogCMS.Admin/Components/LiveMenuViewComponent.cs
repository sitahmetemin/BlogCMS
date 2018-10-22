using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogCMS.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace BlogCMS.Admin.Components
{
    public class LiveMenuViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            using (var _context = new BlogCMSContext())
            {
                var menu = _context.Menus.Where(z => z.DeletedAt == null).ToList();
                return View(menu);
            }
        }
    }
}
