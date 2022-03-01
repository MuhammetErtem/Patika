using Microsoft.AspNetCore.Mvc;

namespace Patika.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
