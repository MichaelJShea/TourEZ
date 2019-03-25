using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TourEZ.Models;

namespace TourEZ.Controllers
{
    public class HomeController : Controller
    {
        [Route("Dashboard")]
        [HttpGet]
        public IActionResult Dashboard()
        {
            return View();
        }

    }
}
