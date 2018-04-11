using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CampusVirtual.Migrations
{
    public partial class UCA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsuarioCursoAsistencias",
                columns: table => new
                {
                    UsuarioCursoAsistenciaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioCursoAsistencias", x => x.UsuarioCursoAsistenciaId);
                });

            migrationBuilder.CreateTable(
                name: "Asistencias",
                columns: table => new
                {
                    AsistenciaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Asistio = table.Column<bool>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    UCAUsuarioCursoAsistenciaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencias", x => x.AsistenciaId);
                    table.ForeignKey(
                        name: "FK_Asistencias_UsuarioCursoAsistencias_UCAUsuarioCursoAsistenciaId",
                        column: x => x.UCAUsuarioCursoAsistenciaId,
                        principalTable: "UsuarioCursoAsistencias",
                        principalColumn: "UsuarioCursoAsistenciaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asistencias_UCAUsuarioCursoAsistenciaId",
                table: "Asistencias",
                column: "UCAUsuarioCursoAsistenciaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asistencias");

            migrationBuilder.DropTable(
                name: "UsuarioCursoAsistencias");
        }
    }
}
