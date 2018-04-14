using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CampusVirtual.Migrations
{
    public partial class initialdb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioCurso_Cursos_CursoId",
                table: "UsuarioCurso");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioCurso_Cursos_CursoId",
                table: "UsuarioCurso",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioCurso_Cursos_CursoId",
                table: "UsuarioCurso");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioCurso_Cursos_CursoId",
                table: "UsuarioCurso",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "CursoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
