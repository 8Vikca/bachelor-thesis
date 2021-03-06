using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using bakalarska_praca.Models;

namespace bakalarska_praca.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Dashboard
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Attack>>> GetAttacks()
        {
            return await _context.Attacks.ToListAsync();
        }

        // GET: api/Dashboard/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Attack>> GetAttack(int id)
        {
            var attack = await _context.Attacks.FindAsync(id);

            if (attack == null)
            {
                return NotFound();
            }

            return attack;
        }

        // PUT: api/Dashboard/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAttack(int id, Attack attack)
        {
            if (id != attack.Id)
            {
                return BadRequest();
            }

            _context.Entry(attack).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AttackExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Dashboard
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Attack>> PostAttack(Attack attack)
        {
            _context.Attacks.Add(attack);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAttack", new { id = attack.Id }, attack);
        }

        // DELETE: api/Dashboard/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Attack>> DeleteAttack(int id)
        {
            var attack = await _context.Attacks.FindAsync(id);
            if (attack == null)
            {
                return NotFound();
            }

            _context.Attacks.Remove(attack);
            await _context.SaveChangesAsync();

            return attack;
        }

        private bool AttackExists(int id)
        {
            return _context.Attacks.Any(e => e.Id == id);
        }
    }
}
