﻿using Koperasi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Koperasi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/dashboard")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/")]
        public IActionResult MyHome()
        {
            return RedirectToAction("Index");
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