using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TourEZ.Models
{
    public class Traveler
    {
        public int travelerId {get;set;}
        public int userId {get;set;}
        public int tripId {get;set;}
        public User user {get;set;}
        public Trip trip {get;set;}
    }
}