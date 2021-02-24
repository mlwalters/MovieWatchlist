using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MovieWatchList.Models;

namespace MovieWatchList.ViewModels
{
    public class AddMovieViewModel
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Director is required")]
        [StringLength(30, ErrorMessage = "Input can not exceed 50 characters")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        [StringLength(30, ErrorMessage = "Input can not exceed 50 characters")]
        public string Genre { get; set; }

        [Range(0, 10, ErrorMessage = "Please enter a range between 1-10")]
        public double Rating { get; set; }

        [StringLength(50, ErrorMessage = "Input can not exceed 50 characters")]
        public string MainActor{ get; set; }
        public AddMovieViewModel() { }
        //public AddMovieViewModel(string title, string genre) 
        //{
        //    Title = title;
        //    Genre = genre;
        //}
    }
}
