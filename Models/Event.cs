using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TourEZ.Models
{
    public class ValidateDate: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Event activity = (Event)validationContext.ObjectInstance;
            DateTime now = DateTime.Now;
            DateTime fullTime = activity.startDate.Date + activity.startTime.TimeOfDay;
            if (fullTime > now)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Has to be in the future rapscallion.");
            }
        }
    }
    public class Event
    {
        [Key]
        public int eventId {get;set;}
        [Display(Name="Event Name")]
        public string eventName {get;set;}
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true), Display(Name = "Start Date")]
        public DateTime startDate {get;set;}

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true), Display(Name = "Start Time")]
        public DateTime startTime {get;set;}
        public DateTime start
        {
            get
            {
                return startDate.Date + startTime.TimeOfDay;
            }
        }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true), Display(Name = "End Date")]
        public DateTime endDate {get;set;}

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true), Display(Name = "End Time")]
        public DateTime endTime {get;set;}
        public DateTime end
        {
            get
            {
                return endDate.Date + endTime.TimeOfDay;
            }
        }
        public TimeSpan duration
        {
            get 
            {
                return end - start;
            }
        }
        [Display(Name="Location")]
        public string location {get;set;}
        public int placeId {get;set;}
        public Place placeInfo {get;set;}
        public DateTime created_at {get;set;} = DateTime.Now;

       
    }
}