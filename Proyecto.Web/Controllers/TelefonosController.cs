using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto.Datos;
using Proyecto.Entidades.Telefono;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Web.Controllers
{
    public class TelefonosController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class TelefonoController : ControllerBase
        {
            private readonly DBContextSistema _context;

            public TelefonoController(DBContextSistema context)
            {
                _context = context;
            }

            //Get api/Categorias
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Telefon>>> GetTelefono()
            {
                return await _context.Telefonos.ToListAsync();
            }

            //Get api/telefono/2
            [HttpGet("{idtelefono}")]

            public async Task<ActionResult<Telefon>> GetTelefono(int id)
            {
                var Telefon = await _context.Telefonos.FindAsync(id);

                if (Telefon == null)
                {
                    return NotFound();
                }

                return Telefon;
            }

            //Put api/Telefonos/2
            [HttpPut("idtelefon")]
            public async Task<IActionResult> PutTelefono(int id, Telefon telefono)
            {
                if (id != telefono.idTelefon)
                {
                    return BadRequest();
                }

                //ENTIDAD TIENE PROPIEDADES SE VA A GUARDAR EN DB
                _context.Entry(Telefon).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TelefonoExists(id))
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
            //Post api/Telefono
            [HttpPost]
            public async Task<ActionResult<Telefon>> PostTelefono(Telefon telefonos)
            {
                _context.Categorias.Add(telefonos);
                await _context.SaveChangesAsync();

                return CreatedAtAction("Gettelefono", new { id = telefonos.idTelefon }, telefonos);
            }

            //Delete api/Telefonos/2
            [HttpDelete("idtelefon")]
            public async Task<ActionResult<Telefon>> DeleteTelefono (int id)
            {
                var telefon = await _context.Telefonos.FindAsync(id);

                if (telefon == null)
                {
                    return NotFound();
                }

                _context.Telefonos.Remove(Telefon);
                await _context.SaveChangesAsync();

                return telefon;

            }
            private bool TelefonoExists(int id)
            {
                return _context.Telefonos.Any(e => e.idTelefon == id);
            }
        }
    }
}
