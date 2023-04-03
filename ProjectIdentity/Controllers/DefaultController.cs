using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectIdentity.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System;

namespace ProjectIdentity.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
