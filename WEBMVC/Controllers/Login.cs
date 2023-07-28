using Microsoft.AspNetCore.Mvc;

namespace WEBMVC.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
