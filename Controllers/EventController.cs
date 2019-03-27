using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TourEZ.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace TourEZ.Controllers
{
    public class EventController : Controller
    {
        private Context dbContext;
        public EventController(Context context)
        {
            dbContext = context;
        }

        [Route("newevent")]
        [HttpGet]
        public IActionResult NewEvent()
        { 
            int? userId = HttpContext.Session.GetInt32("UserId");
            if(userId == null)
            {
                return RedirectToAction("LoginReg", "User");
            }
            return View("NewEvent");
        }

        [Route("newevent")]
        [HttpPost]
        public IActionResult AddEvent(Event newEvent)
        {
            dbContext.Add(newEvent);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard", "Home");
        }
    }
}
