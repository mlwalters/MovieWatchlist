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

        [HttpPost]
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

        [HttpGet]
        [Route("/Movie/Edit/{movieId}")]
        public IActionResult Edit(int movieId)
        {
            Movie movieToBeEdited = context.Movies.Find(movieId);
            ViewBag.movieEdit = movieToBeEdited;
            ViewBag.title = movieToBeEdited.Title;

            context.SaveChanges();
            return View();
        }

        [HttpPost]
        [Route("/Movie/Edit")]
        public IActionResult SubmitEditMovieForm(int movieId, string title, string director, string genre, double rating, string mainActor)
        {
            Movie toEdit = context.Movies.Find(movieId);
            toEdit.Title = title;
            toEdit.Genre = genre;
            toEdit.Director = director;
            toEdit.Rating = rating;
            toEdit.MainActor = mainActor;

            context.SaveChanges();

            return Redirect("Movie/Index");
        }
    }
}
