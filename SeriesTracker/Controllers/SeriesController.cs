using Microsoft.AspNetCore.Mvc;
using SeriesTracker.Models;
using System.Collections.Generic;

namespace SeriesTracker.Controllers
{
    public class SeriesController : Controller
    {
        public IActionResult Index()
        {
            var seriesList = new List<Series>
            {
                new Series { Title = "Breaking Bad", Genre = "Crime, Drama", Creator = "Vince Gilligan", Seasons = 5 },
                new Series { Title = "Stranger Things", Genre = "Sci-Fi, Horror", Creator = "The Duffer Brothers", Seasons = 4 },
                new Series { Title = "Game of Thrones", Genre = "Fantasy, Drama", Creator = "David Benioff & D. B. Weiss", Seasons = 8 }
            };

            return View(seriesList);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
