namespace SeriesTracker.Models
{
    class MockRepository: IMovieRepository {
        private List<Movie> _movieList;
        public MockRepository()
        {
            _movieList = new List<Movie>()
            {
                new Movie { Id = 1, Title = "Movie 1", Genre = "Action", Director = "Director 1", Year = 2021 },
                new Movie { Id = 2, Title = "Movie 2", Genre = "Comedy", Director = "Director 2", Year = 2022 }
            };
        }
    public IEnumerable<Movie> GetMovies()
    {
        return _movieList;
    }
    public Movie GetMovie(int id)
    {
        return _movieList.FirstOrDefault(e => e.Id == id);
    }
    }
}
