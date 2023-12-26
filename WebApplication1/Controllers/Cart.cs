using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class Cart : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

