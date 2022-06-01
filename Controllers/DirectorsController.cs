using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMVC.Data;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class DirectorsController : Controller
    {
        private ApplicationDbContext db;
        public DirectorsController(ApplicationDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index(string name = "", string lastname = "", int yearfrom = 1, int yearto = 2100, int ratingfrom = 0, int ratingto = 10)
        {
            IEnumerable<Director> Directors = db.Directors;
            if(name!=null) Directors = Directors.Where(c => c.Name.Contains(name));
            if (lastname != null) Directors = Directors.Where(c => c.LastName.Contains(lastname));
            Directors = Directors.Where(c => c.BirthDate.Year >= yearfrom && c.BirthDate.Year <= yearto && c.Rating >= ratingfrom && c.Rating <= ratingto);

            return View(Directors);
        }

        public IActionResult Director(int? id)
        {
            using (db)
            {
                return View(db.Directors.Include(c => c.Movies).FirstOrDefault(c => c.Id == id));
            }
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Director director)
        {
            db.Directors.Add(director);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) return NotFound();
            Director director = db.Directors.Find(id);
            if (director == null) return NotFound();
            return View(director);
        }
        [HttpPost]
        public IActionResult Edit(Director director)
        {
            db.Directors.Update(director);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
