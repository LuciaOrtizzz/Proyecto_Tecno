CREATE DATABASE TECG1;
USE TECG1;

CREATE TABLE Ingreso(
Usuario varchar(20) NOT NULL PRIMARY KEY,
Contraseña varchar(20) NOT NULL,
Rol varchar(20) NOT NULL,
);

CREATE TABLE Informacion(
Usuario varchar(20) NOT NULL PRIMARY KEY,
Nombre varchar(30) NOT NULL,
Apellidos varchar(30) NOT NULL,
Correo varchar(50) NOT NULL,
edad int NOT NULL
);

INSERT INTO Ingreso values('Lucia','1234','ADMINISTRADOR')
INSERT INTO Ingreso values('Luci','1234','USUARIO')
INSERT INTO Ingreso values('LuxXa','1234','SECRETARIA')

SELECT *FROM Informacion