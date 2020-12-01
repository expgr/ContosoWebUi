using Microsoft.AspNetCore.Mvc;

namespace ContosoWeb
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}