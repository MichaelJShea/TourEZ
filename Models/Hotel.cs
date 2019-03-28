using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TourEZ.Models
{
    public class Hotel
    {
        [Key]
        public int hotelId {get;set;}
        
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
        [Display(Name="Location")]
        public string location {get;set;}
        public int placeId {get;set;}
        public Place placeInfo {get;set;}
        public int tripId {get;set;}
        public Trip trip {get;set;}
        public DateTime created_at {get;set;} = DateTime.Now;
       
    }
}