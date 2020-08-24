using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using _08202020_Lab21Lab25.Common;

namespace _08202020_Lab21Lab25.Models
{
    public class Movie
    {


        public int ID { get; set; }

        [StringLength(50, MinimumLength = 1, ErrorMessage = "Please enter a movie title between 1-50 characters.")]
        [Required(ErrorMessage ="Please enter the movie name.")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Please input the genre by selecting an option below.")]
        public string Genre { get; set; }
        [Required(ErrorMessage ="Please input the date the movie was made.")]
        [DateRange("1/1/1880", ErrorMessage = "Please input a valid date.")]
        public DateTime Year { get; set; }
        public string Actors { get; set; }
        public string Directors { get; set; }

    }
}
