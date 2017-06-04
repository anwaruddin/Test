using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Models
{
    public interface IMovieRepository
    {
        void Add(Movie movie);
        IEnumerable<Movie> GetAll();
        Movie FindMovie(int Id);
        void Remove(int Id);
        void Update(Movie movie);
    }
}
