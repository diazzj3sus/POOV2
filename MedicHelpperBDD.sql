
CREATE DATABASE MedicHelpperBDD
GO
USE MedicHelpperBDD
USE master
DROP DATABASE MedicHelpperBDD
GO
CREATE TABLE TipoUsuario(
IdTipoUsuario INT IDENTITY(0,1) PRIMARY KEY,
TipoUsuario VARCHAR(25) NOT NULL,
DescipcionTipoUsuario VARCHAR(255)
)
GO
--Insercion en tipos de usuarios
insert into TipoUsuario VALUES('Administrador','Posee todos los permisos dentro del software')
insert into TipoUsuario VALUES('Enfermeria','Encargado de la administración de citas')
insert into TipoUsuario VALUES('Dotores','Encargado de atender a los pacientes en sus consultas')
insert into TipoUsuario VALUES('Farmaceutico','Encargado de la administración de la farmacia')
---
CREATE TABLE Usuarios(
IdUsuario CHAR(6) PRIMARY KEY,
Contraseña VARCHAR(75) NOT NULL,
Nombre VARCHAR(75) NOT NULL,
Apellido VARCHAR(75) NOT NULL,
FechaDeNacimiento DATE NOT NULL,
DUI CHAR(9) NOT NULL UNIQUE,
IdTipoUsuarioUsusarios INT FOREIGN KEY REFERENCES TipoUsuario(IdTipoUsuario) ON DELETE CASCADE ON UPDATE CASCADE
)
GO
INSERT INTO Usuarios VALUES ('AA0001','password','Admin','Admin','1-10-2020','123456789','0'),
							('EE0001','password','Enfermeria','Enfermeria','1-10-2020','234567890','1'),
							('DD0001','password','Dotores','Dotores','1-10-2020','345678901','2'),
							('FF0001','password','Farmaceutico','Farmaceutico','1-10-2020','456789012','3');
CREATE TABLE Pacientes(
IdPaciente CHAR(6) PRIMARY KEY,
Nombre VARCHAR(75) NOT NULL,
Apellido VARCHAR(75) NOT NULL,
FechaDeNacimiento DATE NOT NULL
)
GO
CREATE TABLE Cita(
idCita INT IDENTITY PRIMARY KEY,
IdPacienteCita CHAR(6) FOREIGN KEY REFERENCES Pacientes(IdPaciente) ON DELETE CASCADE ON UPDATE CASCADE,
FechaCita DATE,
Estado INT NOT NULL CONSTRAINT CK_EstadoReceta CHECK ((Estado = 1) OR (Estado = 0))
)
GO
CREATE TABLE Medicamentos(
IdMedicamento INT IDENTITY(0,1) PRIMARY KEY,
Nombre VARCHAR(75) NOT NULL,
Descripcion VARCHAR(255) NOT NULL,
FechaExpiracion DATE NOT NULL,
Hubicacion VARCHAR(100) NOT NULL,
Cantidad INT
)
GO
CREATE TABLE Consulta(
IdConsulta INT IDENTITY(0,1) PRIMARY KEY,
IdUsuarioConsulta CHAR(6) FOREIGN KEY REFERENCES Usuarios(IdUsuario) ON DELETE CASCADE ON UPDATE CASCADE,
idCita INT FOREIGN KEY REFERENCES Cita(idCita) ON DELETE CASCADE ON UPDATE CASCADE,
Descripcion VARCHAR(255) NOT NULL,
Fecha DATE NOT NULL
)
GO
CREATE TABLE Receta(
IdConsultaReceta INT FOREIGN KEY REFERENCES Consulta(IdConsulta) ON DELETE CASCADE ON UPDATE CASCADE,
IdMedicamentoReceta INT FOREIGN KEY REFERENCES Medicamentos(IdMedicamento) ON DELETE CASCADE ON UPDATE CASCADE,
DescripcionReceta VARCHAR(255) NOT NULL,
Estado INT NOT NULL CONSTRAINT CK_EstadoReceta CHECK ((Estado = 1) OR (Estado = 0))
)
GO


--PROCEDIMIENTOS ALMACENADOS
CREATE PROCEDURE SP_MostrarPacientes
AS
SELECT IdPacienteCita
FROM Cita
INNER JOIN Pacientes pacien ON pacien.IdPaciente = Cita.IdPacienteCita
GO

EXEC SP_MostrarPacientes
USE MedicHelpperBDD
select * from Pacientes