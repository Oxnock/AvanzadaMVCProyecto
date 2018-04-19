using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CampusVirtual.Migrations
{
    public partial class CodesIni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Cursos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Carreras",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Becas",
                columns: table => new
                {
                    BecaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Porcentaje = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Becas", x => x.BecaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Becas");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Carreras");
        }
    }
}
