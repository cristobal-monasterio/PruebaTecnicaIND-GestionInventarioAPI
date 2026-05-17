namespace GestionInventarioAPI.DTOs
{
    public class ProductoCreateDto
    {
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }
    }
}