using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestMVC.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public float IMDB { get; set; }
        public float RT { get; set; }
        public float Budget { get; set; }
        public float Income { get; set; }
        public string ImgPath { get; set; }
        public Genre Genre { get; set; }
        public List<Director> Directors { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
