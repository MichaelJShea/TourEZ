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
        private Context dbContext;
        public HomeController(Context context)
        {
            dbContext = context;
        }
        [Route("Dashboard")]
        [HttpGet]
        public IActionResult Dashboard()
        {
            ViewModel AllEvents = new ViewModel()
            {
                AllEvents = dbContext.Events.OrderBy(e => e.start).ToList()
            };
            return View("Dashboard", AllEvents);
        }


        [Route("event/{id}")]
        public IActionResult ViewEvent(int id)
        {
            ViewModel ViewEvent = new ViewModel()
            {
                ThisEvent = dbContext.Events.FirstOrDefault(e => e.eventId == id)
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
