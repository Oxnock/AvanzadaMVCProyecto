using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CampusVirtual.Migrations
{
    public partial class DbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CursoId",
                table: "Grupos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarreraId",
                table: "Cursos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarrerasCCarrerasId",
                table: "Cursos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_CarrerasCCarrerasId",
                table: "Cursos",
                column: "CarrerasCCarrerasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Carreras_CarrerasCCarrerasId",
                table: "Cursos",
                column: "CarrerasCCarrerasId",
                principalTable: "Carreras",
                principalColumn: "CarrerasId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Carreras_CarrerasCCarrerasId",
                table: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_CarrerasCCarrerasId",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Grupos");

            migrationBuilder.DropColumn(
                name: "CarreraId",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "CarrerasCCarrerasId",
                table: "Cursos");
        }
    }
}
