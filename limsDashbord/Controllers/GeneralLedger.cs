using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace limsDashbord.Controllers
{
    public class GeneralLedger : Controller
    {
        public IActionResult JournalEntries()
        {
            return View();
        }
        public IActionResult AddJournalEntry()
        {
            return View();
        }
        public IActionResult ChartofAccounts()
        {
            return View();
        }
        public IActionResult Assets()
        {
            return View();
        }
        public IActionResult GeneralLedgerSettings()
        {
            return View();
        }
        public IActionResult FinancelPeriods()
        {
            return View();
        }
        public IActionResult ClosedPeriods()
        {
            return View();
        }
    }
}
