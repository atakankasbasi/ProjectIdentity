using Microsoft.AspNetCore.Mvc;

namespace ProjectIdentity.Controllers
{
    public class MailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MailDetail()
        {
            return View();
        }

        public IActionResult MailWrite()
        {
            return View();
        }
    }
}
