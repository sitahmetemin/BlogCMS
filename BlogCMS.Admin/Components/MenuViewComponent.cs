using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace BlogCMS.Admin.Components
{
    public class MenuViewComponent : ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            return View();
        }
    }
}
