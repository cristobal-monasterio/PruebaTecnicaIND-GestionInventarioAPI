using System.ComponentModel.DataAnnotations;

namespace GestionInventarioAPI.DTOs
{
    public class ProductoCreateDto
    {
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [StringLength(255)]
        public string? Descripcion { get; set; }

        [Range(0, int.MaxValue)]
        public int Stock { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal Precio { get; set; }
    }
}