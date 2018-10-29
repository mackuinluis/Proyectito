﻿CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

CREATE TABLE "Usuario" (
    "Id" TEXT NOT NULL CONSTRAINT "PK_Usuario" PRIMARY KEY,
    "Nombre" TEXT NULL
    "Apellidos" TEXT NULL
    "Usu" TEXT NULL
    "Contraseña" TEXT NULL
    "ConfirmarContraseña" TEXT NULL
    "Correo" TEXT NULL
    "Celular" TEXT NULL
    "Nacimiento" TEXT NULL
);

CREATE TABLE "Factura" (
    "Id" TEXT NOT NULL CONSTRAINT "PK_Factura" PRIMARY KEY,
    "CodigoFactura" TEXT NULL
    "PlacaTracto" TEXT NULL
    "PlacaCarreta" TEXT NULL
    "CodigoConductor" TEXT NULL
    "Origen" TEXT NULL
    "FechaSalida" TEXT NULL
    "Destino" TEXT NULL
    "FechaDestino" TEXT NULL
    "CodigoCarga" TEXT NULL
    "FechaEntregaDocumento" TEXT NULL
    "MontoFacturado" TEXT NULL
    "Estado" TEXT NULL
    "FechaCobrado" TEXT NULL
    "MontoCobrado" TEXT NULL
);

CREATE TABLE "Conductor" (
    "Id" TEXT NOT NULL CONSTRAINT "PK_Conductor" PRIMARY KEY,
    "Usuario" TEXT NULL
    "Licencia" TEXT NULL 
);

CREATE TABLE "Empresa" (
    "Id" INT NOT NULL CONSTRAINT "PK_Empresa" PRIMARY KEY,
    "Gerente" TEXT NOT NULL
    "RUC" INT NOT NULL
    "Nombre" TEXT NOT NULL
    "Direccion" TEXT NOT NULL
    "Celular" INT NULL
    "Telefono" INT NULL
    "Tipo" TEXT NOT NULL
);
INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20181010130110_InitialCreate', '2.0.3-rtm-10026');

