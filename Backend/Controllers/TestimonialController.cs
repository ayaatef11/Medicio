using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Data;
using Backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TestimonialController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/testimonial
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Testimonial>>> GetTestimonials()
        {
            var testimonials = await _context.Testimonials.ToListAsync();
            return Ok(testimonials);
        }

        // GET: api/testimonial/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Testimonial>> GetTestimonial(int id)
        {
            var testimonial = await _context.Testimonials.FindAsync(id);

            if (testimonial == null)
                return NotFound("Testimonial not found");

            return Ok(testimonial);
        }

        // POST: api/testimonial
        [HttpPost]
        public async Task<ActionResult> CreateTestimonial([FromBody] Testimonial newTestimonial)
        {
            _context.Testimonials.Add(newTestimonial);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTestimonial), new { id = newTestimonial.Id }, newTestimonial);
        }

        // PUT: api/testimonial/1
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTestimonial(int id, [FromBody] Testimonial updatedTestimonial)
        {
            if (id != updatedTestimonial.Id)
                return BadRequest("ID mismatch");

            _context.Entry(updatedTestimonial).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/testimonial/1
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTestimonial(int id)
        {
            var testimonial = await _context.Testimonials.FindAsync(id);
            if (testimonial == null)
                return NotFound("Testimonial not found");

            _context.Testimonials.Remove(testimonial);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
