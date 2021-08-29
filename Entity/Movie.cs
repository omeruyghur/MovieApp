using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieApp.Entity
{
    public class Movie
    {
        public Movie()
        {
            Genres = new List<Genre>();
        }
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string fragmentUrl { get; set; }
        public string RunningTime { get; set; }
        public string Imdb { get; set; }
        public string Quality { get; set; }
        public DateTime ReleaseYear { get; set; }
        public bool IsHome { get; set; }
        public bool IsSlayder { get; set; }
        public List<Genre> Genres { get; set; }

    }
}