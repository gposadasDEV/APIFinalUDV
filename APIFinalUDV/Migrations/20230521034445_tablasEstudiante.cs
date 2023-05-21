using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIFinalUDV.Migrations
{
    /// <inheritdoc />
    public partial class tablasEstudiante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asignacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoCurso = table.Column<int>(type: "int", nullable: false),
                    Seccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estudiante = table.Column<int>(type: "int", nullable: false),
                    FechaRealizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Semestre = table.Column<int>(type: "int", nullable: false),
                    Anio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asignacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoCurso = table.Column<int>(type: "int", nullable: false),
                    NombreCurso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Semestre = table.Column<int>(type: "int", nullable: false),
                    CreditosOtorgados = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asignacion");

            migrationBuilder.DropTable(
                name: "Curso");
        }
    }
}
