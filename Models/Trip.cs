using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TourEZ.Models
{
    public class Trip
    {
        [Key]
        public int tripId {get;set;}
        public string tripName {get;set;}
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true), Display(Name = "Check in date")]
        public DateTime startDate {get;set;}
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true), Display(Name = "Check out date")]
        public DateTime endDate {get;set;}
        public TimeSpan duration
        {
            get 
            {
                return endDate - startDate;
            }
        }
        public List<Event> events {get;set;}
        public List<Hotel> hotels {get;set;}
        public int groupId {get;set;}
        public Group group {get;set;}
    }
}