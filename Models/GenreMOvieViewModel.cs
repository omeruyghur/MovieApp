using System.Collections.Generic;
using MovieApp.Entity;

namespace MovieApp.Models
{
    public class GenreMOvieViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Genre> Genres { get; set; }
    }
}