using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barberia.API.Migrations
{
    /// <inheritdoc />
    public partial class ConeccionBarberoReseña : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BarberoReseña_Reseñas_ReseñaId",
                table: "BarberoReseña");

            migrationBuilder.AlterColumn<int>(
                name: "ReseñaId",
                table: "BarberoReseña",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BarberoCedula",
                table: "BarberoReseña",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BarberoReseña_BarberoCedula",
                table: "BarberoReseña",
                column: "BarberoCedula");

            migrationBuilder.AddForeignKey(
                name: "FK_BarberoReseña_Barberos_BarberoCedula",
                table: "BarberoReseña",
                column: "BarberoCedula",
                principalTable: "Barberos",
                principalColumn: "Cedula",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BarberoReseña_Reseñas_ReseñaId",
                table: "BarberoReseña",
                column: "ReseñaId",
                principalTable: "Reseñas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BarberoReseña_Barberos_BarberoCedula",
                table: "BarberoReseña");

            migrationBuilder.DropForeignKey(
                name: "FK_BarberoReseña_Reseñas_ReseñaId",
                table: "BarberoReseña");

            migrationBuilder.DropIndex(
                name: "IX_BarberoReseña_BarberoCedula",
                table: "BarberoReseña");

            migrationBuilder.DropColumn(
                name: "BarberoCedula",
                table: "BarberoReseña");

            migrationBuilder.AlterColumn<int>(
                name: "ReseñaId",
                table: "BarberoReseña",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BarberoReseña_Reseñas_ReseñaId",
                table: "BarberoReseña",
                column: "ReseñaId",
                principalTable: "Reseñas",
                principalColumn: "Id");
        }
    }
}
