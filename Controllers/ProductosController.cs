using GestionInventarioAPI.Data;
using GestionInventarioAPI.DTOs;
using GestionInventarioAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestionInventarioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
        {
            return await _context.Productos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> GetProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);

            if (producto == null)
                return NotFound(new
                {
                    mensaje = "Producto no encontrado."
                });

            return Ok(producto);
        }

        [HttpPost]
        public async Task<ActionResult<Producto>> CrearProducto(ProductoCreateDto dto)
        {
            var producto = new Producto
            {
                Nombre = dto.Nombre,
                Descripcion = dto.Descripcion,
                Stock = dto.Stock,
                Precio = dto.Precio,
                FechaCreacion = DateTime.Now
            };

            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProducto), new { id = producto.Id }, producto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> ActualizarProducto(int id, ProductoUpdateDto dto)
        {
            var producto = await _context.Productos.FindAsync(id);

            if (producto == null)
                return NotFound(new
                {
                    mensaje = "Producto no encontrado."
                });

            producto.Nombre = dto.Nombre;
            producto.Descripcion = dto.Descripcion;
            producto.Stock = dto.Stock;
            producto.Precio = dto.Precio;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarProducto(int id)
        {
            var producto = await _context.Productos.FindAsync(id);

            if (producto == null)
                return NotFound(new
                {
                    mensaje = "Producto no encontrado."
                });

            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}