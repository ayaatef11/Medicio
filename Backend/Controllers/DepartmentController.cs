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
    public class DepartmentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DepartmentController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/department
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetAll()
        {
            return await _context.Departments.ToListAsync();
        }

        // GET: api/department/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> Get(string id)
        {
            var department = await _context.Departments.FindAsync(id);
            if (department == null)
                return NotFound("Department not found");

            return Ok(department);
        }

        // POST: api/department
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Department newDepartment)
        {
            _context.Departments.Add(newDepartment);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = newDepartment.Id }, newDepartment);
        }

        // PUT: api/department/1
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(string id, [FromBody] Department updatedDepartment)
        {
            if (id != updatedDepartment.Id)
                return BadRequest("ID mismatch");

            _context.Entry(updatedDepartment).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/department/1
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            var department = await _context.Departments.FindAsync(id);
            if (department == null)
                return NotFound("Department not found");

            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
