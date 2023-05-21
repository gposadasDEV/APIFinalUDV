﻿// <auto-generated />
using System;
using APIFinalUDV.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIFinalUDV.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.4.23259.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIFinalUDV.Models.Asignacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<int>("CodigoCurso")
                        .HasColumnType("int");

                    b.Property<int>("Estudiante")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRealizacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Seccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Semestre")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Asignacion");
                });

            modelBuilder.Entity("APIFinalUDV.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CodigoCurso")
                        .HasColumnType("int");

                    b.Property<int>("CreditosOtorgados")
                        .HasColumnType("int");

                    b.Property<string>("NombreCurso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Semestre")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("APIFinalUDV.Models.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Carnet")
                        .HasColumnType("int");

                    b.Property<string>("Carrera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreEstudiante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Estudiante");
                });
#pragma warning restore 612, 618
        }
    }
}
