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
    public class SocialLinkController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SocialLinkController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/sociallink
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SocialLink>>> GetSocialLinks()
        {
            var socialLinks = await _context.SocialLinks.ToListAsync();
            return Ok(socialLinks);
        }

        // GET: api/sociallink/1
        [HttpGet("{id}")]
        public async Task<ActionResult<SocialLink>> GetSocialLink(int id)
        {
            var socialLink = await _context.SocialLinks.FindAsync(id);

            if (socialLink == null)
                return NotFound("SocialLink not found");

            return Ok(socialLink);
        }

        // POST: api/sociallink
        [HttpPost]
        public async Task<ActionResult> CreateSocialLink([FromBody] SocialLink newSocialLink)
        {
            _context.SocialLinks.Add(newSocialLink);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSocialLink), new { id = newSocialLink.Id }, newSocialLink);
        }

        // PUT: api/sociallink/1
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateSocialLink(int id, [FromBody] SocialLink updatedSocialLink)
        {
            if (id != updatedSocialLink.Id)
                return BadRequest("ID mismatch");

            _context.Entry(updatedSocialLink).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/sociallink/1
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSocialLink(int id)
        {
            var socialLink = await _context.SocialLinks.FindAsync(id);
            if (socialLink == null)
                return NotFound("SocialLink not found");

            _context.SocialLinks.Remove(socialLink);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
