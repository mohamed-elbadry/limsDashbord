using Microsoft.AspNetCore.Mvc;

namespace limsDashbord.Controllers
{
    public class Sales : Controller
    {
        public IActionResult Requests()
        {
            return View();
        }
        public IActionResult SalesOrders()
        {
            return View();
        }
        public IActionResult Invoices()
        {
            return View();
        }
        public IActionResult Customers()
        {
            return View();
        }
        public IActionResult Projects()
        {
            return View();
        }
        public IActionResult CustomerPayments()
        {
            return View();
        }
    }
}
