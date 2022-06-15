using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TestMVC.Data;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class AuthController : Controller
    {
        private ApplicationDbContext db;
        public AuthController(ApplicationDbContext _db)
        {
            db = _db;
        }

        private static string ComputeMd5Hash(string message)
        {
            using MD5 md5 = MD5.Create();
            byte[] input = Encoding.ASCII.GetBytes(message);
            byte[] hash = md5.ComputeHash(input);

            var sb = new StringBuilder();
            foreach (var t in hash)
            {
                sb.Append(t.ToString("X2"));
            }
            return sb.ToString();
        }

        public IActionResult Index()
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
            if (db.Users.FirstOrDefault(c => c.Email == user.Email) == null)
            {
                var pass = ComputeMd5Hash(user.Password);
                user.Password = pass;
                db.Users.Add(user);
                db.SaveChanges();
                return View("Index");
            }

            return View("Register");
        }

        [HttpPost]
        public IActionResult LogIn(string mail, string password)
        {
            var pass = ComputeMd5Hash(password);
            var user = db.Users.FirstOrDefault(c => c.Password == pass && c.Email == mail);
            if (user != null)
            {
                HttpContext.Session.SetInt32("userid", user.Id);
                HttpContext.Session.SetString("UserRole", user.UserType);
                return RedirectToAction("Index", "Movies");
            }
            return RedirectToAction("Index");
        }

        public IActionResult LogOut()
        {
            if (HttpContext.Session.GetInt32("userid") != null)
            {
                HttpContext.Session.Remove("userid");
                HttpContext.Session.Remove("UserRole");
            }

            return RedirectToAction("Index");
        }
    }
}
