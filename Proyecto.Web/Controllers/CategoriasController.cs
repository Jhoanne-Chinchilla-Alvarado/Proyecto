using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto.Datos;
using Proyecto.Entidades.Almacen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly DBContextSistema _context;

        public CategoriasController(DBContextSistema context)
        {
            _context = context;
        }

        //Get api/Categorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategorias()
        {
            return await _context.Categorias.ToListAsync();
        }

        //Get api/Categorias/2
        [HttpGet("{idcategoria}")]

        public async Task<ActionResult<Categoria>> GetCategorias(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);

            if (categoria == null)
            {
                return NotFound();
            }

            return categoria;
        }

        //Put api/Categorias/2
        [HttpPut("idcategoria")]
        public async Task<IActionResult> PutCategoria(int id, Categoria categoria)
        {
            if (id != categoria.Idcategoria)
            {
                return BadRequest();
            }

            //ENTIDAD TIENE PROPIEDADES SE VA A GUARDAR EN DB
            _context.Entry(categoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriaExists(id))
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
        //Post api/Categorias
        [HttpPost]
        public async Task<ActionResult<Categoria>> PostCategoria(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getcategoria", new { id = categoria.Idcategoria }, categoria);
        }

        //Delete api/Categoria/2
        [HttpDelete("idcategoria")]
        public async Task<ActionResult<Categoria>> DeleteCategoria(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);

            if (categoria == null)
            {
                return NotFound();
            }

            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();

            return categoria;

        }
        private bool CategoriaExists(int id)
        {
            return _context.Categorias.Any(e => e.Idcategoria == id);
        }
    }
 }

