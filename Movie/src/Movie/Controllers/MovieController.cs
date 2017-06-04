using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie.Models;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Movie.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieContext _context;
        public MovieController(MovieContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> MovieList()
        {
            return View(await _context.Movies.ToListAsync());
        }

        public IActionResult AddMovie(int id)
        {
           
                    if(id>0)
                    {
                
               Movie.Models.Movie objmovie = _context.Movies.Where(m => m.MovieId == id).SingleOrDefault();
                if(objmovie!=null)
                {
                    MovieViewModel obj=new MovieViewModel { MovieId=objmovie.MovieId,MovieName=objmovie.MovieName,Year=objmovie.Year};
                    return View(obj);
                }

              
                }

            
            return View();
        }
     
        [HttpPost]
        public IActionResult AddMovie(MovieViewModel _movie)
        {
            if (ModelState.IsValid)
            {
                Movie.Models.Movie obj = new Models.Movie();
                obj.MovieName = _movie.MovieName;
                obj.Year = _movie.Year;
                _context.Movies.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("MovieList");
            }
            return View();
        }
    }
}
