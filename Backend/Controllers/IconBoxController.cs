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
    public class IconBoxController : ControllerBase
    {
        private readonly AppDbContext _context;

        public IconBoxController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/iconbox
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IconBox>>> GetIconBoxes()
        {
            var iconBoxes = await _context.IconBoxes.ToListAsync();
            return Ok(iconBoxes);
        }

        // GET: api/iconbox/1
        [HttpGet("{id}")]
        public async Task<ActionResult<IconBox>> GetIconBox(int id)
        {
            var iconBox = await _context.IconBoxes.FindAsync(id);

            if (iconBox == null)
                return NotFound("IconBox not found");

            return Ok(iconBox);
        }

        // POST: api/iconbox
        [HttpPost]
        public async Task<ActionResult> CreateIconBox([FromBody] IconBox newIconBox)
        {
            _context.IconBoxes.Add(newIconBox);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetIconBox), new { id = newIconBox.Id }, newIconBox);
        }

        // PUT: api/iconbox/1
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateIconBox(int id, [FromBody] IconBox updatedIconBox)
        {
            if (id != updatedIconBox.Id)
                return BadRequest("ID mismatch");

            _context.Entry(updatedIconBox).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/iconbox/1
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteIconBox(int id)
        {
            var iconBox = await _context.IconBoxes.FindAsync(id);
            if (iconBox == null)
                return NotFound("IconBox not found");

            _context.IconBoxes.Remove(iconBox);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
