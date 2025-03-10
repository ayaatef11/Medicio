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
    public class ServiceController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/service
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Service>>> GetServices()
        {
            var services = await _context.Services.ToListAsync();
            return Ok(services);
        }

        // GET: api/service/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Service>> GetService(int id)
        {
            var service = await _context.Services.FindAsync(id);

            if (service == null)
                return NotFound("Service not found");

            return Ok(service);
        }

        [HttpPost]
        public async Task<ActionResult> CreateService([FromBody] Service newService)
        {
            _context.Services.Add(newService);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetService), new { id = newService.Id }, newService);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateService(int id, [FromBody] Service updatedService)
        {
            if (id != updatedService.Id)
                return BadRequest("ID mismatch");

            _context.Entry(updatedService).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteService(int id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service == null)
                return NotFound("Service not found");

            _context.Services.Remove(service);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
