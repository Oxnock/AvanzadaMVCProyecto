using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CampusVirtual.Migrations
{
    public partial class UsuarioCurso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencias_UsuarioCursoAsistencias_UCAUsuarioCursoAsistenciaId",
                table: "Asistencias");

            migrationBuilder.RenameColumn(
                name: "UCAUsuarioCursoAsistenciaId",
                table: "Asistencias",
                newName: "CursoId");

            migrationBuilder.RenameIndex(
                name: "IX_Asistencias_UCAUsuarioCursoAsistenciaId",
                table: "Asistencias",
                newName: "IX_Asistencias_CursoId");

            migrationBuilder.RenameColumn(
                name: "UsuarioCursoAsistenciaId",
                table: "UsuarioCursoAsistencias",
                newName: "UsuarioCursoId");

            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Asistencias",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "UsuarioCursoAsistencias",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    CursoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.CursoId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioCursoAsistencias_CursoId",
                table: "UsuarioCursoAsistencias",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencias_Cursos_CursoId",
                table: "Asistencias",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioCursoAsistencias_Cursos_CursoId",
                table: "UsuarioCursoAsistencias",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asistencias_Cursos_CursoId",
                table: "Asistencias");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioCursoAsistencias_Cursos_CursoId",
                table: "UsuarioCursoAsistencias");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioCursoAsistencias_CursoId",
                table: "UsuarioCursoAsistencias");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Asistencias");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "UsuarioCursoAsistencias");

            migrationBuilder.RenameColumn(
                name: "CursoId",
                table: "Asistencias",
                newName: "UCAUsuarioCursoAsistenciaId");

            migrationBuilder.RenameIndex(
                name: "IX_Asistencias_CursoId",
                table: "Asistencias",
                newName: "IX_Asistencias_UCAUsuarioCursoAsistenciaId");

            migrationBuilder.RenameColumn(
                name: "UsuarioCursoId",
                table: "UsuarioCursoAsistencias",
                newName: "UsuarioCursoAsistenciaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asistencias_UsuarioCursoAsistencias_UCAUsuarioCursoAsistenciaId",
                table: "Asistencias",
                column: "UCAUsuarioCursoAsistenciaId",
                principalTable: "UsuarioCursoAsistencias",
                principalColumn: "UsuarioCursoAsistenciaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
