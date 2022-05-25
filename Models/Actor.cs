using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestMVC.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(Order = 2)]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public float Rating { get; set; }
        public string ImgPath { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
