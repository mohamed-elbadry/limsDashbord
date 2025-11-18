using Microsoft.AspNetCore.Mvc;

namespace limsDashbord.Controllers
{
    public class Quality : Controller
    {
        public IActionResult sop()
        {
            return View();
        }
        public IActionResult ControlCharts()
        {
            return View();
        }
    }
}
