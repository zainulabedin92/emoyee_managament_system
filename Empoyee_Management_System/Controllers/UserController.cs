using Microsoft.AspNetCore.Mvc;

namespace Empoyee_Management_System.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddUser()
        {
            return View();
        }
    }
}
