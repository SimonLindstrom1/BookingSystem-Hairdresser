using BookingSystem_Hairdresser.Data;
using BookingSystem_Hairdresser.Tables;
using BookingSystem_Hairdresser.DTOs;
using BookingSystem_Hairdresser.DTOs.BookingSystem_Hairdresser.DTOs;


namespace BookingSystem_Hairdresser.Services
{
    public class AppointmentService
    {
        private readonly BookingDbContext context;

        public AppointmentService(BookingDbContext _context)
        {
            context = _context;
        }

        public bool AddBooking(BookingRequestDTO bookingRequest)
        {
            var hairdresser = context.Hairdressers.Find(bookingRequest.HairdresserId);
            if (hairdresser == null)
            {
                return false;
            }
            var appointment = new Appointment
            {
                HairdresserId = bookingRequest.HairdresserId,
                CustomerId = bookingRequest.CustomerId,
                DateTime = bookingRequest.DateTime
            };
            context.Appointments.Add(appointment);
            context.SaveChanges();
            return true;
        }

    }
}
