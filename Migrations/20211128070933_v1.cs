using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace login2.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entidad",
                columns: table => new
                {
                    IdEntidad = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaginaWeb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entidad", x => x.IdEntidad);
                });

            migrationBuilder.CreateTable(
                name: "EstadoServicioEntidad",
                columns: table => new
                {
                    IdEstadoServiciosEntidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoServiciosEntidad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoServicioEntidad", x => x.IdEstadoServiciosEntidad);
                });

            migrationBuilder.CreateTable(
                name: "EstadoServicioMigrante",
                columns: table => new
                {
                    IdEstadoServiciosMigrante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoServicios = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoServicioMigrante", x => x.IdEstadoServiciosMigrante);
                });

            migrationBuilder.CreateTable(
                name: "Migrantes",
                columns: table => new
                {
                    IdMigrante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipodocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Situacionlaboral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Migrantes", x => x.IdMigrante);
                });

            migrationBuilder.CreateTable(
                name: "Necesidad",
                columns: table => new
                {
                    IdNecesidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NecesidadMigrante = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Necesidad", x => x.IdNecesidad);
                });

            migrationBuilder.CreateTable(
                name: "Novedades",
                columns: table => new
                {
                    IdNovedades = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroDias = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novedades", x => x.IdNovedades);
                });

            migrationBuilder.CreateTable(
                name: "Prioridad",
                columns: table => new
                {
                    IdPrioridad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrioridadNecesidad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prioridad", x => x.IdPrioridad);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    IdServicios = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiciosPrestados = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.IdServicios);
                });

            migrationBuilder.CreateTable(
                name: "TipoCalificacionMigrante",
                columns: table => new
                {
                    IdTipoCalificacionMigrante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoCalificacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCalificacionMigrante", x => x.IdTipoCalificacionMigrante);
                });

            migrationBuilder.CreateTable(
                name: "TipoCalificacionServicio",
                columns: table => new
                {
                    IdTipoCalificacionServicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoCalificacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCalificacionServicio", x => x.IdTipoCalificacionServicio);
                });

            migrationBuilder.CreateTable(
                name: "TipoEmergencia",
                columns: table => new
                {
                    IdTipoEmergencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emergencia = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEmergencia", x => x.IdTipoEmergencia);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AmigosFamiliares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipodocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Situacionlaboral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoAfinidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdMigrantes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmigosFamiliares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AmigosFamiliares_Migrantes_IdMigrantes",
                        column: x => x.IdMigrantes,
                        principalTable: "Migrantes",
                        principalColumn: "IdMigrante",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MigranteNecesidad",
                columns: table => new
                {
                    IdMigranteNecesidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detalle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNecesidad = table.Column<int>(type: "int", nullable: false),
                    IdMigrante = table.Column<int>(type: "int", nullable: false),
                    IdPrioridad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MigranteNecesidad", x => x.IdMigranteNecesidad);
                    table.ForeignKey(
                        name: "FK_MigranteNecesidad_Migrantes_IdMigrante",
                        column: x => x.IdMigrante,
                        principalTable: "Migrantes",
                        principalColumn: "IdMigrante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MigranteNecesidad_Necesidad_IdNecesidad",
                        column: x => x.IdNecesidad,
                        principalTable: "Necesidad",
                        principalColumn: "IdNecesidad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MigranteNecesidad_Prioridad_IdPrioridad",
                        column: x => x.IdPrioridad,
                        principalTable: "Prioridad",
                        principalColumn: "IdPrioridad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServicioEntidad",
                columns: table => new
                {
                    IdServicioEntidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreServicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroPersonas = table.Column<int>(type: "int", nullable: false),
                    FechaInico = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEstadoServiciosEntidad = table.Column<int>(type: "int", nullable: false),
                    IdServico = table.Column<int>(type: "int", nullable: false),
                    IdEntidad = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdServicios = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicioEntidad", x => x.IdServicioEntidad);
                    table.ForeignKey(
                        name: "FK_ServicioEntidad_Entidad_IdEntidad",
                        column: x => x.IdEntidad,
                        principalTable: "Entidad",
                        principalColumn: "IdEntidad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicioEntidad_EstadoServicioEntidad_IdEstadoServiciosEntidad",
                        column: x => x.IdEstadoServiciosEntidad,
                        principalTable: "EstadoServicioEntidad",
                        principalColumn: "IdEstadoServiciosEntidad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicioEntidad_Servicios_IdServicios",
                        column: x => x.IdServicios,
                        principalTable: "Servicios",
                        principalColumn: "IdServicios",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServicioNecesidad",
                columns: table => new
                {
                    IdServiciosNecesidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdServicios = table.Column<int>(type: "int", nullable: false),
                    IdNecesidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicioNecesidad", x => x.IdServiciosNecesidad);
                    table.ForeignKey(
                        name: "FK_ServicioNecesidad_Necesidad_IdNecesidad",
                        column: x => x.IdNecesidad,
                        principalTable: "Necesidad",
                        principalColumn: "IdNecesidad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicioNecesidad_Servicios_IdServicios",
                        column: x => x.IdServicios,
                        principalTable: "Servicios",
                        principalColumn: "IdServicios",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CalificacionMigrante",
                columns: table => new
                {
                    IdCalificacionMigrante = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTipoCalificaionMigrante = table.Column<int>(type: "int", nullable: false),
                    IdEntidad = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdMigrante = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalificacionMigrante", x => x.IdCalificacionMigrante);
                    table.ForeignKey(
                        name: "FK_CalificacionMigrante_Entidad_IdEntidad",
                        column: x => x.IdEntidad,
                        principalTable: "Entidad",
                        principalColumn: "IdEntidad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalificacionMigrante_Migrantes_IdMigrante",
                        column: x => x.IdMigrante,
                        principalTable: "Migrantes",
                        principalColumn: "IdMigrante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CalificacionMigrante_TipoCalificacionMigrante_IdTipoCalificaionMigrante",
                        column: x => x.IdTipoCalificaionMigrante,
                        principalTable: "TipoCalificacionMigrante",
                        principalColumn: "IdTipoCalificacionMigrante",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmergenciaMigrantes",
                columns: table => new
                {
                    IdEmergenciaMigrantes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdMigrante = table.Column<int>(type: "int", nullable: false),
                    IdTipoEmergencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmergenciaMigrantes", x => x.IdEmergenciaMigrantes);
                    table.ForeignKey(
                        name: "FK_EmergenciaMigrantes_Migrantes_IdMigrante",
                        column: x => x.IdMigrante,
                        principalTable: "Migrantes",
                        principalColumn: "IdMigrante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmergenciaMigrantes_TipoEmergencia_IdTipoEmergencia",
                        column: x => x.IdTipoEmergencia,
                        principalTable: "TipoEmergencia",
                        principalColumn: "IdTipoEmergencia",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MigrantesServicio",
                columns: table => new
                {
                    IdMigrantesServicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdServicioEntidad = table.Column<int>(type: "int", nullable: false),
                    IdEstadoServiciosMigrante = table.Column<int>(type: "int", nullable: false),
                    IdMigrantes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MigrantesServicio", x => x.IdMigrantesServicio);
                    table.ForeignKey(
                        name: "FK_MigrantesServicio_EstadoServicioMigrante_IdEstadoServiciosMigrante",
                        column: x => x.IdEstadoServiciosMigrante,
                        principalTable: "EstadoServicioMigrante",
                        principalColumn: "IdEstadoServiciosMigrante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MigrantesServicio_Migrantes_IdMigrantes",
                        column: x => x.IdMigrantes,
                        principalTable: "Migrantes",
                        principalColumn: "IdMigrante",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MigrantesServicio_ServicioEntidad_IdServicioEntidad",
                        column: x => x.IdServicioEntidad,
                        principalTable: "ServicioEntidad",
                        principalColumn: "IdServicioEntidad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CalificacionServicios",
                columns: table => new
                {
                    IdCalificacionServicios = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdMigrarServicios = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalificacionServicios", x => x.IdCalificacionServicios);
                    table.ForeignKey(
                        name: "FK_CalificacionServicios_MigrantesServicio_IdMigrarServicios",
                        column: x => x.IdMigrarServicios,
                        principalTable: "MigrantesServicio",
                        principalColumn: "IdMigrantesServicio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmigosFamiliares_IdMigrantes",
                table: "AmigosFamiliares",
                column: "IdMigrantes");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CalificacionMigrante_IdEntidad",
                table: "CalificacionMigrante",
                column: "IdEntidad");

            migrationBuilder.CreateIndex(
                name: "IX_CalificacionMigrante_IdMigrante",
                table: "CalificacionMigrante",
                column: "IdMigrante");

            migrationBuilder.CreateIndex(
                name: "IX_CalificacionMigrante_IdTipoCalificaionMigrante",
                table: "CalificacionMigrante",
                column: "IdTipoCalificaionMigrante");

            migrationBuilder.CreateIndex(
                name: "IX_CalificacionServicios_IdMigrarServicios",
                table: "CalificacionServicios",
                column: "IdMigrarServicios");

            migrationBuilder.CreateIndex(
                name: "IX_EmergenciaMigrantes_IdMigrante",
                table: "EmergenciaMigrantes",
                column: "IdMigrante");

            migrationBuilder.CreateIndex(
                name: "IX_EmergenciaMigrantes_IdTipoEmergencia",
                table: "EmergenciaMigrantes",
                column: "IdTipoEmergencia");

            migrationBuilder.CreateIndex(
                name: "IX_MigranteNecesidad_IdMigrante",
                table: "MigranteNecesidad",
                column: "IdMigrante");

            migrationBuilder.CreateIndex(
                name: "IX_MigranteNecesidad_IdNecesidad",
                table: "MigranteNecesidad",
                column: "IdNecesidad");

            migrationBuilder.CreateIndex(
                name: "IX_MigranteNecesidad_IdPrioridad",
                table: "MigranteNecesidad",
                column: "IdPrioridad");

            migrationBuilder.CreateIndex(
                name: "IX_MigrantesServicio_IdEstadoServiciosMigrante",
                table: "MigrantesServicio",
                column: "IdEstadoServiciosMigrante");

            migrationBuilder.CreateIndex(
                name: "IX_MigrantesServicio_IdMigrantes",
                table: "MigrantesServicio",
                column: "IdMigrantes");

            migrationBuilder.CreateIndex(
                name: "IX_MigrantesServicio_IdServicioEntidad",
                table: "MigrantesServicio",
                column: "IdServicioEntidad");

            migrationBuilder.CreateIndex(
                name: "IX_ServicioEntidad_IdEntidad",
                table: "ServicioEntidad",
                column: "IdEntidad");

            migrationBuilder.CreateIndex(
                name: "IX_ServicioEntidad_IdEstadoServiciosEntidad",
                table: "ServicioEntidad",
                column: "IdEstadoServiciosEntidad");

            migrationBuilder.CreateIndex(
                name: "IX_ServicioEntidad_IdServicios",
                table: "ServicioEntidad",
                column: "IdServicios");

            migrationBuilder.CreateIndex(
                name: "IX_ServicioNecesidad_IdNecesidad",
                table: "ServicioNecesidad",
                column: "IdNecesidad");

            migrationBuilder.CreateIndex(
                name: "IX_ServicioNecesidad_IdServicios",
                table: "ServicioNecesidad",
                column: "IdServicios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmigosFamiliares");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CalificacionMigrante");

            migrationBuilder.DropTable(
                name: "CalificacionServicios");

            migrationBuilder.DropTable(
                name: "EmergenciaMigrantes");

            migrationBuilder.DropTable(
                name: "MigranteNecesidad");

            migrationBuilder.DropTable(
                name: "Novedades");

            migrationBuilder.DropTable(
                name: "ServicioNecesidad");

            migrationBuilder.DropTable(
                name: "TipoCalificacionServicio");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TipoCalificacionMigrante");

            migrationBuilder.DropTable(
                name: "MigrantesServicio");

            migrationBuilder.DropTable(
                name: "TipoEmergencia");

            migrationBuilder.DropTable(
                name: "Prioridad");

            migrationBuilder.DropTable(
                name: "Necesidad");

            migrationBuilder.DropTable(
                name: "EstadoServicioMigrante");

            migrationBuilder.DropTable(
                name: "Migrantes");

            migrationBuilder.DropTable(
                name: "ServicioEntidad");

            migrationBuilder.DropTable(
                name: "Entidad");

            migrationBuilder.DropTable(
                name: "EstadoServicioEntidad");

            migrationBuilder.DropTable(
                name: "Servicios");
        }
    }
}
