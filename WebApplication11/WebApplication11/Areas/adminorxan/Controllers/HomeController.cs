using Microsoft.AspNetCore.Mvc;

namespace WebApplication11.Areas.adminorxan.Controllers
{
    public class HomeController : Controller
    {
        [Area("adminorxan")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
