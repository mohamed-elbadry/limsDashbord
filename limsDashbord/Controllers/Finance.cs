using Microsoft.AspNetCore.Mvc;

namespace limsDashbord.Controllers
{
    public class Finance : Controller
    {
        public IActionResult Expenses()
        {
            return View();
        }
        public IActionResult Incomes()
        {
            return View();
        }
        public IActionResult TreasuriesBankAccounts()
        {
            return View();
        }
        public IActionResult FinanceSettings()
        {
            return View();
        }
    }
}
