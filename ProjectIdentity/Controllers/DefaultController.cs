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

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            ViewBag.name = values.Name;
            ViewBag.surname = values.Surname;
            ViewBag.Mail = values.Email;
            userEditViewModel.Name = values.Name;
            userEditViewModel.Surname = values.Surname;
            userEditViewModel.Mail = values.Email;
            userEditViewModel.Phone = values.PhoneNumber;
            return View(userEditViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> EditIndex()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            ViewBag.name = values.Name;
            ViewBag.surname = values.Surname;
            ViewBag.Mail = values.Email;
            userEditViewModel.Name = values.Name;
            userEditViewModel.Surname = values.Surname;
            userEditViewModel.Mail = values.Email;
            userEditViewModel.Phone = values.PhoneNumber;
            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditIndex(UserEditViewModel userEditViewModel)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.name = values.Name;
            ViewBag.surname = values.Surname;
            ViewBag.Mail = values.Email;
            values.Name = userEditViewModel.Name;
            values.Surname=userEditViewModel.Surname;
            values.PhoneNumber = userEditViewModel.Phone;
            values.Email = userEditViewModel.Mail;
            await _userManager.UpdateAsync(values);
            return View();

        }


    }
}
