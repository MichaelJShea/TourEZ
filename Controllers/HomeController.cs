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
    public class HomeController : Controller
    {
        private Context dbContext;
        public HomeController(Context context)
        {
            dbContext = context;
        }
        [Route("Dashboard")]
        [HttpGet]
        public IActionResult Dashboard()
        {
            viewEventVM AllEvents = new viewEventVM()
            {
                AllEvents = dbContext.Events.Include(e => e.placeInfo).OrderBy(e => e.start).ToList()
            };
            return View("Dashboard", AllEvents);
        }


        [Route("event/{id}")]
        public IActionResult ViewEvent(int id)
        {
            viewEventVM ViewEvent = new viewEventVM()
            {
                ThisEvent = dbContext.Events.Include(e => e.placeInfo).FirstOrDefault(e => e.eventId == id)
            };
            return View("ViewEvent", ViewEvent);
        }

        [Route("event/delete/{id}")]
        public IActionResult DeleteEvent(int id)
        {

            Event ThisEvent = dbContext.Events.FirstOrDefault(e => e.eventId == id);
            
            dbContext.Remove(ThisEvent);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

    }
}
