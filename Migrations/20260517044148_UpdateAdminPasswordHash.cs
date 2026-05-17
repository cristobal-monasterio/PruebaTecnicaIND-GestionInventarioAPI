using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionInventarioAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAdminPasswordHash : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$4nI00VwxKdn01D5rY4gd.eveu/eGL9iba2Sq2ifehn6/Ki8EFXKRm");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordHash",
                value: "$2a$11$7m6A1Y6K8M7uL6Qw5hM3uuhM6M0dJ5qP2y3H6Z9jS7rN8uD3Y0Q5K");
        }
    }
}
