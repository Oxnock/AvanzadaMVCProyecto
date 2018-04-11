using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CampusVirtual.Migrations
{
    public partial class UsuarioCursoNameFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioCursoAsistencias_Cursos_CursoId",
                table: "UsuarioCursoAsistencias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioCursoAsistencias",
                table: "UsuarioCursoAsistencias");

            migrationBuilder.RenameTable(
                name: "UsuarioCursoAsistencias",
                newName: "UsuarioCurso");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioCursoAsistencias_CursoId",
                table: "UsuarioCurso",
                newName: "IX_UsuarioCurso_CursoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioCurso",
                table: "UsuarioCurso",
                column: "UsuarioCursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioCurso_Cursos_CursoId",
                table: "UsuarioCurso",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioCurso_Cursos_CursoId",
                table: "UsuarioCurso");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioCurso",
                table: "UsuarioCurso");

            migrationBuilder.RenameTable(
                name: "UsuarioCurso",
                newName: "UsuarioCursoAsistencias");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioCurso_CursoId",
                table: "UsuarioCursoAsistencias",
                newName: "IX_UsuarioCursoAsistencias_CursoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioCursoAsistencias",
                table: "UsuarioCursoAsistencias",
                column: "UsuarioCursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioCursoAsistencias_Cursos_CursoId",
                table: "UsuarioCursoAsistencias",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
