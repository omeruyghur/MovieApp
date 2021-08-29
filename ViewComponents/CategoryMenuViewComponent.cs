using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Data;

namespace MovieApp.ViewComponents
{
    public class GenreViewComponent : ViewComponent
    {
        private readonly MovieContext _context;
        public GenreViewComponent(MovieContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedCategory = RouteData?.Values["id"];

            return View(_context.Genres.ToList());
        }
    }
}