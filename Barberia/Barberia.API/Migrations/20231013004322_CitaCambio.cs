using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barberia.API.Migrations
{
    /// <inheritdoc />
    public partial class CitaCambio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Citas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Citas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Citas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
