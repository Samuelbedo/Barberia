using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barberia.API.Migrations
{
    /// <inheritdoc />
    public partial class PruebaPrimaryKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BarberoReseña_Barberos_BarberoCedula",
                table: "BarberoReseña");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Barberos_BarberoCedula",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Clientes_ClienteCedula",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturaciones_Clientes_ClienteCedula",
                table: "Facturaciones");

            migrationBuilder.RenameColumn(
                name: "ClienteCedula",
                table: "Facturaciones",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturaciones_ClienteCedula",
                table: "Facturaciones",
                newName: "IX_Facturaciones_ClienteId");

            migrationBuilder.RenameColumn(
                name: "Cedula",
                table: "Clientes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClienteCedula",
                table: "Citas",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "BarberoCedula",
                table: "Citas",
                newName: "BarberoId");

            migrationBuilder.RenameIndex(
                name: "IX_Citas_ClienteCedula",
                table: "Citas",
                newName: "IX_Citas_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Citas_BarberoCedula",
                table: "Citas",
                newName: "IX_Citas_BarberoId");

            migrationBuilder.RenameColumn(
                name: "Cedula",
                table: "Barberos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BarberoCedula",
                table: "BarberoReseña",
                newName: "BarberoId");

            migrationBuilder.RenameIndex(
                name: "IX_BarberoReseña_BarberoCedula",
                table: "BarberoReseña",
                newName: "IX_BarberoReseña_BarberoId");

            migrationBuilder.AlterColumn<string>(
                name: "Fecha",
                table: "Facturaciones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Especialidad",
                table: "Barberos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_BarberoReseña_Barberos_BarberoId",
                table: "BarberoReseña",
                column: "BarberoId",
                principalTable: "Barberos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BarberoReseña_Barberos_BarberoId",
                table: "BarberoReseña");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Barberos_BarberoId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Clientes_ClienteId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturaciones_Clientes_ClienteId",
                table: "Facturaciones");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Facturaciones",
                newName: "ClienteCedula");

            migrationBuilder.RenameIndex(
                name: "IX_Facturaciones_ClienteId",
                table: "Facturaciones",
                newName: "IX_Facturaciones_ClienteCedula");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clientes",
                newName: "Cedula");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Citas",
                newName: "ClienteCedula");

            migrationBuilder.RenameColumn(
                name: "BarberoId",
                table: "Citas",
                newName: "BarberoCedula");

            migrationBuilder.RenameIndex(
                name: "IX_Citas_ClienteId",
                table: "Citas",
                newName: "IX_Citas_ClienteCedula");

            migrationBuilder.RenameIndex(
                name: "IX_Citas_BarberoId",
                table: "Citas",
                newName: "IX_Citas_BarberoCedula");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Barberos",
                newName: "Cedula");

            migrationBuilder.RenameColumn(
                name: "BarberoId",
                table: "BarberoReseña",
                newName: "BarberoCedula");

            migrationBuilder.RenameIndex(
                name: "IX_BarberoReseña_BarberoId",
                table: "BarberoReseña",
                newName: "IX_BarberoReseña_BarberoCedula");

            migrationBuilder.AlterColumn<string>(
                name: "Fecha",
                table: "Facturaciones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Especialidad",
                table: "Barberos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BarberoReseña_Barberos_BarberoCedula",
                table: "BarberoReseña",
                column: "BarberoCedula",
                principalTable: "Barberos",
                principalColumn: "Cedula",
                onDelete: ReferentialAction.Cascade);

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
        }
    }
}
