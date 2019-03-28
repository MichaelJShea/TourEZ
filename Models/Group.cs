using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TourEZ.Models
{
    public class Group
    {
        [Key]
        public int groupId {get;set;}
        public string name {get;set;}
        public List<Member> members {get;set;}
        public List<Trip> trips {get;set;}
    }
}