using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Forsaj.Models;
using Microsoft.AspNetCore.Hosting;

namespace Forsaj.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ForsajContext _context;
        private readonly IHostingEnvironment _env;
        public HomeController(ForsajContext context, IHostingEnvironment env)
        {
            _env = env;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Marka = _context.Markas.ToList();
            ViewBag.ModelCars = _context.Model_Cars.ToList();
            ViewBag.Country = _context.Countries.ToList();

            return View();
        }

        public IActionResult AddPost()
        {
            ViewBag.Marka = _context.Markas.ToList();
            ViewBag.ModelCars = _context.Model_Cars.ToList();
            ViewBag.Country = _context.Countries.ToList();
            ViewBag.City = _context.Cities.ToList();
            ViewBag.Ban_Type = _context.Ban_Types.ToList();
            ViewBag.Transmissions = _context.Transmissions.ToList();
            ViewBag.Speed_Types = _context.Speed_Types.ToList();
            ViewBag.Currencies = _context.Currencies.ToList();
            ViewBag.Fuel_Types = _context.Fuel_Types.ToList();
            ViewBag.Powers = _context.Powers.ToList();
            ViewBag.Colors = _context.Colors.ToList();
            ViewBag.Years = _context.Years.ToList();

            return View();
        }
        public IActionResult Filter()
        {
            ViewBag.Marka = _context.Markas.ToList();
            ViewBag.ModelCars = _context.Model_Cars.ToList();
            ViewBag.Country = _context.Countries.ToList();
            ViewBag.City = _context.Cities.ToList();
            ViewBag.Ban_Type = _context.Ban_Types.ToList();
            ViewBag.Transmissions = _context.Transmissions.ToList();
            ViewBag.Speed_Types = _context.Speed_Types.ToList();
            ViewBag.Currencies = _context.Currencies.ToList();
            ViewBag.Fuel_Types = _context.Fuel_Types.ToList();
            ViewBag.Powers = _context.Powers.ToList();
            ViewBag.Colors = _context.Colors.ToList();
            ViewBag.Years = _context.Years.ToList();




            return View();
        }


    }
}
