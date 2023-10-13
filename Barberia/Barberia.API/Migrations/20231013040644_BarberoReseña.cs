using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Barberia.API.Migrations
{
    /// <inheritdoc />
    public partial class BarberoReseña : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BarberoReseña",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReseñaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarberoReseña", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BarberoReseña_Reseñas_ReseñaId",
                        column: x => x.ReseñaId,
                        principalTable: "Reseñas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BarberoReseña_ReseñaId",
                table: "BarberoReseña",
                column: "ReseñaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BarberoReseña");
        }
    }
}
