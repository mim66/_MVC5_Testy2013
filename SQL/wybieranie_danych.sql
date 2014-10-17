Select Id=d.DepartmentID, d.Name, d.Budget, d.StartDate, Instuctor=i.LastName + i.FirstName FROM Department d
	Inner Join Instructor i ON d.InstructorID=i.Id

/*
Select * FROM Course
Select * FROM CourseInstructor
Select * FROM Department
Select * FROM Enrollment
Select * FROM Instructor
Select * FROM OfficeAssignment
Select * FROM Student
*/
--Select i.*, Tytul=Cast(c.CourseID as nvarchar(5))+' '+ c.Title, o.Location
--FROM Instructor i
--	Left Join CourseInstructor ci	ON i.id=ci.InstructorID
--	Left Join Course c				ON ci.CourseID=c.CourseID
--	Left Join OfficeAssignment o	ON i.ID=o.InstructorID

--Select Cast(c.CourseID as nvarchar(5))+' '+ c.Title FROM Course c

--Select i.*,o.Location FROM Instructor i Left Join OfficeAssignment o ON i.ID=o.InstructorID


--Select * FROM __MigrationHistory
--Select 'Select * FROM '+table_name from INFORMATION_SCHEMA.TABLES order by table_name
