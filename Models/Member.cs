using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace TourEZ.Models
{
    public class Member
    {
        public int memberId {get;set;}
        public int userId {get;set;}
        public int groupId {get;set;}
        public User user {get;set;}
        public Group group {get;set;}
    }
}