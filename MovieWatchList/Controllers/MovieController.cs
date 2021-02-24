using Microsoft.AspNetCore.Mvc;
using MovieWatchList.Data;
using MovieWatchList.Models;
using MovieWatchList.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWatchList.Controllers
{
    public class MovieController : Controller
    {
        private MovieContext context;

        public MovieController(MovieContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            List<Movie> movies = context.Movies.ToList();
            return View(movies);
        }

        // GET
        public IActionResult Add()
        {
           
            AddMovieViewModel addNewMovie = new AddMovieViewModel();

            return View(addNewMovie);
        }

        //POST
        [HttpPost]
        //[Route("add")]
        public IActionResult Add(AddMovieViewModel addNewMovie)
        {
            if (ModelState.IsValid)
            {
                Movie newMovie = new Movie(addNewMovie.Title, addNewMovie.Director, addNewMovie.Genre, addNewMovie.Rating, addNewMovie.MainActor);
        
                context.Movies.Add(newMovie);
                context.SaveChanges();

                return Redirect("/Movie/Index");
            }
            return View(addNewMovie);
        }

}
}
