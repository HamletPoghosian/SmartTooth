using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using SmartTooth.Models;
using SmartTooth.Services.Dentist;

namespace SmartTooth.Controllers
{
    public class DentistController : Controller
    {
        private IDentistService _dentist;

        public DentistController(IDentistService dentist)
        {
            _dentist = dentist;
        }

        public IActionResult Index()
        {
            ViewBag.MyModel = DateTime.Now; ;
            return View();
        }

        [HttpGet]
        public IActionResult CreateDentist()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDentist(Dentist model)
        {
            if (ModelState.IsValid)
            {
                model.Id = new Guid();
                await _dentist.AddAsync(model);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult AllDentist()
        {
            IEnumerable<Dentist> allDentist = _dentist.AllDentistsAsync();
            return View(allDentist);
        }
    }
}