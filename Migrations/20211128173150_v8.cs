using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto.Migrations
{
    public partial class v8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmergenciasMigrantes",
                columns: table => new
                {
                    IdEmergenciasMigrantes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdMigrante = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergenciasMigrantes", x => x.IdEmergenciasMigrantes);
                    table.ForeignKey(
                        name: "FK_EmergenciasMigrantes_migrantes_IdMigrante",
                        column: x => x.IdMigrante,
                        principalTable: "migrantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmergenciasMigrantes_IdMigrante",
                table: "EmergenciasMigrantes",
                column: "IdMigrante");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmergenciasMigrantes");
        }
    }
}
