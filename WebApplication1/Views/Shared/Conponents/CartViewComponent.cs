using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Views.Shared.Conponents
{
    public class CartViewComponent
    {
    }
}
public class CartViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
