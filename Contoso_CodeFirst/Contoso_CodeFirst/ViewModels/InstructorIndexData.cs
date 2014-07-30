using System;
using System.Collections.Generic;
////rozszerzenie opisu atrybutów
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using ContosoUniversity.Models;
using ContosoUniversity.DAL;


namespace ContosoUniversity.ViewModels
{
  public class InstructorIndexData
  {
    public IEnumerable<Instructor>  Instructors { get; set; }
    public IEnumerable<Course>      Courses     { get; set; }
    public IEnumerable<Enrollments>  Enrollments { get; set; }
  }
}