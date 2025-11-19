using Microsoft.AspNetCore.Mvc;

namespace limsDashbord.Controllers
{
    public class Purchases : Controller
    {
        public IActionResult PurchaseInvoices()
        {
            return View();
        }
        public IActionResult Suppliers()
        {
            return View();
        }
        public IActionResult SupplierPayments()
        {
            return View();
        }
    }
}
