using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMVC.Data;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class UserCommentController : Controller
    {
        private ApplicationDbContext db;
        public UserCommentController(ApplicationDbContext _db)
        {
            db = _db;
        }
        [HttpPost]
        public IActionResult Post(int? movieId, string comment)
        {
            if (comment != null && movieId != null)
            {
                UserComment uc = new UserComment
                {
                    User = db.Users.FirstOrDefault(c => c.Id == HttpContext.Session.GetInt32("userid")),
                    Movie = db.Movies.FirstOrDefault(c => c.Id == movieId),
                    Comment = comment
                };
                db.UserComment.Add(uc);
                db.SaveChanges();

            }
            return RedirectToAction("Movie", "Movies", movieId);
        }

        [HttpPost]
        public IActionResult Edit(int? id, string comment)
        {
            UserComment uc = db.UserComment.FirstOrDefault(c => c.Id == id);
            if (id != null && comment != null)
            {
                if (uc != null)
                {
                    uc.Comment = comment;
                    db.UserComment.Update(uc);
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Movie", "Movies", uc.Movie.Id);
        }

        public IActionResult Delete(int? id)
        {
            UserComment uc = db.UserComment.FirstOrDefault(c => c.Id == id);
            db.UserComment.Remove(uc);
            db.SaveChanges();
            return RedirectToAction("Movie", "Movies", uc.Movie.Id);
        }
    }
}
