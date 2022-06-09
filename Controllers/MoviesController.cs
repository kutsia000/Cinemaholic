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
    public class MoviesController : Controller
    {
        private ApplicationDbContext db;
        public MoviesController(ApplicationDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index(string name = "", int genre = -1, int rtratingfrom = 0, int rtratingto = 10, int ratingfrom = 0, int ratingto = 10)
        {
            IEnumerable<Movie> movies = db.Movies.Include(c => c.Genre);
            List<Genre> genres = new List<Genre>();
            Genre g = new Genre { Id = 1, Name = "აირჩიეთ" };
            genres.Add(g);
            genres.AddRange(db.Genres.ToList());

            IEnumerable<Genre> gr = genres;
            ViewBag.Genres = gr;

            if (name != null) movies = movies.Where(c => c.Name.Contains(name));
            if (genre != null && genre > 0) movies = movies.Where(c => c.Genre.Id == genre);
            movies = movies.Where(c => c.IMDB >= ratingfrom && c.IMDB <= ratingto && c.RT >= rtratingfrom && c.RT <= rtratingto);
            ViewBag.Movies = movies;

            return View(ViewBag);
        }

        public IActionResult Add()
        {
            IEnumerable<Genre> genres = db.Genres;
            ViewBag.Genres = genres;
            return View(ViewBag);
        }

        [HttpPost]
        public IActionResult Add(Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            var movie = db.Movies.FirstOrDefault(c => c.Id == id);
            if (movie != null)
            {
                db.Movies.Remove(movie);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
