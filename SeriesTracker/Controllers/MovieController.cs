using Microsoft.AspNetCore.Mvc;
using SeriesTracker.Models;
using System.Collections.Generic;

namespace SeriesTracker.Controllers
{
    public class MovieController : Controller
    {
                private readonly IMovieRepository _movieRepository;
                  public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IActionResult Index()
        {
            var movies = _movieRepository.GetMovies();
            return View(movies);
        }
    }
}
