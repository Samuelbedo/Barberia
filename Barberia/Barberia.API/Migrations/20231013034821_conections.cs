using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barberia.API.Migrations
{
    /// <inheritdoc />
    public partial class conections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CitaId",
                table: "Servicios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteCedula",
                table: "Facturaciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BarberoCedula",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteCedula",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_CitaId",
                table: "Servicios",
                column: "CitaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Facturaciones_ClienteCedula",
                table: "Facturaciones",
                column: "ClienteCedula",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Citas_BarberoCedula",
                table: "Citas",
                column: "BarberoCedula");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_ClienteCedula",
                table: "Citas",
                column: "ClienteCedula");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Barberos_BarberoCedula",
                table: "Citas",
                column: "BarberoCedula",
                principalTable: "Barberos",
                principalColumn: "Cedula",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Clientes_ClienteCedula",
                table: "Citas",
                column: "ClienteCedula",
                principalTable: "Clientes",
                principalColumn: "Cedula",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturaciones_Clientes_ClienteCedula",
                table: "Facturaciones",
                column: "ClienteCedula",
                principalTable: "Clientes",
                principalColumn: "Cedula",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Citas_CitaId",
                table: "Servicios",
                column: "CitaId",
                principalTable: "Citas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Barberos_BarberoCedula",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Clientes_ClienteCedula",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturaciones_Clientes_ClienteCedula",
                table: "Facturaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Citas_CitaId",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_CitaId",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Facturaciones_ClienteCedula",
                table: "Facturaciones");

            migrationBuilder.DropIndex(
                name: "IX_Citas_BarberoCedula",
                table: "Citas");

            migrationBuilder.DropIndex(
                name: "IX_Citas_ClienteCedula",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "CitaId",
                table: "Servicios");

            migrationBuilder.DropColumn(
                name: "ClienteCedula",
                table: "Facturaciones");

            migrationBuilder.DropColumn(
                name: "BarberoCedula",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "ClienteCedula",
                table: "Citas");
        }
    }
}
