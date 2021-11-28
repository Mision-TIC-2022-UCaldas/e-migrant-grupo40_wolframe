﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using proyecto.Data;

namespace proyecto.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211128133139_v4")]
    partial class v4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("proyecto.Models.Entidad", b =>
                {
                    b.Property<string>("Nit")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
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

                    b.HasKey("Nit");

                    b.ToTable("Entidad");
                });

            modelBuilder.Entity("proyecto.Models.FamiliaAmigos", b =>
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

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMigrantes")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
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

                    b.Property<string>("Tipodoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("migrantesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("migrantesId");

                    b.ToTable("FamiliaAmigos");
                });

            modelBuilder.Entity("proyecto.Models.calificarapp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("calificacion")
                        .HasColumnType("int");

                    b.Property<string>("comentarios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("calificarapp");
                });

            modelBuilder.Entity("proyecto.Models.migrantes", b =>
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

                    b.Property<string>("Contrasena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Situacionlaboral")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipodoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("migrantes");
                });

            modelBuilder.Entity("proyecto.Models.servicios", b =>
                {
                    b.Property<int>("IdServicioEntidad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInico")
                        .HasColumnType("datetime2");

                    b.Property<string>("NitEntidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NombreServicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroPersonas")
                        .HasColumnType("int");

                    b.HasKey("IdServicioEntidad");

                    b.HasIndex("NitEntidad");

                    b.ToTable("servicios");
                });

            modelBuilder.Entity("proyecto.Models.FamiliaAmigos", b =>
                {
                    b.HasOne("proyecto.Models.migrantes", "migrantes")
                        .WithMany()
                        .HasForeignKey("migrantesId");

                    b.Navigation("migrantes");
                });

            modelBuilder.Entity("proyecto.Models.servicios", b =>
                {
                    b.HasOne("proyecto.Models.Entidad", "Entidad")
                        .WithMany()
                        .HasForeignKey("NitEntidad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entidad");
                });
#pragma warning restore 612, 618
        }
    }
}
