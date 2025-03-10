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
    public class UsefulLinkController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsefulLinkController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/usefullink
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsefulLink>>> GetUsefulLinks()
        {
            var usefulLinks = await _context.UsefulLinks.ToListAsync();
            return Ok(usefulLinks);
        }

        // GET: api/usefullink/1
        [HttpGet("{id}")]
        public async Task<ActionResult<UsefulLink>> GetUsefulLink(int id)
        {
            var usefulLink = await _context.UsefulLinks.FindAsync(id);

            if (usefulLink == null)
                return NotFound("UsefulLink not found");

            return Ok(usefulLink);
        }

        // POST: api/usefullink
        [HttpPost]
        public async Task<ActionResult> CreateUsefulLink([FromBody] UsefulLink newUsefulLink)
        {
            _context.UsefulLinks.Add(newUsefulLink);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUsefulLink), new { id = newUsefulLink.Id }, newUsefulLink);
        }

        // PUT: api/usefullink/1
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateUsefulLink(int id, [FromBody] UsefulLink updatedUsefulLink)
        {
            if (id != updatedUsefulLink.Id)
                return BadRequest("ID mismatch");

            _context.Entry(updatedUsefulLink).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/usefullink/1
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUsefulLink(int id)
        {
            var usefulLink = await _context.UsefulLinks.FindAsync(id);
            if (usefulLink == null)
                return NotFound("UsefulLink not found");

            _context.UsefulLinks.Remove(usefulLink);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
