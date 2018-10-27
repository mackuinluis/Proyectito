using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace demomvc.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CodigoCarga = table.Column<string>(nullable: true),
                    CodigoConductor = table.Column<string>(nullable: true),
                    CodigoFactura = table.Column<string>(maxLength: 40, nullable: false),
                    Destino = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    FechaCobrado = table.Column<string>(nullable: true),
                    FechaDestino = table.Column<string>(nullable: true),
                    FechaEntregaDocumento = table.Column<string>(nullable: true),
                    FechaSalida = table.Column<string>(nullable: true),
                    MontoCobrado = table.Column<string>(nullable: true),
                    MontoFacturado = table.Column<string>(nullable: true),
                    Origen = table.Column<string>(nullable: true),
                    PlacaCarreta = table.Column<string>(nullable: true),
                    PlacaTracto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Apellidos = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    ConfirmarContraseña = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Nacimiento = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(maxLength: 40, nullable: false),
                    Usu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
