using Microsoft.AspNetCore.Mvc;

namespace AreasASP.Areas.Blogs.Controllers
{
    [Area("Blogs")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
