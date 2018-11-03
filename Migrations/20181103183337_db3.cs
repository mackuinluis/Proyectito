using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace demomvc.Migrations
{
    public partial class db3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nacimiento",
                table: "Usuario",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Nacimiento",
                table: "Usuario",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
