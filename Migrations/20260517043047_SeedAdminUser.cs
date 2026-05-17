using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionInventarioAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "NombreUsuario", "PasswordHash", "Rol" },
                values: new object[] { 1, "admin", "$2a$11$7m6A1Y6K8M7uL6Qw5hM3uuhM6M0dJ5qP2y3H6Z9jS7rN8uD3Y0Q5K", "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
