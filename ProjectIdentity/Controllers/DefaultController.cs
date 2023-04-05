using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectIdentity.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;

namespace ProjectIdentity.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DefaultController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = values.Name;
            userEditViewModel.Surname = values.Surname;
            userEditViewModel.Mail = values.Email;
            userEditViewModel.Phone = values.PhoneNumber;
            return View(userEditViewModel);
        }
    }
}
