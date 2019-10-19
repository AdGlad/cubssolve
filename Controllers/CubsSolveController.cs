using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CubsSolve.Models;

namespace CubsSolve.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CubsSolveController : ControllerBase
    {
        private readonly CubsSolveContext _context;

        // PUT: api/CubsSolve/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCubsSolveItem(long id, CubsSolveItem item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
        // POST: api/CubsSolve
        [HttpPost]
        public async Task<ActionResult<CubsSolveItem>> PostCubsSolveItem(CubsSolveItem item)
        {
            _context.CubsSolveItems.Add(item);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCubsSolveItem), new { id = item.Id }, item);
        }
        // GET: api/CubsSolve
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CubsSolveItem>>> GetCubsSolveItems()
        {
            return await _context.CubsSolveItems.ToListAsync();
        }

        // GET: api/CubsSolve/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CubsSolveItem>> GetCubsSolveItem(long id)
        {
            var CubsSolveItem = await _context.CubsSolveItems.FindAsync(id);

            if (CubsSolveItem == null)
            {
                return NotFound();
            }

            return CubsSolveItem;
        }
        public CubsSolveController(CubsSolveContext context)
        {
            _context = context;

            if (_context.CubsSolveItems.Count() == 0)
            {
                // Create a new CubsSolveItem if collection is empty,
                // which means you can't delete all CubsSolveItems.
                _context.CubsSolveItems.Add(new CubsSolveItem { X1 = 10 });
                _context.SaveChanges();
            }
        }
    }
}