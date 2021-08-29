using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MovieApp.Entity;

namespace MovieApp.Models
{
    public class GenreViewModel
    {
        [Required(ErrorMessage = "Zorunlu Alan")]
        [Display(Name = "Tür Adı")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "3-20 karakter arası olmalı")]
        public string GenreName { get; set; }
        public List<GenreModel> Genres { get; set; }
    }
    public class GenreModel
    {
        public int GenreId { get; set; }
        [Display(Name = "Tür Adı")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "3-20 karakter arası olmalı")]
        [Required(ErrorMessage = "Zorunlu Alan")]
        public string GenreName { get; set; }
        public int Count { get; set; }
    }

    public class GenreEditModel
    {
        public int GenreId { get; set; }
        [Display(Name = "Tür Adı")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "3-20 karakter arası olmalı")]
        [Required(ErrorMessage = "Zorunlu Alan")]
        public string GenreName { get; set; }
        public List<MovieViewModel> Movies { get; set; }
    }
}