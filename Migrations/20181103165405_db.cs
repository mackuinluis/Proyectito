using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace demomvc.Migrations
{
    public partial class db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conductor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Licencia = table.Column<string>(nullable: true),
                    Usuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conductor", x => x.ID);
                });

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

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CodigoCarga = table.Column<int>(nullable: false),
                    CodigoConductor = table.Column<int>(nullable: false),
                    CodigoFactura = table.Column<string>(nullable: true),
                    Destino = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    FechaCobrado = table.Column<string>(nullable: true),
                    FechaDestino = table.Column<string>(nullable: true),
                    FechaEntregaDocumento = table.Column<string>(nullable: true),
                    FechaSalida = table.Column<string>(nullable: true),
                    MontoCobrado = table.Column<double>(nullable: false),
                    MontoFacturado = table.Column<double>(nullable: false),
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
                    Apellidos = table.Column<string>(nullable: false),
                    Celular = table.Column<int>(nullable: false),
                    ConfirmarContraseña = table.Column<string>(nullable: true),
                    ConfirmarCorreo = table.Column<string>(nullable: true),
                    Contraseña = table.Column<string>(nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    Nacimiento = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(maxLength: 40, nullable: false),
                    Usu = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conductor");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
