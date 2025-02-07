using System.ComponentModel.DataAnnotations;

namespace SeriesTracker.Models
{
    public class Show
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Title { get; set; }

        public string? Genre { get; set; }

        public int Seasons { get; set; }
    }
}
