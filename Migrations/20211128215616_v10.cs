using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto.Migrations
{
    public partial class v10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntidadServicioEmergencia",
                columns: table => new
                {
                    IdEntidadServicioEmergencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEntidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntidadServicioEmergencia", x => x.IdEntidadServicioEmergencia);
                });

            migrationBuilder.CreateTable(
                name: "AsignarEmergenciasMigrante",
                columns: table => new
                {
                    IdAsignarEmergenciasMigrante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEntidadEmergencia = table.Column<int>(type: "int", nullable: false),
                    IdEmergenciasMigrantes = table.Column<int>(type: "int", nullable: false),
                    Detalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsignarEmergenciasMigrante", x => x.IdAsignarEmergenciasMigrante);
                    table.ForeignKey(
                        name: "FK_AsignarEmergenciasMigrante_EmergenciasMigrantes_IdEmergenciasMigrantes",
                        column: x => x.IdEmergenciasMigrantes,
                        principalTable: "EmergenciasMigrantes",
                        principalColumn: "IdEmergenciasMigrantes",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AsignarEmergenciasMigrante_EntidadServicioEmergencia_IdEntidadEmergencia",
                        column: x => x.IdEntidadEmergencia,
                        principalTable: "EntidadServicioEmergencia",
                        principalColumn: "IdEntidadServicioEmergencia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsignarEmergenciasMigrante_IdEmergenciasMigrantes",
                table: "AsignarEmergenciasMigrante",
                column: "IdEmergenciasMigrantes");

            migrationBuilder.CreateIndex(
                name: "IX_AsignarEmergenciasMigrante_IdEntidadEmergencia",
                table: "AsignarEmergenciasMigrante",
                column: "IdEntidadEmergencia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsignarEmergenciasMigrante");

            migrationBuilder.DropTable(
                name: "EntidadServicioEmergencia");
        }
    }
}
