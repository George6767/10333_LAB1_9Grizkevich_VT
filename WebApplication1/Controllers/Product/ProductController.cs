using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers.Product

{
    public class ProductController : Controller
    {
        public IActionResult Index()

        {
            return View();
        }
    }

}

