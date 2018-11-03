﻿// <auto-generated />
using demomvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using System;

namespace demomvc.Migrations
{
    [DbContext(typeof(MvcContext))]
    partial class MvcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("demomvc.Models.Conductor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Licencia");

                    b.Property<string>("Usuario");

                    b.HasKey("ID");

                    b.ToTable("Conductor");
                });

            modelBuilder.Entity("demomvc.Models.Empresa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Celular");

                    b.Property<string>("Direccion")
                        .IsRequired();

                    b.Property<string>("Gerente");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("RUC");

                    b.Property<int>("Telefono");

                    b.Property<string>("Tipo")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("demomvc.Models.Factura", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CodigoCarga");

                    b.Property<int>("CodigoConductor");

                    b.Property<string>("CodigoFactura");

                    b.Property<string>("Destino");

                    b.Property<string>("Estado");

                    b.Property<string>("FechaCobrado");

                    b.Property<string>("FechaDestino");

                    b.Property<string>("FechaEntregaDocumento");

                    b.Property<string>("FechaSalida");

                    b.Property<double>("MontoCobrado");

                    b.Property<double>("MontoFacturado");

                    b.Property<string>("Origen");

                    b.Property<string>("PlacaCarreta");

                    b.Property<string>("PlacaTracto");

                    b.HasKey("ID");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("demomvc.Models.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellidos")
                        .IsRequired();

                    b.Property<int>("Celular");

                    b.Property<string>("ConfirmarContraseña");

                    b.Property<string>("ConfirmarCorreo");

                    b.Property<string>("Contraseña")
                        .IsRequired();

                    b.Property<string>("Correo")
                        .IsRequired();

                    b.Property<DateTime>("Nacimiento");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Usu")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
