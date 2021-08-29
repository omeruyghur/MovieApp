using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.Entity;
using MovieApp.Models;

namespace MovieApp.Controllers
{
     [Authorize]
    public class GenreController : Controller
    {
        private readonly MovieContext _context;
        public GenreController(MovieContext context)
        {
            _context = context;
        }
        private GenreViewModel GetGenres()
        {
            return new GenreViewModel
            {
                Genres = _context.Genres.Select(a => new GenreModel
                {
                    GenreId = a.Id,
                    GenreName = a.Name,
                    Count = a.Movies.Count
                }).ToList()
            };
        }
        public IActionResult Index()
        {
            ViewBag.Count = _context.Genres.Count();
            return View(GetGenres());
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _context.Genres.Select(i => new GenreEditModel
            {
                GenreId = i.Id,
                GenreName = i.Name,
                Movies = i.Movies.Select(a => new MovieViewModel
                {
                    MovieId = a.MovieId,
                    Name = a.Name,
                    ImageUrl = a.ImageUrl
                }).ToList()
            }).FirstOrDefault(i => i.GenreId == id);
            return View(entity);
        }
        [HttpPost]
        public IActionResult Edit(GenreEditModel model, int[] MovieIds)
        {
            if (ModelState.IsValid)
            {
                if (model == null)
                {
                    return NotFound();
                }
                var entity = _context.Genres.Include("Movies").FirstOrDefault(i => i.Id == model.GenreId);
                entity.Name = model.GenreName;
                foreach (var id in MovieIds)
                {
                    entity.Movies.Remove(entity.Movies.FirstOrDefault(i => i.MovieId == id));
                }
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);

        }
        public IActionResult GenreDelete(int? genreId)
        {
            var entity = _context.Genres.Find(genreId);
            if (entity != null)
            {
                _context.Genres.Remove(entity);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult GenreCreate(GenreViewModel model)
        {
            // if (model.GenreName != null && model.GenreName.Length < 3 || model.GenreName.Length > 20)
            // {
            //     ModelState.AddModelError("GenreName", "3-20 karakter arasi olmalı");
            // }
            if (ModelState.IsValid)
            {
                // var entity = new Genre
                // {
                //     Name = model.GenreName
                // };

                _context.Genres.Add(new Genre { Name = model.GenreName });
                _context.SaveChanges();
            }
            return View("Index", GetGenres());

        }
    }
}



