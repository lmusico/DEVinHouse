using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiretorController : ControllerBase
    {
        private readonly FilmesContext _context;

        public DiretorController(FilmesContext context)
        {
            _context = context;
        }

        // GET: api/Diretor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Diretor>>> GetDiretor()
        {
          if (_context.Diretor == null)
          {
              return NotFound();
          }
            return await _context.Diretor.ToListAsync();
        }

        // GET: api/Diretor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Diretor>> GetDiretor(int id)
        {
          if (_context.Diretor == null)
          {
              return NotFound();
          }
            var diretor = await _context.Diretor.FindAsync(id);

            if (diretor == null)
            {
                return NotFound();
            }

            return diretor;
        }

        // PUT: api/Diretor/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDiretor(int id, Diretor diretor)
        {
            if (id != diretor.Id)
            {
                return BadRequest();
            }

            _context.Entry(diretor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DiretorExists(id))
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

        // POST: api/Diretor
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Diretor>> PostDiretor(Diretor diretor)
        {
          if (_context.Diretor == null)
          {
              return Problem("Entity set 'FilmesContext.Diretor'  is null.");
          }
            _context.Diretor.Add(diretor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDiretor", new { id = diretor.Id }, diretor);
        }

        // DELETE: api/Diretor/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiretor(int id)
        {
            if (_context.Diretor == null)
            {
                return NotFound();
            }
            var diretor = await _context.Diretor.FindAsync(id);
            if (diretor == null)
            {
                return NotFound();
            }

            _context.Diretor.Remove(diretor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DiretorExists(int id)
        {
            return (_context.Diretor?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
