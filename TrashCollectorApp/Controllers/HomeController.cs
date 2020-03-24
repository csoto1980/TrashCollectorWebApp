﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrashCollectorApp.ActionFilters;
using TrashCollectorApp.Models;

namespace TrashCollectorApp.Controllers
{
    //[Authorize]
    //[Authorize(Roles = "Home")]
    //[ServiceFilter(typeof(GlobalRouting))]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (User.IsInRole("Customers"))
            {
                return RedirectToAction("Index", "Customers");

            }
            else if (User.IsInRole("Employees"))
            {
                return RedirectToAction("Index", "Employees");

            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
