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
    public class OurServiceController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OurServiceController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/ourservice
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OurService>>> GetOurServices()
        {
            var ourServices = await _context.OurServices.ToListAsync();
            return Ok(ourServices);
        }

        // GET: api/ourservice/1
        [HttpGet("{id}")]
        public async Task<ActionResult<OurService>> GetOurService(int id)
        {
            var ourService = await _context.OurServices.FindAsync(id);

            if (ourService == null)
                return NotFound("OurService not found");

            return Ok(ourService);
        }

        // POST: api/ourservice
        [HttpPost]
        public async Task<ActionResult> CreateOurService([FromBody] OurService newOurService)
        {
            _context.OurServices.Add(newOurService);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOurService), new { id = newOurService.Id }, newOurService);
        }

        // PUT: api/ourservice/1
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateOurService(int id, [FromBody] OurService updatedOurService)
        {
            if (id != updatedOurService.Id)
                return BadRequest("ID mismatch");

            _context.Entry(updatedOurService).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/ourservice/1
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteOurService(int id)
        {
            var ourService = await _context.OurServices.FindAsync(id);
            if (ourService == null)
                return NotFound("OurService not found");

            _context.OurServices.Remove(ourService);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
