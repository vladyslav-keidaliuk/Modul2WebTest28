﻿using Microsoft.AspNetCore.Mvc;

namespace Modul2WebTest28.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
