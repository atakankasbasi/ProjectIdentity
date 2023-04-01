using Microsoft.AspNetCore.Mvc;

namespace ProjectIdentity.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
