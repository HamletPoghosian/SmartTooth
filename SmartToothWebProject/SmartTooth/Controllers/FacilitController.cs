﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SmartTooth.Controllers
{
    public class FacilitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Facility()
        {
            ViewBag.Facility = DateTime.Now;
            return View();
        }
    }
}