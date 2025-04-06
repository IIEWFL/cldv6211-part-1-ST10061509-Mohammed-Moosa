namespace EventEase.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Booking
    {
        [Key]
        [Column("BookingId")]
        public int BookingId { get; set; }

        public string CustomerName { get; set; }

        public string ContactEmail { get; set; }

        public DateTime BookingDate { get; set; } = DateTime.Now;

        [Column("IsBooked")]
        public bool IsBooked { get; set; } = true;

        // Regular non-nullable integers
        public int VenueId { get; set; }  // Not a foreign key
        public int EventId { get; set; }  // Not a foreign key

        // Read-only alias
        public int Id => BookingId;
    }
}
