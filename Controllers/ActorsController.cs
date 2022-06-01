using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMVC.Data;
using TestMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace TestMVC.Controllers
{
    public class ActorsController : Controller
    {
        private ApplicationDbContext db;
        public ActorsController(ApplicationDbContext _db)
        {
            db = _db;
        }
        //[HttpGet("Actors")]
        public IActionResult Index(string name = "", string lastname = "", int yearfrom = 1, int yearto = 2100, int ratingfrom = 0, int ratingto = 10)
        {
            IEnumerable<Actor> Actors = db.Actors;
            if (name != null) Actors = Actors.Where(c => c.Name.Contains(name));
            if (lastname != null) Actors = Actors.Where(c => c.LastName.Contains(lastname));
            Actors = Actors.Where(c => c.BirthDate.Year >= yearfrom && c.BirthDate.Year <= yearto && c.Rating >= ratingfrom && c.Rating <= ratingto);

            //.Where(c => c.Name.Contains(name) && c.LastName.Contains(lastname)
            //&& c.BirthDate.Year >= yearfrom && c.BirthDate.Year <= yearto && c.Rating >= ratingfrom && c.Rating <= ratingto);

            return View(Actors);
        }

        public IActionResult Actor(int id)
        {
            using (db)
            {
                return View(db.Actors.Include(c => c.Movies).FirstOrDefault(c => c.Id == id));
            }
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Actor actor)
        {
            db.Actors.Add(actor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0) return NotFound();
            Actor actor = db.Actors.Find(id);
            if (actor == null) return NotFound();
            return View(actor);
        }
        [HttpPost]
        public IActionResult Edit(Actor actor)
        {
            db.Actors.Update(actor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            return View();
        }
    }
}
