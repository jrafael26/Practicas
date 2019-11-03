using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationMovies.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Summary { get; set; }
    }
}