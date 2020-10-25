CREATE DATABASE MedicHelpperBDD
GO
USE MedicHelpperBDD
GO
CREATE TABLE TipoUsuario(
IdTipoUsuario INT IDENTITY(0,1) PRIMARY KEY,
TipoUsuario VARCHAR(25) NOT NULL,
DescipcionTipoUsuario VARCHAR(255)
)
GO
insert into TipoUsuario VALUES('Administrador','Posee todos los permisos dentro del software')
insert into TipoUsuario VALUES('Enfermeria','Encargado de la administración de citas')
insert into TipoUsuario VALUES('Dotores','Encargado de atender a los pacientes en sus consultas')
insert into TipoUsuario VALUES('Farmaceutico','Encargado de la administración de la farmacia')
CREATE TABLE Usuarios(
IdUsuario CHAR(8) PRIMARY KEY,
Contraseña VARCHAR(75) NOT NULL,
Nombre VARCHAR(75) NOT NULL,
Apellido VARCHAR(75) NOT NULL UNIQUE,
FechaDeNacimiento DATETIME NOT NULL,
DUI CHAR(9) NOT NULL,
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
Apellido VARCHAR(75) NOT NULL UNIQUE,
FechaDeNacimiento DATETIME NOT NULL
)
GO
CREATE TABLE Cita(
idCita INT IDENTITY PRIMARY KEY,
IdPacienteCita CHAR(6) FOREIGN KEY REFERENCES Pacientes(IdPaciente) ON DELETE CASCADE ON UPDATE CASCADE,
FechaCita DATETIME
Estado int NOT NULL
)
GO
CREATE TABLE Medicamentos(
IdMedicamento INT IDENTITY(0,1) PRIMARY KEY,
Nombre VARCHAR(75) NOT NULL,
Descripcion VARCHAR(255) NOT NULL,
FechaExpiracion DATETIME NOT NULL,
Hubicacion VARCHAR(100) NOT NULL,
Cantidad INT
)
GO
CREATE TABLE Consulta(
IdConsulta INT IDENTITY(0,1) PRIMARY KEY,
IdUsuarioConsulta CHAR(6) FOREIGN KEY REFERENCES Usuarios(IdUsuario) ON DELETE CASCADE ON UPDATE CASCADE,
idCita INT FOREIGN KEY REFERENCES Cita(idCita) ON DELETE CASCADE ON UPDATE CASCADE,
Descripcion VARCHAR(255) NOT NULL,
Fecha DATETIME NOT NULL
)
GO
CREATE TABLE Receta(
IdConsultaReceta INT FOREIGN KEY REFERENCES Consulta(IdConsulta) ON DELETE CASCADE ON UPDATE CASCADE,
IdMedicamentoReceta INT FOREIGN KEY REFERENCES Medicamentos(IdMedicamento) ON DELETE CASCADE ON UPDATE CASCADE,
DescripcionReceta VARCHAR(255) NOT NULL,
Estado int NOT NULL
)
GO
select count(*) from TipoUsuario
