using Microsoft.EntityFrameworkCore.Migrations;

namespace proyecto.Migrations
{
    public partial class v15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TipoDeUsuario",
                table: "MigranteServicioEntidad",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipoDeUsuario",
                table: "MigranteServicio",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoDeUsuario",
                table: "MigranteServicioEntidad");

            migrationBuilder.DropColumn(
                name: "TipoDeUsuario",
                table: "MigranteServicio");
        }
    }
}
