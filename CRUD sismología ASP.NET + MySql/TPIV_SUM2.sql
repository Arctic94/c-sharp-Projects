CREATE DATABASE SISMOLOGIA;

USE SISMOLOGIA;

CREATE TABLE COMUNA(
ID INT PRIMARY KEY AUTO_INCREMENT,
NOMBRE VARCHAR(50) NOT NULL
);

CREATE TABLE SISMO(
ID INT PRIMARY KEY AUTO_INCREMENT,
FECHA_EVENTO DATETIME NOT NULL,
COMUNA INT NOT NULL,
PROFUNDIDAD NUMERIC(3,2) NOT NULL,
DESCRIPCION VARCHAR(100) NOT NULL,
INTENSIDAD NUMERIC(2,1) NOT NULL,
CONSTRAINT FK_COMUNA_SISMO FOREIGN KEY(COMUNA) REFERENCES COMUNA(ID)
);