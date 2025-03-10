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
    public class DoctorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DoctorController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/doctor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Doctor>>> GetDoctors()
        {
            var doctors = await _context.Doctors.Include(d => d.Socials).ToListAsync();
            return Ok(doctors);
        }

        // GET: api/doctor/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Doctor>> GetDoctor(int id)
        {
            var doctor = await _context.Doctors.Include(d => d.Socials).FirstOrDefaultAsync(d => d.Id == id);

            if (doctor == null)
                return NotFound("Doctor not found");

            return Ok(doctor);
        }

        // POST: api/doctor
        [HttpPost]
        public async Task<ActionResult> CreateDoctor([FromBody] Doctor newDoctor)
        {
            _context.Doctors.Add(newDoctor);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDoctor), new { id = newDoctor.Id }, newDoctor);
        }

        // PUT: api/doctor/1
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateDoctor(int id, [FromBody] Doctor updatedDoctor)
        {
            if (id != updatedDoctor.Id)
                return BadRequest("ID mismatch");

            _context.Entry(updatedDoctor).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/doctor/1
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteDoctor(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null)
                return NotFound("Doctor not found");

            _context.Doctors.Remove(doctor);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
