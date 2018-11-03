CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
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
    "CodigoFactura" TEXT NULL,
    "PlacaTracto" TEXT NULL,
    "PlacaCarreta" TEXT NULL,
    "CodigoConductor" INT NULL,
    "Origen" TEXT NOT NULL,
    "FechaSalida" TEXT NULL,
    "Destino" TEXT NOT NULL,
    "FechaDestino" TEXT NULL,
    "CodigoCarga" INT NULL,
    "FechaEntregaDocumento" TEXT NULL,
    "MontoFacturado" DOUBLE NULL,
    "Estado" TEXT  NULL,
    "FechaCobrado" TEXT NULL,
    "MontoCobrado" DOUBLE NULL
);

CREATE TABLE "Conductor" (
    "Id" TEXT NOT NULL CONSTRAINT "PK_Conductor" PRIMARY KEY,
    "Usuario" TEXT NULL,
    "Licencia" TEXT NULL 
);

CREATE TABLE "Empresa" (
    "Id" INT NOT NULL CONSTRAINT "PK_Empresa" PRIMARY KEY,
    "Gerente" TEXT NOT NULL,
    "RUC" INT NOT NULL,
    "Nombre" TEXT NOT NULL,
    "Direccion" TEXT NOT NULL,
    "Celular" INT NULL,
    "Telefono" INT NULL,
    "Tipo" TEXT NOT NULL
);
INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20181010130110_InitialCreate', '2.0.3-rtm-10026');

INSERT INTO Factura (Id,CodigoFactura,PlacaTracto,PlacaCarreta,CodigoConductor,Origen,FechaSalida
,Destino,FechaDestino,CodigoCarga,FechaEntregaDocumento,MontoFacturado,Estado,FechaCobrado,MontoCobrado) 
VALUES (1,"003-0046","ALP-825","F5O-978",01,"Lima","10/01/2017","Cusco","13/01/2017",01,"23/01/2017",6877.82,
"Cancelado","28/02/2017",6583.62);

INSERT INTO Factura (Id,CodigoFactura,PlacaTracto,PlacaCarreta,CodigoConductor,Origen,FechaSalida
,Destino,FechaDestino,CodigoCarga,FechaEntregaDocumento,MontoFacturado,Estado,FechaCobrado,MontoCobrado) 
VALUES (2,"003-0047","ALP-825","F5O-978",01,"Ica","11/02/2017","Arequipa","12/02/2017",01,"15/02/2017",9076.90,
"Pendiente","19/03/2017",7089.50);

INSERT INTO Factura (Id,CodigoFactura,PlacaTracto,PlacaCarreta,CodigoConductor,Origen,FechaSalida
,Destino,FechaDestino,CodigoCarga,FechaEntregaDocumento,MontoFacturado,Estado,FechaCobrado,MontoCobrado) 
VALUES (2,"003-0047","ALP-825","F5O-978",01,"Huancayo","19/06/2017","Puno","20/06/2017",03,"23/06/2017",1005.24,
"Cancelado","25/06/2017",1005.24);

INSERT INTO Factura (Id,CodigoFactura,PlacaTracto,PlacaCarreta,CodigoConductor,Origen,FechaSalida
,Destino,FechaDestino,CodigoCarga,FechaEntregaDocumento,MontoFacturado,Estado,FechaCobrado,MontoCobrado) 
VALUES (2,"003-0047","ALP-825","F5O-978",01,"Piura","22/08/2017","Lima","23/08/2017",04,"25/08/2017",9500.00,
"Pendiente","27/08/2017",8500.00);

INSERT INTO Factura (Id,CodigoFactura,PlacaTracto,PlacaCarreta,CodigoConductor,Origen,FechaSalida
,Destino,FechaDestino,CodigoCarga,FechaEntregaDocumento,MontoFacturado,Estado,FechaCobrado,MontoCobrado) 
VALUES (2,"003-0047","ALP-825","F5O-978",01,"Lambayeque","01/09/2017","Madre de Dios","02/09/2017",04,"05/09/2017",5400.00,
"Pendiente","07/09/2017",5400.00);

INSERT INTO Factura (Id,CodigoFactura,PlacaTracto,PlacaCarreta,CodigoConductor,Origen,FechaSalida
,Destino,FechaDestino,CodigoCarga,FechaEntregaDocumento,MontoFacturado,Estado,FechaCobrado,MontoCobrado) 
VALUES (2,"003-0047","ALP-825","F5O-978",01,"Tumbes","05/11/2017","Piura","06/11/2017",04,"07/11/2017",8777.00,
"Cancelado","09/11/2017",8500.00);

