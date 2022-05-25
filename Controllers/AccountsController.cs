using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMVC.Data;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class AccountsController : Controller
    {
        private ApplicationDbContext db;
        public AccountsController(ApplicationDbContext _db)
        {
            db = _db;
        }
        public IActionResult LogIn()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return View("LogIn");
        }
    }
}
