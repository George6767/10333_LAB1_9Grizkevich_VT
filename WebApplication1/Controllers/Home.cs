using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApplication1.Controllers
{
    public class Home : Controller
    {
        public class ListDemo
        {
            public int ListItemValue { get; set; }
            public string ListItemText { get; set; }
        }
        private List<ListDemo> _listDemo;

        public Home(List<ListDemo> listDemo)
        {
            _listDemo = listDemo;
            _listDemo = new List<ListDemo>
            {
                new ListDemo { ListItemValue = 1, ListItemText = "Item 1" },
                new ListDemo { ListItemValue = 2, ListItemText = "Item 2" },
                new ListDemo { ListItemValue = 3, ListItemText = "Item 3" }
};

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
