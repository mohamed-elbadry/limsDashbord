using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace limsDashbord.Controllers
{
    public class LabManagement : Controller
    {
        public IActionResult Samples()
        {
            return View();
        }
        public IActionResult WorkOrders()
        {
            return View();
        }
        public IActionResult SamplingOrders()
        {
            return View();
        }
        public IActionResult TestTypes()
        {
            return View();
        }
        public IActionResult Equipment()
        {
            return View();
        }
        public IActionResult ResultReports()
        {
            return View();
        }
        public IActionResult WorkFlowsRequests()
        {
            return View();
        }
    }
}
