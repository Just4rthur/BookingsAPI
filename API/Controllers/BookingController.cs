using Microsoft.AspNetCore.Mvc;
using BookingsApi.Models;
using BookingsApi.Services;

namespace BookingsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingsController : ControllerBase
    {    
        private readonly IBookingService _service;

        // Use constructor injection for IBookingService (DI best practice)
        public BookingsController(IBookingService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var booking = _service.GetById(id);
            return booking == null ? NotFound() : Ok(booking);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Booking booking)
        {            
            if (_service.HasOverlap(booking.RoomId, booking.From, booking.To))
            {
                return Conflict("Booking overlaps an existing reservation.");
            }

            var created = _service.Create(booking);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        // DELETE /api/bookings/{id}
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var booking = _service.GetById(id);
            if (booking == null)
                return NotFound();
            _service.Cancel(id);
            return NoContent();
        }
    }
}
