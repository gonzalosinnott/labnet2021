--Sólo con información de aquellos alumnos que han reprobado los cursos (nota Inferior a 4

USE [LabNet2021_TP03_SinnottSeguraGonzalo]
GO

SELECT
	c.CourseName	AS 'Titulo Curso',
	pr.DNI			AS 'DNI Docente',
	pr.LastName		AS 'Apellido Docente',
	c.StartDate		AS 'Fecha de Inicio',
	c.FinishDate	AS 'Fecha de Fin',
	pe.DNI			AS 'DNI Alumno',
	pe.LastName		AS 'Apellido Alumno',
	pe.FirstName	AS 'Nombre Alumno',
	q.Score			AS 'Nota Alumno'

FROM TP03.Persons pe
	JOIN TP03.Qualifications q ON q.StudentID = pe.PersonID
	JOIN TP03.Courses c ON q.CourseID = c.CourseID
	JOIN TP03.Professors pr ON c.ProfessorID = pr.ProfessorID

WHERE q.Score <4

-- Cursos que hayan iniciado luego del primero de enero del 2015
-- y finalizado antes del 31 de Diciembre del 2016

SELECT
	c.CourseName	AS 'Titulo Curso',
	pr.DNI			AS 'DNI Docente',
	pr.LastName		AS 'Apellido Docente',
	c.StartDate		AS 'Fecha de Inicio',
	c.FinishDate	AS 'Fecha de Fin',
	pe.DNI			AS 'DNI Alumno',
	pe.LastName		AS 'Apellido Alumno',
	pe.FirstName	AS 'Nombre Alumno',
	q.Score			AS 'Nota Alumno'

FROM TP03.Persons pe
	JOIN TP03.Qualifications q ON q.StudentID = pe.PersonID
	JOIN TP03.Courses c ON q.CourseID = c.CourseID
	JOIN TP03.Professors pr ON c.ProfessorID = pr.ProfessorID

WHERE c.StartDate > '2015-01-01' AND c.FinishDate < '2016-12-31'
