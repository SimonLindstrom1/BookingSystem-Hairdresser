using System.ComponentModel.DataAnnotations;

namespace BookingSystem_Hairdresser.Tables
{
    public class Customer
    {

        [Key]
        public int CustomerId { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Phone { get; set; } = string.Empty;
        public List<Appointment> Appointments { get; set; } = new();
    }
}
