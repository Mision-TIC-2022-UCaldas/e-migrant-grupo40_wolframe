using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto.Migrations
{
    public partial class v11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MigranteServicioEntidad",
                columns: table => new
                {
                    IdMigranteServicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdServicioEntidad = table.Column<int>(type: "int", nullable: false),
                    EstadoServicios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdMigranteNecesidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MigranteServicioEntidad", x => x.IdMigranteServicio);
                    table.ForeignKey(
                        name: "FK_MigranteServicioEntidad_MigranteNecesidad_IdMigranteNecesidad",
                        column: x => x.IdMigranteNecesidad,
                        principalTable: "MigranteNecesidad",
                        principalColumn: "IdMigranteNecesidad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MigranteServicioEntidad_servicios_IdServicioEntidad",
                        column: x => x.IdServicioEntidad,
                        principalTable: "servicios",
                        principalColumn: "IdServicioEntidad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MigranteServicioEntidad_IdMigranteNecesidad",
                table: "MigranteServicioEntidad",
                column: "IdMigranteNecesidad");

            migrationBuilder.CreateIndex(
                name: "IX_MigranteServicioEntidad_IdServicioEntidad",
                table: "MigranteServicioEntidad",
                column: "IdServicioEntidad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MigranteServicioEntidad");
        }
    }
}
