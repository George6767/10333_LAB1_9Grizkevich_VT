using Microsoft.AspNetCore.Mvc;

namespace WebLabsV05.Controllers
{
    public class ImageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

