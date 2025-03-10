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
    public class PricingPlanController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PricingPlanController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/pricingplan
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PricingPlan>>> GetPricingPlans()
        {
            var pricingPlans = await _context.PricingPlans.Include(p => p.Features).ToListAsync();
            return Ok(pricingPlans);
        }

        // GET: api/pricingplan/1
        [HttpGet("{id}")]
        public async Task<ActionResult<PricingPlan>> GetPricingPlan(int id)
        {
            var pricingPlan = await _context.PricingPlans.Include(p => p.Features).FirstOrDefaultAsync(p => p.Id == id);

            if (pricingPlan == null)
                return NotFound("PricingPlan not found");

            return Ok(pricingPlan);
        }

        // POST: api/pricingplan
        [HttpPost]
        public async Task<ActionResult> CreatePricingPlan([FromBody] PricingPlan newPricingPlan)
        {
            _context.PricingPlans.Add(newPricingPlan);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPricingPlan), new { id = newPricingPlan.Id }, newPricingPlan);
        }

        // PUT: api/pricingplan/1
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePricingPlan(int id, [FromBody] PricingPlan updatedPricingPlan)
        {
            if (id != updatedPricingPlan.Id)
                return BadRequest("ID mismatch");

            _context.Entry(updatedPricingPlan).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/pricingplan/1
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePricingPlan(int id)
        {
            var pricingPlan = await _context.PricingPlans.FindAsync(id);
            if (pricingPlan == null)
                return NotFound("PricingPlan not found");

            _context.PricingPlans.Remove(pricingPlan);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
