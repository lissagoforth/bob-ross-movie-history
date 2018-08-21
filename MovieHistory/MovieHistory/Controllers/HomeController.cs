﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieHistory.Models;
using Microsoft.Extensions.Configuration;
using MovieHistory.Services;
using Microsoft.Extensions.Options;

namespace MovieHistory.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApplicationConfiguration _appSettings;

        public HomeController(IApplicationConfiguration appSettings)
        {
            _appSettings = appSettings;
        }

        public IActionResult Index()
        {
            ViewData["apiKey"] = _appSettings.MovieAPIKey;
            ViewData["Message"] = "Welcome to Movie History!";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
