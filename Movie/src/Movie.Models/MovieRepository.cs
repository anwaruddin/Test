using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Models
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContext _context;

        public MovieRepository(MovieContext context)
        {
            _context = context;
        }
        public void Add(Movie movie)
        {
            _context.Add(movie);
            _context.SaveChanges();
        }

        public Movie FindMovie(int Id)
        {
          return  _context.Movies.FirstOrDefault(k => k.MovieId == Id);
        }

        public IEnumerable<Movie> GetAll()
        {
            return _context.Movies.ToList();
        }

        public void Remove(int Id)
        {
            var entity = _context.Movies.First(k => k.MovieId == Id);
            _context.Movies.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Movie movie)
        {
            _context.Movies.Update(movie);
            _context.SaveChanges();

        }
    }
}
