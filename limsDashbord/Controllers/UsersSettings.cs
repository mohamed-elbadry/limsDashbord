using Microsoft.AspNetCore.Mvc;

namespace limsDashbord.Controllers
{
    public class UsersSettings : Controller
    {
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult GroupsRoles()
        {
            return View();
        }
    }
}
