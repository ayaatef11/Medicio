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
    public class CountBoxController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CountBoxController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/countbox
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CountBox>>> GetAll()
        {
            return await _context.CountBoxes.ToListAsync();
        }

        // GET: api/countbox/1
        [HttpGet("{id}")]
        public async Task<ActionResult<CountBox>> Get(int id)
        {
            var countBox = await _context.CountBoxes.FindAsync(id);
            if (countBox == null)
                return NotFound("CountBox not found");

            return Ok(countBox);
        }

        // POST: api/countbox
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CountBox newCountBox)
        {
            _context.CountBoxes.Add(newCountBox);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = newCountBox.Id }, newCountBox);
        }

        // PUT: api/countbox/1
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] CountBox updatedCountBox)
        {
            if (id != updatedCountBox.Id)
                return BadRequest("ID mismatch");

            _context.Entry(updatedCountBox).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/countbox/1
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var countBox = await _context.CountBoxes.FindAsync(id);
            if (countBox == null)
                return NotFound("CountBox not found");

            _context.CountBoxes.Remove(countBox);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
