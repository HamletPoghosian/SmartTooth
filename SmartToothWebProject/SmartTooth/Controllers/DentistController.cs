using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartTooth.Models;

namespace SmartTooth.Controllers
{
    public class DentistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateDentist()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateDentist(Dentist model)
        {

            return View();
        }
    }
}