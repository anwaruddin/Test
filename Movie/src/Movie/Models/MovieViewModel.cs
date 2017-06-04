using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Models
{
    public class MovieViewModel
    {
        public int MovieId { get; set; }
        [DisplayName("Movie Name")]
        [Required(ErrorMessage ="Movie Name Required")]
        public string MovieName { get; set; }
        [DisplayName("Year")]
        [Required(ErrorMessage = "Year Required")]
        public int Year { get; set; }
    }
}
