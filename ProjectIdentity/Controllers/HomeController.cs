using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectIdentity.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectIdentity.Controllers
{
    public class HomeController : Controller
    {  
        public IActionResult ErrorPage(int code)
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HaberIndex()
        {
            return View();
        }

    }
}
