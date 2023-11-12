using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barberia.API.Migrations
{
    /// <inheritdoc />
    public partial class NulleablesFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Barberos_BarberoId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Clientes_ClienteId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturaciones_Clientes_ClienteId",
                table: "Facturaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Citas_CitaId",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_CitaId",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Facturaciones_ClienteId",
                table: "Facturaciones");

            migrationBuilder.AlterColumn<int>(
                name: "CitaId",
                table: "Servicios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Facturaciones",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Citas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BarberoId",
                table: "Citas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_CitaId",
                table: "Servicios",
                column: "CitaId",
                unique: true,
                filter: "[CitaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Facturaciones_ClienteId",
                table: "Facturaciones",
                column: "ClienteId",
                unique: true,
                filter: "[ClienteId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Barberos_BarberoId",
                table: "Citas",
                column: "BarberoId",
                principalTable: "Barberos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Clientes_ClienteId",
                table: "Citas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturaciones_Clientes_ClienteId",
                table: "Facturaciones",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Citas_CitaId",
                table: "Servicios",
                column: "CitaId",
                principalTable: "Citas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Barberos_BarberoId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Clientes_ClienteId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturaciones_Clientes_ClienteId",
                table: "Facturaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicios_Citas_CitaId",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Servicios_CitaId",
                table: "Servicios");

            migrationBuilder.DropIndex(
                name: "IX_Facturaciones_ClienteId",
                table: "Facturaciones");

            migrationBuilder.AlterColumn<int>(
                name: "CitaId",
                table: "Servicios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Facturaciones",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BarberoId",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_CitaId",
                table: "Servicios",
                column: "CitaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Facturaciones_ClienteId",
                table: "Facturaciones",
                column: "ClienteId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Barberos_BarberoId",
                table: "Citas",
                column: "BarberoId",
                principalTable: "Barberos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Clientes_ClienteId",
                table: "Citas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturaciones_Clientes_ClienteId",
                table: "Facturaciones",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicios_Citas_CitaId",
                table: "Servicios",
                column: "CitaId",
                principalTable: "Citas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
