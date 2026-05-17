using System.ComponentModel.DataAnnotations;

namespace GestionInventarioAPI.DTOs
{
    public class LoginRequestDto
    {
        [Required]
        public string NombreUsuario { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}