using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectIdentity.Models;
using System.Threading.Tasks;

namespace ProjectIdentity.Controllers
{
    public class MailController : Controller
    {

        private readonly UserManager<AppUser> _userManager;

        public MailController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.name = values.Name;
            ViewBag.surname = values.Surname;
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
