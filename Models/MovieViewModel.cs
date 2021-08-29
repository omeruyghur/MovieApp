using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MovieApp.Entity;

namespace MovieApp.Models
{
    public class MovieViewModels
    {
        public List<MovieViewModel> Movies { get; set; }
    }
    public class MovieViewModel
    {
        public int MovieId { get; set; }
        [Display(Name = "Film Adı")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "3-20 karakter arası olmalı")]
        [Required(ErrorMessage = "Zorunlu Alan")]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        [Display(Name = "Film Açıklaması")]
        [StringLength(2000, MinimumLength = 3, ErrorMessage = "3-2000 karakter arası olmalı")]
        [Required(ErrorMessage = "Zorunlu Alan")]
        public string Description { get; set; }
        public string fragmentUrl { get; set; }
        public string RunningTime { get; set; }
        public string Imdb { get; set; }
        public string Quality { get; set; }
        public DateTime ReleaseYear { get; set; }
        public bool IsHome { get; set; }
        public bool IsSlayder { get; set; }
        public List<Genre> Genres { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        public int[] GenreIds { get; set; }
    }
    public class MovieEditViewModel
    {
        public int MovieId { get; set; }
        [Display(Name = "Film Adı")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "3-20 karakter arası olmalı")]
        [Required(ErrorMessage = "Zorunlu Alan")]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        [Display(Name = "Film Açıklaması")]
        [StringLength(2000, MinimumLength = 3, ErrorMessage = "3-2000 karakter arası olmalı")]
        [Required(ErrorMessage = "Zorunlu Alan")]
        public string Description { get; set; }
        //public List<Genre> SelectedGenres { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan")]
        public int[] GenreIds { get; set; }

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