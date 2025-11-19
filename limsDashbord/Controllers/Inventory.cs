using Microsoft.AspNetCore.Mvc;

namespace limsDashbord.Controllers
{
    public class Inventory : Controller
    {
        public IActionResult Products()
        {
            return View();
        }
        public IActionResult Requisitions()
        {
            return View();
        }
        public IActionResult Warehouses()
        {
            return View();
        }
        public IActionResult ProductSettings()
        {
            return View();
        }
    }
}
