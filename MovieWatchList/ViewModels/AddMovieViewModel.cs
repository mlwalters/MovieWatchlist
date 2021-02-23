using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWatchList.ViewModels
{
    public class AddMovieViewModel
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        public string Genre { get; set; }
    }
}
