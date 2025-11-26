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
        public IActionResult addedit()
        {
            return View();
        }
        public IActionResult AdvancedInventoryFilter()
        {
            return View();
        }
        public IActionResult AddWarehouses()
        {
            return View();
        }
        public IActionResult AddRequisitions()
        {
            return View();
        }
        public IActionResult Brands()
        {
            return View();
        }
        public IActionResult UnitTemplates()
        {
            return View();
        }
        public IActionResult AddCategories()
        {
            return View();
        }
    }
}
