using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TourEZ.Models
{
    public class ViewModel
    {
        public List<Event> AllEvents {get; set;}
        public Event ThisEvent {get; set;}
    }
}