using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TourEZ.Models
{
    public class Event
    {
        [Key]
        public int eventId {get;set;}
        public string eventName {get;set;}
        public DateTime start {get;set;}
        public DateTime end {get;set;}
        public string location {get;set;}
        public DateTime created_at {get;set;} = DateTime.Now;

       
    }
}