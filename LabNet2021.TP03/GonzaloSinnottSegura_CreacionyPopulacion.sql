USE [master]
GO

IF EXISTS (SELECT * FROM sys.databases d WHERE d.[name]='LabNet2021_TP03_SinnottSeguraGonzalo')
BEGIN
	ALTER DATABASE [LabNet2021_TP03_SinnottSeguraGonzalo] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
END
GO

USE [master]
GO

IF EXISTS (SELECT * FROM sys.databases d WHERE d.[name]='LabNet2021_TP03_SinnottSeguraGonzalo')
BEGIN
	DROP DATABASE [LabNet2021_TP03_SinnottSeguraGonzalo]
END
GO

CREATE DATABASE LabNet2021_TP03_SinnottSeguraGonzalo
GO

USE LabNet2021_TP03_SinnottSeguraGonzalo
GO

CREATE SCHEMA TP03
GO

--Creacion de Tablas--
CREATE TABLE [TP03].[Persons] (
    PersonID int IDENTITY(1,1) NOT NULL,
    LastName nvarchar(50) NOT NULL,
    FirstName nvarchar(50) NOT NULL,
	DNI int NOT NULL,
    Address nvarchar(100) NOT NULL,
	Phone nvarchar(100) NOT NULL,
	BirthDate datetime NOT NULL,
	CompanyID int
);

CREATE TABLE [TP03].[Companies] (
    CompanyID int IDENTITY(1,1) NOT NULL,
    CompanyName nvarchar(50) NOT NULL,
    CUIT int NOT NULL,
    Address nvarchar(100) NOT NULL,
	Phone nvarchar(100) NOT NULL    
);

CREATE TABLE [TP03].[Courses] (
    CourseID int IDENTITY(100,1) NOT NULL,
    CourseName nvarchar(50) NOT NULL,
    StartDate datetime NOT NULL,
	FinishDate datetime NOT NULL,
	ProfessorID int NOT NULL
);

CREATE TABLE [TP03].[Professors] (
    ProfessorID int IDENTITY(1,1) NOT NULL,
    LastName nvarchar(50) NOT NULL,
    FirstName nvarchar(50) NOT NULL,
	DNI int NOT NULL,
    Address nvarchar(100) NOT NULL,
	Phone nvarchar(100) NOT NULL,    
	BirthDate datetime NOT NULL,
);

CREATE TABLE [TP03].[Qualifications] (
	QualificationID int IDENTITY(1,1) NOT NULL,
	CourseID int NOT NULL,
	StudentID int NOT NULL,    
    Score int NOT NULL    
);

--Asignacion de Primary y Foreign Keys--

ALTER TABLE [TP03].[Persons]
	ADD PRIMARY KEY (PersonID);

ALTER TABLE [TP03].[Companies]
	ADD PRIMARY KEY (CompanyID);
	
ALTER TABLE [TP03].[Courses]
	ADD PRIMARY KEY (CourseID);

ALTER TABLE [TP03].[Professors]
	ADD PRIMARY KEY (ProfessorID);
	
ALTER TABLE [TP03].[Qualifications]
	ADD PRIMARY KEY (QualificationID);
	
ALTER TABLE [TP03].[Persons]
	ADD FOREIGN KEY (CompanyID) 
	REFERENCES [TP03].[Companies] (CompanyID);
	
ALTER TABLE [TP03].[Courses]
	ADD FOREIGN KEY (ProfessorID) 
	REFERENCES [TP03].[Professors](ProfessorID);

ALTER TABLE [TP03].[Qualifications]
	ADD FOREIGN KEY (StudentID) 
	REFERENCES [TP03].[Persons ](PersonID);

ALTER TABLE [TP03].[Qualifications]
	ADD FOREIGN KEY (CourseID) 
	REFERENCES [TP03].[Courses] (CourseID);

--Insercion de Datos--

INSERT INTO [TP03].[Companies] (CompanyName, CUIT, Address, Phone)
	VALUES('RedHat Inc.', 23-34768545-9, 'Avenida Las Americas 200', 2224-345467);

INSERT INTO [TP03].[Companies] (CompanyName, CUIT, Address, Phone)
	VALUES('Montecito SRL.', 13-54788553-2, 'Bonpland 200', 11-543447);


INSERT INTO [TP03].[Persons](LastName,FirstName, DNI, Address, Phone, BirthDate, CompanyID )
	VALUES ('Sinnott Segura','Gonzalo', 34797474, 'Calle Falsa 123', 011-15443450, '1989-10-30', 1);

INSERT INTO [TP03].[Persons](LastName,FirstName, DNI, Address, Phone, BirthDate, CompanyID )
	VALUES ('Perez','Jonathan', 24757774, 'Yrigoyen 300', 011-15658930, '1989-05-10', 2);

INSERT INTO [TP03].[Persons](LastName,FirstName, DNI, Address, Phone, BirthDate)
	VALUES ('Valdez','Ramon', 35678934, 'San Salvador 100', 011-15346578, '1995-02-27');

INSERT INTO [TP03].[Professors] (LastName, FirstName, DNI, Address, Phone, BirthDate)
	VALUES ('Gimenez', 'German', 25678324, 'Rivadavia 23', 2224-5467543, '1985-03-21');

INSERT INTO [TP03].[Professors] (LastName, FirstName, DNI, Address, Phone, BirthDate)
	VALUES ('Lopez', 'Damian', 13458765, 'San Benito 200', 2224-6521463, '1970-10-05');

INSERT INTO [TP03].[Courses] (CourseName, StartDate, FinishDate, ProfessorID)
	VALUES('Electricidad 1', '2015-03-20', '2015-08-20', 1);

INSERT INTO [TP03].[Courses] (CourseName, StartDate, FinishDate, ProfessorID)
	VALUES('Electricidad 2', '2016-03-20', '2017-08-20', 1);

INSERT INTO [TP03].[Courses] (CourseName, StartDate, FinishDate, ProfessorID)
	VALUES('Reparacion de PC', '2015-06-01', '2016-05-30', 2);

INSERT INTO [TP03].[Qualifications] (CourseID, StudentID, Score)
	VALUES(100,1,6);

INSERT INTO [TP03].[Qualifications] (CourseID, StudentID, Score)
	VALUES(100,2,4);

INSERT INTO [TP03].[Qualifications] (CourseID, StudentID, Score)
	VALUES(101,1,2);

INSERT INTO [TP03].[Qualifications] (CourseID, StudentID, Score)
	VALUES(101,2,8);

INSERT INTO [TP03].[Qualifications] (CourseID, StudentID, Score)
	VALUES(102,1,2);

INSERT INTO [TP03].[Qualifications] (CourseID, StudentID, Score)
	VALUES(102,2,4);

INSERT INTO [TP03].[Qualifications] (CourseID, StudentID, Score)
	VALUES(102,3,3);

