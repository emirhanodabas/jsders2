﻿using jsders2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace jsders2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DersOn()
        {
            return View();
        }
        public IActionResult DersOnBir()
        {
            return View();
        }
        public IActionResult DersOnIki()
        {
            return View();
        }

        public IActionResult Bootstrap()
        {
            return View();
        }
        public IActionResult Siparis()
        {
            return View();
        }
        public IActionResult Kaydet(string adiniz, string email, string mesaj,string konu)
        {
            return View("Bootstrap");
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