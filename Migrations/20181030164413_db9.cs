using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace demomvc.Migrations
{
    public partial class db9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Celular = table.Column<int>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Gerente = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: false),
                    RUC = table.Column<int>(nullable: false),
                    Telefono = table.Column<int>(nullable: false),
                    Tipo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
