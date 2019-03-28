using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TourEZ.Models
{
    public class newEventVM
    {
        public Place newPlace {get; set;}
        public Event newEvent {get; set;}
    }
}