using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem_Hairdresser.Database.Tables
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }

        [Required]
        public int HairdresserId { get; set; }

        [ForeignKey("HairdresserId")]
        public Hairdresser? Hairdresser { get; set; }
    }
}

