CREATE DATABASE Gestionar_Visitantes

GO

USE Gestionar_Visitantes

GO


CREATE TABLE Usuario_Admid (

IDUsuario int primary key identity(1,1) not null,

CodeUsuario as ('Itla@Admid-' + right('220' + convert(nvarchar,IDUsuario),(2))),

Nombre nvarchar(40) not null,

Apellido nvarchar(50) not null,

Nacimiento nvarchar(30) not null,

)

Go

INSERT INTO Usuario_Admid VALUES ('Principal', 'User', '00-00-0000');

Go


CREATE TABLE Usuario_General (

IDUsuario int primary key identity(1,1) not null,

CodeUsuario as ('Itla@General-' + right('220' + convert(nvarchar,IDUsuario),(2))),

Nombre nvarchar(40) not null,

Apellido nvarchar(50) not null,

Nacimiento nvarchar(30) not null,

)

Go


CREATE TABLE Lugar (

IDLugar int primary key identity(1,1) not null,

CodeLugar as ('Itla@Lugar-' + right('220' + convert(nvarchar,IDLugar),(2))),

Edificio nvarchar(50) not null,

Aula nvarchar(40) not null,

)

Go

INSERT INTO Lugar VALUES ('Edicio A', 'Aula 15');

INSERT INTO Lugar VALUES ('Edicio A', 'Aula 3');

INSERT INTO Lugar VALUES ('Edicio A', 'Aula 45');

INSERT INTO Lugar VALUES ('Edicio B', 'Aula 95');

INSERT INTO Lugar VALUES ('Edicio B', 'Aula 87');

INSERT INTO Lugar VALUES ('Edicio C', 'Aula 21');

Go


CREATE TABLE Visitantes (

IDVisitante int primary key identity(1,1) not null,

CodeVisitante as ('Itla@Visitante-' + right('220' + convert(nvarchar,IDVisitante),(2))),

Nombre nvarchar(40) not null,

Apellido nvarchar(50) not null,

Carrera nvarchar(40) null,

Email nvarchar(40) null,

Entrada nvarchar(40) not null,

Salida nvarchar(40) not null,

Motivo nvarchar(50) not null,

Foto nvarchar(40) null,

Edifico nvarchar(50) not null,

Aula nvarchar(40) not null,

) 

Go

CREATE PROC SP_BuscarVisitante
@Buscar nvarchar(30)
as
SELECT * FROM Visitantes
WHERE CodeVisitante LIKE @Buscar + '%' 

GO

CREATE PROC SP_BuscarLugar
@Buscar nvarchar(30)
as
SELECT * FROM Lugar
WHERE CodeLugar LIKE @Buscar + '%' 

GO


CREATE PROC SP_BuscarLugarEdificio
@Buscar nvarchar(50)
as
SELECT Edificio FROM Lugar
WHERE Edificio LIKE @Buscar + '%'
Group by Edificio
GO

CREATE PROC SP_BuscarLugarAulas
@Buscar nvarchar(50)
as
SELECT Aula FROM Lugar
WHERE Edificio = @Buscar
GO


CREATE PROC SP_BuscarUsuarioAdmid
@Buscar nvarchar(30)
as
SELECT * FROM Usuario_Admid
WHERE CodeUsuario = @Buscar 

GO

CREATE PROC SP_BuscarUsuarioGeneral
@Buscar nvarchar(30)
as
SELECT * FROM Usuario_General
WHERE CodeUsuario = @Buscar 

GO

CREATE PROC SP_CountUsuarioAdmin
@Buscar nvarchar(30)
as
SELECT * FROM Usuario_Admid
WHERE CodeUsuario like @Buscar + '%'

GO

CREATE PROC SP_CountUsuarioGeneral
@Buscar nvarchar(30)
as
SELECT * FROM Usuario_General
WHERE CodeUsuario like @Buscar + '%'

GO


CREATE PROC SP_InsertarUsuarioAdmid
@Nombre nvarchar(40),
@Apellido nvarchar(50),
@Nacimiento nvarchar(30)
AS
INSERT INTO Usuario_Admid VALUES (@Nombre,@Apellido,@Nacimiento)
GO

CREATE PROC SP_InsertarUsuarioGeneral
@Nombre nvarchar(40),
@Apellido nvarchar(50),
@Nacimiento nvarchar(30)
AS
INSERT INTO Usuario_General VALUES (@Nombre,@Apellido,@Nacimiento)
GO

CREATE PROC SP_InsertarVisitante
@Nombre nvarchar(40),

@Apellido nvarchar(50),

@Carrera nvarchar(40),

@Email nvarchar(40),

@Entrada nvarchar(40),

@Salida nvarchar(40),

@Motivo nvarchar(50),

@Foto nvarchar(40),

@Edifico nvarchar(50),

@Aula nvarchar(40)
AS
INSERT INTO Visitantes VALUES (@Nombre,@Apellido,@Carrera,@Email,@Entrada,@Salida,@Motivo,@Foto,
@Edifico,@Aula)
GO


CREATE PROC SP_InsertarLugar
@Edifico nvarchar(50),
@Aula nvarchar(40)
AS
INSERT INTO Lugar VALUES (@Edifico,@Aula)
GO


CREATE PROC SP_EditarLugar
@CodeLugar nvarchar(30),
@Edifico nvarchar(50),
@Aula nvarchar(40)
AS
UPDATE Lugar SET Edificio = @Edifico, Aula = @Aula
WHERE CodeLugar = @CodeLugar

GO











