using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.Entity;
using MovieApp.Models;

namespace MovieApp.Controllers
{
     [Authorize]
    public class MovieController : Controller
    {
        private readonly MovieContext _context;
        public MovieController(MovieContext context)
        {
            _context = context;
        }

        public IActionResult Index(string q)
        {
            // film ve tur tablosunu dahil ederiz
            var m = _context.Movies
            .Include(a => a.Genres)
            .Select(m => new MovieViewModel
            {
                MovieId = m.MovieId,
                Name = m.Name,
                Description = m.Description,
                ImageUrl = m.ImageUrl,
                Genres = m.Genres.ToList()
            }).AsQueryable();//sonraki işlemleri yapabilmek için asqueryable olması lazım


            if (!string.IsNullOrWhiteSpace(q))
            {
                m = m.Where(i => i.Name.ToLower().Contains(q.ToLower()) || i.Description.ToLower().Contains(q.ToLower()));
            }
            return View(m.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            //genre bilgilerini alip viewde select olarak gösterir
            ViewBag.Genres = _context.Genres.ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(MovieViewModel model, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var entity = new Movie
                {

                    Name = model.Name,
                    Description = model.Description,
                    ImageUrl = "no_image.png",
                    Imdb = model.Imdb,
                    fragmentUrl = model.fragmentUrl,
                    Quality = model.Quality,
                    RunningTime = model.RunningTime,
                    IsHome = model.IsHome,
                    IsSlayder = model.IsSlayder,
                    ReleaseYear = model.ReleaseYear
                };


                foreach (var id in model.GenreIds)
                {
                    entity.Genres.Add(_context.Genres.FirstOrDefault(i => i.Id == id));
                }
                if (file != null)
                {
                    var extension = Path.GetExtension(file.FileName);
                    var fileName = string.Format($"{Guid.NewGuid()}{extension}");
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", fileName);
                    model.ImageUrl = fileName;
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                _context.Movies.Add(entity);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Genres = _context.Genres.ToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _context.Movies
                .Select(a => new MovieEditViewModel
                {
                    MovieId = a.MovieId,
                    Name = a.Name,
                    Description = a.Description,
                    ImageUrl = a.ImageUrl,
                    Imdb = a.Imdb,
                    fragmentUrl = a.fragmentUrl,
                    Quality = a.Quality,
                    RunningTime = a.RunningTime,
                    IsHome = a.IsHome,
                    IsSlayder = a.IsSlayder,
                    ReleaseYear = a.ReleaseYear,
                    GenreIds = a.Genres.Select(i => i.Id).ToArray()
                }).FirstOrDefault(i => i.MovieId == id);
            if (entity == null)
            {
                return NotFound();
            }
            //genre bilgilerini alip viewde select olarak gösterir
            ViewBag.Genres = _context.Genres.ToList();

            return View(entity);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(MovieEditViewModel model, int[] GenreIds, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var entity = _context.Movies.Include(i => i.Genres).FirstOrDefault(i => i.MovieId == model.MovieId);
                if (entity == null)
                {
                    return NotFound();
                }

                entity.MovieId = model.MovieId;
                entity.Name = model.Name;
                entity.Description = model.Description;
                entity.fragmentUrl = model.fragmentUrl;
                entity.Imdb = model.Imdb;
                entity.IsHome = model.IsHome;
                entity.IsSlayder = model.IsSlayder;
                entity.ReleaseYear = model.ReleaseYear;
                entity.RunningTime = model.RunningTime;
                entity.Quality = model.Quality;


                //parametre olarak aldiğimiz id lere karşilik gelen idleri atariz
                entity.Genres = model.GenreIds.Select(id => _context.Genres.FirstOrDefault(i => i.Id == id)).ToList();
                if (file != null)
                {
                    var extension = Path.GetExtension(file.FileName);
                    var fileName = string.Format($"{Guid.NewGuid()}{extension}");
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", fileName);
                    entity.ImageUrl = fileName;
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Genres = _context.Genres.ToList();
            return View(model);

        }
        public IActionResult Details(int id)
        {
            var m = _context.Movies
                        .Where(i => i.MovieId == id)
                        .Include(a => a.Genres)
                        .FirstOrDefault();

            return View(m);
        }
        public IActionResult MovieDelete(int? MovieId)
        {
            var entity = _context.Movies.Find(MovieId);

            if (entity != null)
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}

