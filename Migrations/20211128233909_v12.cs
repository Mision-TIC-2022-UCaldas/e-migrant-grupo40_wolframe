using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto.Migrations
{
    public partial class v12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MigranteServicio",
                columns: table => new
                {
                    IdMigranteServicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdServicioEntidad = table.Column<int>(type: "int", nullable: false),
                    EstadoServicios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdMigrantes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MigranteServicio", x => x.IdMigranteServicio);
                    table.ForeignKey(
                        name: "FK_MigranteServicio_migrantes_IdMigrantes",
                        column: x => x.IdMigrantes,
                        principalTable: "migrantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MigranteServicio_servicios_IdServicioEntidad",
                        column: x => x.IdServicioEntidad,
                        principalTable: "servicios",
                        principalColumn: "IdServicioEntidad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MigranteServicio_IdMigrantes",
                table: "MigranteServicio",
                column: "IdMigrantes");

            migrationBuilder.CreateIndex(
                name: "IX_MigranteServicio_IdServicioEntidad",
                table: "MigranteServicio",
                column: "IdServicioEntidad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MigranteServicio");
        }
    }
}
