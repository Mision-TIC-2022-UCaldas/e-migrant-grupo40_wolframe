using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MigranteNecesidad",
                columns: table => new
                {
                    IdMigranteNecesidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Necesidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdMigrante = table.Column<int>(type: "int", nullable: false),
                    Prioridad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detalle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MigranteNecesidad", x => x.IdMigranteNecesidad);
                    table.ForeignKey(
                        name: "FK_MigranteNecesidad_migrantes_IdMigrante",
                        column: x => x.IdMigrante,
                        principalTable: "migrantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MigranteNecesidad_IdMigrante",
                table: "MigranteNecesidad",
                column: "IdMigrante");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MigranteNecesidad");
        }
    }
}
