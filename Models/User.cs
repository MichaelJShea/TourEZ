using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TourEZ.Models
{
    public class User
    {
       [Key]
       public int UserId {get; set;}

       [Required]
       [MinLength(2, ErrorMessage="First name must be atleast 2 characters")]
       public string FirstName {get; set;}

       [Required]
       [MinLength(2, ErrorMessage="Last name must be atleast 2 characters")]
       public string LastName {get; set;}

       [Required]
       [DataType(DataType.EmailAddress, ErrorMessage="Invalid Email Address")]
       public string Email {get; set;}

       [Required]
       [MinLength(8, ErrorMessage="Password must be atleast 8 character long")]
       [DataType(DataType.Password)]
       public string Password {get; set;}
       public DateTime CreatedAt {get; set;} = DateTime.Now;
       public DateTime UpdatedAt {get; set;} = DateTime.Now;

       [NotMapped]
       [Compare("Password", ErrorMessage="Passwords does not match")]
       [DataType(DataType.Password)]
       [Display(Name = "Confirm Password")]
       public string Confirm {get; set;}

    }

    public class UserLogin
    {
       [Required]
       [DataType(DataType.EmailAddress, ErrorMessage="Invalid Email Address")]
       public string Email {get; set;}

       [Required]
       [MinLength(8, ErrorMessage="Password must be atleast 8 character long")]
       [DataType(DataType.Password)]
       public string Password {get; set;}
    }

    public class LoginRegistration
    {
        public User newUser {get; set;}
        public UserLogin returningUser {get; set;}
    }
}