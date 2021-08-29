using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieApp.Data;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieContext _context;
        public HomeController(MovieContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // var movies = _context.Movies.ToList();
            var model = new HomeMovieModel();
            model.HomePageModel = _context.Movies.Where(i => i.IsHome == true).ToList();
            model.HomeSlyderModel = _context.Movies.Where(i => i.IsSlayder == true).ToList();

            return View(model);
        }
        public IActionResult List(int? id, string q)
        {
            //GenreId e göre listeleme
            var movies = _context.Movies.AsQueryable();
            if (id != null)
            {
                movies = movies
                .Include(m => m.Genres)
                .Where(i => i.Genres.Any(g => g.Id == id));
            }

            if (!string.IsNullOrWhiteSpace(q))
            {
                movies = movies.Where(i =>
                    i.Name.ToLower().Contains(q.ToLower()) ||
                    i.Description.ToLower().Contains(q.ToLower()));

            };
            return View(movies.ToList());

        }
        public IActionResult Contact()
        {

            return View();
        }
        public IActionResult Details(int id)
        {
            var detay = _context.Movies
                        .Where(i => i.MovieId == id)
                        .Include(i => i.Genres)
                        .FirstOrDefault();

            return View(detay);
        }
    }
}