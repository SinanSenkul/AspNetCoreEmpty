using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreEmpty.Controllers
{
    public class UserController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
    }
}
