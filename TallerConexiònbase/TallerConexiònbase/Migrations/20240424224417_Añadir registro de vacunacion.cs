using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallerConexiònbase.Migrations
{
    /// <inheritdoc />
    public partial class Añadirregistrodevacunacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    BannerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.BannerId);
                });

            migrationBuilder.CreateTable(
                name: "RecintoVacunacion",
                columns: table => new
                {
                    IdRecinto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DireccionRecinto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    paisRecintoid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecintoVacunacion", x => x.IdRecinto);
                    table.ForeignKey(
                        name: "FK_RecintoVacunacion_Pais_paisRecintoid",
                        column: x => x.paisRecintoid,
                        principalTable: "Pais",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacuna",
                columns: table => new
                {
                    IdVAcuna = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreVacuna = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Paisid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacuna", x => x.IdVAcuna);
                    table.ForeignKey(
                        name: "FK_Vacuna_Pais_Paisid",
                        column: x => x.Paisid,
                        principalTable: "Pais",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistroVacunacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstudianteBannerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    VacunaIdVAcuna = table.Column<int>(type: "int", nullable: false),
                    RecintoVacunacionIdRecinto = table.Column<int>(type: "int", nullable: false),
                    FechaVacunacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroVacunacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroVacunacion_Estudiante_EstudianteBannerId",
                        column: x => x.EstudianteBannerId,
                        principalTable: "Estudiante",
                        principalColumn: "BannerId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RegistroVacunacion_RecintoVacunacion_RecintoVacunacionIdRecinto",
                        column: x => x.RecintoVacunacionIdRecinto,
                        principalTable: "RecintoVacunacion",
                        principalColumn: "IdRecinto",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RegistroVacunacion_Vacuna_VacunaIdVAcuna",
                        column: x => x.VacunaIdVAcuna,
                        principalTable: "Vacuna",
                        principalColumn: "IdVAcuna",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecintoVacunacion_paisRecintoid",
                table: "RecintoVacunacion",
                column: "paisRecintoid");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroVacunacion_EstudianteBannerId",
                table: "RegistroVacunacion",
                column: "EstudianteBannerId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroVacunacion_RecintoVacunacionIdRecinto",
                table: "RegistroVacunacion",
                column: "RecintoVacunacionIdRecinto");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroVacunacion_VacunaIdVAcuna",
                table: "RegistroVacunacion",
                column: "VacunaIdVAcuna");

            migrationBuilder.CreateIndex(
                name: "IX_Vacuna_Paisid",
                table: "Vacuna",
                column: "Paisid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistroVacunacion");

            migrationBuilder.DropTable(
                name: "Estudiante");

            migrationBuilder.DropTable(
                name: "RecintoVacunacion");

            migrationBuilder.DropTable(
                name: "Vacuna");
        }
    }
}
