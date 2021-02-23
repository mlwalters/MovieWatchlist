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

        public Movie()
        {

        }
        public Movie(string title, string genre)
        {
            Title = title;
            Genre = genre;
        }
    }
}
