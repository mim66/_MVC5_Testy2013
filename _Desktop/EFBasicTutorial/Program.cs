using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBasicTutorial
{
	class Program
	{
		static void Main(string[] args)
		{

			//Create student in disconnected mode
			Student newStudent = new Student() { StudentName = "New Single Student" };

			//Assign new standard to student entity
			newStudent.Standard = new Standard() { StandardName = "New Standard" };

			//add new course with new teacher into student.courses
			newStudent.Courses.Add(new Course() { CourseName = "New Course for single student", Teacher = new Teacher() { TeacherName = "New Teacher" } });

			using (var context = new SchoolDBEntities())
			{
				context.Students.Add(newStudent);
				context.SaveChanges();

				Console.WriteLine("New Student Entity has been added with new StudentId= " + newStudent.StudentID.ToString());
				Console.WriteLine("New Standard Entity has been added with new StandardId= " + newStudent.StandardId.ToString());
				Console.WriteLine("New Course Entity has been added with new CourseId= " + newStudent.Courses.ElementAt(0).CourseId.ToString());
				Console.WriteLine("New Teacher Entity has been added with new TeacherId= " + newStudent.Courses.ElementAt(0).TeacherId.ToString());
			}

			//Student stud;
			//// Get student from DB
			//using (var ctx = new SchoolDBEntities())			{
			//	stud = ctx.Students.Where(s => s.StudentName == "New Student1").FirstOrDefault<Student>();
			//}

			//// change student name in disconnected mode (out of DBContext scope)
			//if (stud != null)			{
			//	stud.StudentName = "Updated Student1";
			//}

			////save modified entity using new DBContext
			//using (var dbCtx = new SchoolDBEntities())
			//{
			//	//Mark entity as modified
			//	dbCtx.Entry(stud).State = System.Data.EntityState.Modified;
			//	dbCtx.SaveChanges();
			//}
    


			//// create new Standard entity object
			//var newStandard = new Standard();

			//// Assign standard name
			//newStandard.StandardName = "Standard 1";

			////create DBContext object
			//using (var dbCtx = new SchoolDBEntities())
			//{
			//	//Add standard object into Standard DBset
			//	dbCtx.Standards.Add(newStandard);
			//	// call SaveChanges method to save standard into database
			//	dbCtx.SaveChanges();
			//}


			//using (var context = new SchoolDBEntities())
			//{
			//	var studentList = context.Students.ToList<Student>();

			//	//Add student in list
			//	studentList.Add(new Student() { StudentName = "New Student" });

			//	//Perform update operation
			//	Student studentToUpdate = studentList.Where(s => s.StudentName == "Student1").FirstOrDefault<Student>();
			//	studentToUpdate.StudentName = "Edited student1";

			//	//Delete student from list
			//	if (studentList.Count > 0)
			//		studentList.Remove(studentList.ElementAt<Student>(0));

			//	//SaveChanges will only do update operation not add and delete
			//	context.SaveChanges();
			//}

			//using (var context = new SchoolDBEntities())
			//{
			//	var studentList = context.Students.ToList<Student>();

			//	//Perform create operation
			//	context.Students.Add(new Student() { StudentName = "New Student" });

			//	//Perform Update operation
			//	Student studentToUpdate = studentList.Where(s => s.StudentName == "student1").FirstOrDefault<Student>();
			//	studentToUpdate.StudentName = "Edited student1";

			//	//Perform delete operation
			//	context.Students.Remove(studentList.ElementAt<Student>(0));

			//	//Execute Inser, Update & Delete queries in the database
			//	context.SaveChanges();
			//} 
			
			Console.ReadLine();
		}

	}

}
