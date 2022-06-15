using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestMVC.Models
{
    public class UserComment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Movie Movie { get; set; }
        [Required]
        public string Comment { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
    }
}
