using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FamiliaAmigos_migrantes_MigrantesId",
                table: "FamiliaAmigos");

            migrationBuilder.RenameColumn(
                name: "MigrantesId",
                table: "FamiliaAmigos",
                newName: "migrantesId");

            migrationBuilder.RenameIndex(
                name: "IX_FamiliaAmigos_MigrantesId",
                table: "FamiliaAmigos",
                newName: "IX_FamiliaAmigos_migrantesId");

            migrationBuilder.CreateTable(
                name: "calificarapp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    calificacion = table.Column<int>(type: "int", nullable: false),
                    comentarios = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_calificarapp", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_FamiliaAmigos_migrantes_migrantesId",
                table: "FamiliaAmigos",
                column: "migrantesId",
                principalTable: "migrantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FamiliaAmigos_migrantes_migrantesId",
                table: "FamiliaAmigos");

            migrationBuilder.DropTable(
                name: "calificarapp");

            migrationBuilder.RenameColumn(
                name: "migrantesId",
                table: "FamiliaAmigos",
                newName: "MigrantesId");

            migrationBuilder.RenameIndex(
                name: "IX_FamiliaAmigos_migrantesId",
                table: "FamiliaAmigos",
                newName: "IX_FamiliaAmigos_MigrantesId");

            migrationBuilder.AddForeignKey(
                name: "FK_FamiliaAmigos_migrantes_MigrantesId",
                table: "FamiliaAmigos",
                column: "MigrantesId",
                principalTable: "migrantes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
