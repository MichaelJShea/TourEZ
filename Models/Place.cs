using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TourEZ.Models
{
    public class Place
    {
        [Key]
        public int placeId {get;set;}
        public string name {get;set;}
        public double longitude {get; set;}
        public double latitude {get; set;}
        public string address {get;set;}
        public string phone {get;set;}
        public string website {get;set;}
        public string contactName {get;set;}
        public string email {get;set;}
        public List<Event> events {get;set;}
        public List<Hotel> hotels {get;set;}
    }
}