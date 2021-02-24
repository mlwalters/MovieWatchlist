using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWatchList.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public double Rating { get; set; }
        public string MainActor { get; set; }

        public Movie()
        {

        }

        public Movie(string title, string director, string genre)
        {
            Title = title;
            Director = director;
            Genre = genre;
        }

        public Movie(string title, string director, string genre, double rating, string mainActor)
        {
            Title = title;
            Director = director;
            Genre = genre;
            Rating = rating;
            MainActor = mainActor;
        }

        public override string ToString()
        {
            return Title;
        }

        public override bool Equals(object obj)
        {
            return obj is Movie @movie &&
                   Id == @movie.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
