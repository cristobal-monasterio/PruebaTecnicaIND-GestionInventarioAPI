namespace GestionInventarioAPI.DTOs
{
    public class ProductoUpdateDto
    {
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }
    }
}