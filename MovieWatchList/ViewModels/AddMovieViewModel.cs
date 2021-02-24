﻿using System;
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
        public string Director { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        public string Genre { get; set; }
    
        public double Rating { get; set; }
        public string MainActor{ get; set; }
        public AddMovieViewModel() { }
        //public AddMovieViewModel(string title, string genre) 
        //{
        //    Title = title;
        //    Genre = genre;
        //}
    }
}
