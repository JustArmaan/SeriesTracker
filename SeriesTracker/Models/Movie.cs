namespace SeriesTracker.Models
{
    public class Movie
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Genre { get; set; }
    public string? Director { get; set; }
    public int? Year { get; set; }

}

}
