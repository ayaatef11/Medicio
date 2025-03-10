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
    public class SlideController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SlideController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/slide
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Slide>>> GetSlides()
        {
            var slides = await _context.Slides.ToListAsync();
            return Ok(slides);
        }

        // GET: api/slide/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Slide>> GetSlide(int id)
        {
            var slide = await _context.Slides.FindAsync(id);

            if (slide == null)
                return NotFound("Slide not found");

            return Ok(slide);
        }

        // POST: api/slide
        [HttpPost]
        public async Task<ActionResult> CreateSlide([FromBody] Slide newSlide)
        {
            _context.Slides.Add(newSlide);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSlide), new { id = newSlide.Id }, newSlide);
        }

        // PUT: api/slide/1
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateSlide(int id, [FromBody] Slide updatedSlide)
        {
            if (id != updatedSlide.Id)
                return BadRequest("ID mismatch");

            _context.Entry(updatedSlide).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/slide/1
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSlide(int id)
        {
            var slide = await _context.Slides.FindAsync(id);
            if (slide == null)
                return NotFound("Slide not found");

            _context.Slides.Remove(slide);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
