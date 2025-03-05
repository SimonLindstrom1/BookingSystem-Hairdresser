namespace BookingSystem_Hairdresser.Controllers;
using BookingSystem_Hairdresser.Data;
using BookingSystem_Hairdresser.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class AppointmentsController : ControllerBase
{
    private readonly BookingDbContext _context;

    public AppointmentsController(BookingDbContext context)
    {
        _context = context;
    }

    [HttpGet("hairdresser/{hairdresserId}")]
    public IActionResult GetAppointmentsForHairdresser(int hairdresserId)
    {
        var appointments = _context.Appointments
            .Where(a => a.HairdresserId == hairdresserId)
            .Include(a => a.Customer)
            .OrderBy(a => a.DateTime)
            .Select(a => new AppointmentDTO
            {
                DateTime = a.DateTime,
                CustomerName = a.Customer.Name,
                CustomerPhone = a.Customer.Phone
            })
            .ToList();

        return Ok(appointments);
    }
    [HttpDelete("{appointmentId}")]
    public IActionResult CancelAppointment(int appointmentId)
    {
        var appointment = _context.Appointments.Find(appointmentId);

        if (appointment == null)
        {
            return NotFound("Bokningen hittades inte.");
        }

        _context.Appointments.Remove(appointment);
        _context.SaveChanges();

        return Ok($"Bokningen {appointmentId} har avbokats.");
    }
}

