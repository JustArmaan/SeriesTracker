using System.ComponentModel.DataAnnotations;

namespace SeriesTracker.Models
{
    public class Series
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Genre { get; set; } = string.Empty;

        [Required]
        public string Creator { get; set; } = string.Empty;

        public int Seasons { get; set; }
    }
}
