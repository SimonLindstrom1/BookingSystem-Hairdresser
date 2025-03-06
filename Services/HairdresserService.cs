using BookingSystem_Hairdresser.Data;
using BookingSystem_Hairdresser.DTOs;

namespace BookingSystem_Hairdresser.Services
{
    public class HairdresserService
    {
        private readonly BookingDbContext context;

        public HairdresserService(BookingDbContext _context)
        {
            context = _context;
        }

        public List<HairdresserDTO> GetHairdressers()
        {
            return context.Hairdressers
                .Select(h => new HairdresserDTO
                {
                    Id = h.HairdresserId,
                    Name = h.Name,
                    PhoneNumber = h.PhoneNumber
                })
                .ToList();
        }
    }
}
