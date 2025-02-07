using Microsoft.AspNetCore.Mvc;
using SeriesTracker.Models;
using System.Collections.Generic;

namespace SeriesTracker.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            List<Movie> movies = GetMovies();
            return View(movies);
        }

        private List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Title = "Movie 1", Genre = "Action", Director = "Director 1", Year = 2021 },
                new Movie { Id = 2, Title = "Movie 2", Genre = "Comedy", Director = "Director 2", Year = 2022 }
            };
        }
    }
}
