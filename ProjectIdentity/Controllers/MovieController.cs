using Microsoft.AspNetCore.Mvc;

namespace ProjectIdentity.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
