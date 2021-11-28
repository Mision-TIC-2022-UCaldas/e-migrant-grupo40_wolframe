﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using login2.Data;

namespace login2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211128070933_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("login2.Models.AmigosFamiliares", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMigrantes")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Situacionlaboral")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoAfinidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipodocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdMigrantes");

                    b.ToTable("AmigosFamiliares");
                });

            modelBuilder.Entity("login2.Models.CalificacionMigrante", b =>
                {
                    b.Property<int>("IdCalificacionMigrante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdEntidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IdMigrante")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoCalificaionMigrante")
                        .HasColumnType("int");

                    b.HasKey("IdCalificacionMigrante");

                    b.HasIndex("IdEntidad");

                    b.HasIndex("IdMigrante");

                    b.HasIndex("IdTipoCalificaionMigrante");

                    b.ToTable("CalificacionMigrante");
                });

            modelBuilder.Entity("login2.Models.CalificacionServicios", b =>
                {
                    b.Property<int>("IdCalificacionServicios")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Calificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMigrarServicios")
                        .HasColumnType("int");

                    b.HasKey("IdCalificacionServicios");

                    b.HasIndex("IdMigrarServicios");

                    b.ToTable("CalificacionServicios");
                });

            modelBuilder.Entity("login2.Models.EmergenciaMigrantes", b =>
                {
                    b.Property<int>("IdEmergenciaMigrantes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMigrante")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoEmergencia")
                        .HasColumnType("int");

                    b.HasKey("IdEmergenciaMigrantes");

                    b.HasIndex("IdMigrante");

                    b.HasIndex("IdTipoEmergencia");

                    b.ToTable("EmergenciaMigrantes");
                });

            modelBuilder.Entity("login2.Models.Entidad", b =>
                {
                    b.Property<string>("IdEntidad")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaginaWeb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEntidad");

                    b.ToTable("Entidad");
                });

            modelBuilder.Entity("login2.Models.EstadoServicioEntidad", b =>
                {
                    b.Property<int>("IdEstadoServiciosEntidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EstadoServiciosEntidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEstadoServiciosEntidad");

                    b.ToTable("EstadoServicioEntidad");
                });

            modelBuilder.Entity("login2.Models.EstadoServicioMigrante", b =>
                {
                    b.Property<int>("IdEstadoServiciosMigrante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EstadoServicios")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEstadoServiciosMigrante");

                    b.ToTable("EstadoServicioMigrante");
                });

            modelBuilder.Entity("login2.Models.MigranteNecesidad", b =>
                {
                    b.Property<int>("IdMigranteNecesidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdMigrante")
                        .HasColumnType("int");

                    b.Property<int>("IdNecesidad")
                        .HasColumnType("int");

                    b.Property<int>("IdPrioridad")
                        .HasColumnType("int");

                    b.HasKey("IdMigranteNecesidad");

                    b.HasIndex("IdMigrante");

                    b.HasIndex("IdNecesidad");

                    b.HasIndex("IdPrioridad");

                    b.ToTable("MigranteNecesidad");
                });

            modelBuilder.Entity("login2.Models.Migrantes", b =>
                {
                    b.Property<int>("IdMigrante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroDocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Situacionlaboral")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipodocumento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMigrante");

                    b.ToTable("Migrantes");
                });

            modelBuilder.Entity("login2.Models.MigrantesServicio", b =>
                {
                    b.Property<int>("IdMigrantesServicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdEstadoServiciosMigrante")
                        .HasColumnType("int");

                    b.Property<int>("IdMigrantes")
                        .HasColumnType("int");

                    b.Property<int>("IdServicioEntidad")
                        .HasColumnType("int");

                    b.HasKey("IdMigrantesServicio");

                    b.HasIndex("IdEstadoServiciosMigrante");

                    b.HasIndex("IdMigrantes");

                    b.HasIndex("IdServicioEntidad");

                    b.ToTable("MigrantesServicio");
                });

            modelBuilder.Entity("login2.Models.Necesidad", b =>
                {
                    b.Property<int>("IdNecesidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NecesidadMigrante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdNecesidad");

                    b.ToTable("Necesidad");
                });

            modelBuilder.Entity("login2.Models.Novedades", b =>
                {
                    b.Property<int>("IdNovedades")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumeroDias")
                        .HasColumnType("int");

                    b.HasKey("IdNovedades");

                    b.ToTable("Novedades");
                });

            modelBuilder.Entity("login2.Models.Prioridad", b =>
                {
                    b.Property<int>("IdPrioridad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PrioridadNecesidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPrioridad");

                    b.ToTable("Prioridad");
                });

            modelBuilder.Entity("login2.Models.ServicioEntidad", b =>
                {
                    b.Property<int>("IdServicioEntidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInico")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdEntidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IdEstadoServiciosEntidad")
                        .HasColumnType("int");

                    b.Property<int?>("IdServicios")
                        .HasColumnType("int");

                    b.Property<int>("IdServico")
                        .HasColumnType("int");

                    b.Property<string>("NombreServicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroPersonas")
                        .HasColumnType("int");

                    b.HasKey("IdServicioEntidad");

                    b.HasIndex("IdEntidad");

                    b.HasIndex("IdEstadoServiciosEntidad");

                    b.HasIndex("IdServicios");

                    b.ToTable("ServicioEntidad");
                });

            modelBuilder.Entity("login2.Models.ServicioNecesidad", b =>
                {
                    b.Property<int>("IdServiciosNecesidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdNecesidad")
                        .HasColumnType("int");

                    b.Property<int>("IdServicios")
                        .HasColumnType("int");

                    b.HasKey("IdServiciosNecesidad");

                    b.HasIndex("IdNecesidad");

                    b.HasIndex("IdServicios");

                    b.ToTable("ServicioNecesidad");
                });

            modelBuilder.Entity("login2.Models.Servicios", b =>
                {
                    b.Property<int>("IdServicios")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServiciosPrestados")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdServicios");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("login2.Models.TipoCalificacionMigrante", b =>
                {
                    b.Property<int>("IdTipoCalificacionMigrante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipoCalificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoCalificacionMigrante");

                    b.ToTable("TipoCalificacionMigrante");
                });

            modelBuilder.Entity("login2.Models.TipoCalificacionServicio", b =>
                {
                    b.Property<int>("IdTipoCalificacionServicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipoCalificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoCalificacionServicio");

                    b.ToTable("TipoCalificacionServicio");
                });

            modelBuilder.Entity("login2.Models.TipoEmergencia", b =>
                {
                    b.Property<int>("IdTipoEmergencia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Emergencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoEmergencia");

                    b.ToTable("TipoEmergencia");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("login2.Models.AmigosFamiliares", b =>
                {
                    b.HasOne("login2.Models.Migrantes", "Migrantes")
                        .WithMany()
                        .HasForeignKey("IdMigrantes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Migrantes");
                });

            modelBuilder.Entity("login2.Models.CalificacionMigrante", b =>
                {
                    b.HasOne("login2.Models.Entidad", "Entidad")
                        .WithMany()
                        .HasForeignKey("IdEntidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("login2.Models.Migrantes", "Migrantes")
                        .WithMany()
                        .HasForeignKey("IdMigrante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("login2.Models.TipoCalificacionMigrante", "TipoCalificacionMigrante")
                        .WithMany()
                        .HasForeignKey("IdTipoCalificaionMigrante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entidad");

                    b.Navigation("Migrantes");

                    b.Navigation("TipoCalificacionMigrante");
                });

            modelBuilder.Entity("login2.Models.CalificacionServicios", b =>
                {
                    b.HasOne("login2.Models.MigrantesServicio", "MigrantesServicio")
                        .WithMany()
                        .HasForeignKey("IdMigrarServicios")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MigrantesServicio");
                });

            modelBuilder.Entity("login2.Models.EmergenciaMigrantes", b =>
                {
                    b.HasOne("login2.Models.Migrantes", "Migrantes")
                        .WithMany()
                        .HasForeignKey("IdMigrante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("login2.Models.TipoEmergencia", "TipoEmergencia")
                        .WithMany()
                        .HasForeignKey("IdTipoEmergencia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Migrantes");

                    b.Navigation("TipoEmergencia");
                });

            modelBuilder.Entity("login2.Models.MigranteNecesidad", b =>
                {
                    b.HasOne("login2.Models.Migrantes", "migrantes")
                        .WithMany()
                        .HasForeignKey("IdMigrante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("login2.Models.Necesidad", "Necesidad")
                        .WithMany()
                        .HasForeignKey("IdNecesidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("login2.Models.Prioridad", "prioridad")
                        .WithMany()
                        .HasForeignKey("IdPrioridad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("migrantes");

                    b.Navigation("Necesidad");

                    b.Navigation("prioridad");
                });

            modelBuilder.Entity("login2.Models.MigrantesServicio", b =>
                {
                    b.HasOne("login2.Models.EstadoServicioMigrante", "EstadoServicioMigrante")
                        .WithMany()
                        .HasForeignKey("IdEstadoServiciosMigrante")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("login2.Models.Migrantes", "Migrantes")
                        .WithMany()
                        .HasForeignKey("IdMigrantes")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("login2.Models.ServicioEntidad", "ServicioEntidad")
                        .WithMany()
                        .HasForeignKey("IdServicioEntidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoServicioMigrante");

                    b.Navigation("Migrantes");

                    b.Navigation("ServicioEntidad");
                });

            modelBuilder.Entity("login2.Models.ServicioEntidad", b =>
                {
                    b.HasOne("login2.Models.Entidad", "Entidad")
                        .WithMany()
                        .HasForeignKey("IdEntidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("login2.Models.EstadoServicioEntidad", "EstadoServicoEntidad")
                        .WithMany()
                        .HasForeignKey("IdEstadoServiciosEntidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("login2.Models.Servicios", "servicios")
                        .WithMany()
                        .HasForeignKey("IdServicios");

                    b.Navigation("Entidad");

                    b.Navigation("EstadoServicoEntidad");

                    b.Navigation("servicios");
                });

            modelBuilder.Entity("login2.Models.ServicioNecesidad", b =>
                {
                    b.HasOne("login2.Models.Necesidad", "Necesidad")
                        .WithMany()
                        .HasForeignKey("IdNecesidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("login2.Models.Servicios", "Servicios")
                        .WithMany()
                        .HasForeignKey("IdServicios")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Necesidad");

                    b.Navigation("Servicios");
                });
#pragma warning restore 612, 618
        }
    }
}
