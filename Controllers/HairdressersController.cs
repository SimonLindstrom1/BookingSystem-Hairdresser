using BookingSystem_Hairdresser.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookingSystem_Hairdresser.Controllers
{
    [ApiController]
    [Route("api/hairdressers")]
    public class HairdressersController : ControllerBase
    {
        private readonly HairdresserService hairdresserService;

        public HairdressersController(HairdresserService _hairdresserService)
        {
            hairdresserService = _hairdresserService;
        }

        [HttpGet]
        public IActionResult GetAllHairdressers()
        {
            var hairdressers = hairdresserService.GetHairdressers();
            return Ok(hairdressers);
        }
    }
}
