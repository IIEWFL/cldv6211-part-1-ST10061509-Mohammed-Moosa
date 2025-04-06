using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models
{
    public class Venue
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }  // Primary Key

        [Required]
        [StringLength(100)]  // Limit the length of the venue name to 100 characters
        public string Name { get; set; }

        [Required]
        [StringLength(200)]  // Limit the length of the location to 200 characters
        public string Location { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be greater than zero.")]
        public int Capacity { get; set; }

        [StringLength(500)]  // Limit the URL length
        public string ImageURL { get; set; }

        public bool IsAvailable { get; set; } = true; // Default value
    }
}
