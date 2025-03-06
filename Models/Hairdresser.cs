using System.ComponentModel.DataAnnotations;

namespace BookingSystem_Hairdresser.Tables
{
    public class Hairdresser
    {
        [Key]
        public int HairdresserId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;
        public List<Appointment> Appointments { get; set; } = new();
    }
}
