using MapLatitudeLongitude.Data;
using MapLatitudeLongitude.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MapLatitudeLongitude.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuseumLocation : ControllerBase
    {
        private readonly AppDBContext _context;

        public MuseumLocation(AppDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetMuseumLocations(int MId)
        {
            var location = await _context.Museums.Where(m => m.Museum_id == MId)
                .Select(m => new MuseumLocationDto { MuseumId = m.Museum_id, MuseumName = m.Museum_Name, Latitude = m.latitude, Longitude = m.longitude })
                .FirstOrDefaultAsync();

            if (location == null)
                return NotFound("Museum not found");
            return Ok(location);
        }
    }
}
