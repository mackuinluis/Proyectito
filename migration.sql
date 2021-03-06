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

INSERT INTO Usuario (ID,Nombre,Apellidos,Usu,Contraseña,ConfirmarContraseña,Correo,ConfirmarCorreo
,Celular,Nacimiento) 
VALUES (1,"Cristopher","Espino","Overhaz","overhaz123","overhaz123","sonok_thp@outlook.es",
"sonok_thp@outlook.es",953508892,"01/02/1999");


INSERT INTO Usuario (ID,Nombre,Apellidos,Usu,Contraseña,ConfirmarContraseña,Correo,ConfirmarCorreo
,Celular,Nacimiento) 
VALUES (2,"Luis Miguel","Saravia","mackuin","123","mackuin123","luis_saravia1@usmp.pe",
"luis_saravia1@usmp.pe",987445874,"04/03/1996");


INSERT INTO Usuario (ID,Nombre,Apellidos,Usu,Contraseña,ConfirmarContraseña,Correo,ConfirmarCorreo
,Celular,Nacimiento) 
VALUES (3,"Baneza","Porroa","BaneP","banep123","banep123","banezap@gmail.com",
"banezap@gmai.com",98556558,"07/05/1996");

INSERT INTO Usuario (ID,Nombre,Apellidos,Usu,Contraseña,ConfirmarContraseña,Correo,ConfirmarCorreo
,Celular,Nacimiento) 
VALUES (4,"Fred","Duarte","FredD","fred123","fred123","fredduarte@outlook.es",
"fredduarte@outlook.es",95444192,"08/02/1995");

INSERT INTO Empresa (ID,Gerente,RUC,Nombre,Direccion,Celular,Telefono,Tipo) 
VALUES (1,"Zacarias Vergara",74558,"Global SA","Av. Flora Tristan",97745877,4855788,
"Carga");

INSERT INTO Empresa (ID,Gerente,RUC,Nombre,Direccion,Celular,Telefono,Tipo) 
VALUES (2,"Edwin Donaire",84557,"Carga SA","Av. Essde 123",985512456,856452,
"Transporte");

INSERT INTO Empresa (ID,Gerente,RUC,Nombre,Direccion,Celular,Telefono,Tipo) 
VALUES (3,"Romulo Rassuri",98554,"Fideos SS","Calle Los Tulipanes 133",985623302,956215,
"Carga");

INSERT INTO Empresa (ID,Gerente,RUC,Nombre,Direccion,Celular,Telefono,Tipo) 
VALUES (4,"Cristina Frend",65544,"ErssO SA","Psje. Las Cantulias 222",985620015,965112,
"Transporte");

INSERT INTO Empresa (ID,Gerente,RUC,Nombre,Direccion,Celular,Telefono,Tipo) 
VALUES (5,"Darelis Perez",98568,"Transp S.A.C","Av. Las Morelias 100"
,956502112,458544,
"Transporte");

INSERT INTO Empresa (ID,Gerente,RUC,Nombre,Direccion,Celular,Telefono,Tipo) 
VALUES (6,"Carlos Slak",45412,"Carga Hnos. ","Calle Los Sajiros 123"
,985454124,547544,
"Carga");

INSERT INTO Empresa (ID,Gerente,RUC,Nombre,Direccion,Celular,Telefono,Tipo) 
VALUES (7,"Juan Chavez",84547,"Esparza S.A.C","Psje. Los Pinos 147"
,958745412,124574,
"Carga");

INSERT INTO Empresa (ID,Gerente,RUC,Nombre,Direccion,Celular,Telefono,Tipo) 
VALUES (8,"Oscar Reyes",84574,"Transporte ASOCIADOS","Calle Las Lilas 741"
,957447845,145412,
"Transporte");

INSERT INTO Empresa (ID,Gerente,RUC,Nombre,Direccion,Celular,Telefono,Tipo) 
VALUES (9,"Fred Duarte",454545,"Cargados S.A.C","Calle Los Suspiros 154"
,956210325,652123,
"Carga");

INSERT INTO Empresa (ID,Gerente,RUC,Nombre,Direccion,Celular,Telefono,Tipo) 
VALUES (10,"Carla Ruzzo",94784,"Olivos Trsp","Calle Los Sauces 156"
,978456123,945784,
"Transporte");







