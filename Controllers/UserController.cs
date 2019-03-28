using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using TourEZ.Models;

namespace TourEZ.Controllers
{
    public class UserController : Controller
    {
        private Context dbContext;
        public UserController(Context context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return RedirectToAction("LoginReg");
        }

        [Route("LoginReg")]
        [HttpGet]
        public IActionResult LoginReg()
        {
            int? user_id = HttpContext.Session.GetInt32("UserId");
            if(user_id != null)
            {
                return RedirectToAction("Dashboard", "Home");
            }
            return View();
        }

        [HttpPost("/createUser")]
        public IActionResult CreateUser(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("User.Email", "Email already exists!");
                    return View("LoginReg");
                }

                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);

                dbContext.Add(newUser);
                dbContext.SaveChanges();

                User thisUser = dbContext.Users.Last();
                int id = thisUser.UserId;
                HttpContext.Session.SetInt32("UserId", id);
                HttpContext.Session.SetString("Username", thisUser.FirstName);

                return RedirectToAction("Dashboard", "Home");
            }
            else
            {
                return View("LoginReg");
            }
        }


        [HttpPost("/signin")]
        public IActionResult UserLogin(UserLogin returningUser)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == returningUser.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("UserLogin.Email", "Invalid Email or Password");
                    return View("LoginReg");
                }

                var hasher = new PasswordHasher<UserLogin>();
                var result = hasher.VerifyHashedPassword(returningUser, userInDb.Password, returningUser.Password);

                if(result == 0)
                {
                    ModelState.AddModelError("UserLogin.Email", "Invalid Email or Password");
                    return View("LoginReg");
                }
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                HttpContext.Session.SetString("Username", userInDb.FirstName);

                return RedirectToAction("Dashboard", "Home");
            }
            return View("LoginReg");
        }

        [HttpGet("/logout")]
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View("LoginReg");
        }

    }
}
