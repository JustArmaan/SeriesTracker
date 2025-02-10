namespace SeriesTracker.Models
{
      public interface IMovieRepository
      {

      public IEnumerable<Movie> GetMovies();

      public Movie GetMovie(int id);



      }
}
