using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace limsDashbord.Controllers
{
    public class Reports : Controller
    {
        public IActionResult SalesReports()
        {
            return View();
        }
        public IActionResult PurchaseReports()
        {
            return View();
        }
        public IActionResult GeneralLedgerReports()
        {
            return View();
        }
        public IActionResult CustomerReports()
        {
            return View();
        }
        public IActionResult InventoryReports()
        {
            return View();
        }
        public IActionResult AccountActivityLog()
        {
            return View();
        }
    }
}
