using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookingSystem_Hairdresser.Tables
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!; 

        [Required]
        public int HairdresserId { get; set; }
        public Hairdresser Hairdresser { get; set; } = null!;
    }
}

