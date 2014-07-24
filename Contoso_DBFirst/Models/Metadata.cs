using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Contoso_DBFirst.Models
{
   //do public partial class Student dodaj adnotację
   //using System.ComponentModel.DataAnnotations;
   //   [MetadataType(typeof(StudentMetadata))]
   //   public partial class Student

   public class StudentMetadata {
      [Required]
      [StringLength(50)]
      [Display(Name = "Last Name")]
      public string LastName { get; set; }
      
      [Required]
      [StringLength(50, MinimumLength=3, ErrorMessage = "Imię musi zawierać od 3 do 50 znaków")]
      //[Column("FirstName")]  //only in CodeFirst
      [Display(Name = "First Name")]
      public string FirstMidName { get; set; }
      
      [DataType(DataType.Date)]
      [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", 
      ApplyFormatInEditMode = true)]
      [Display(Name = "Enrollment Date")]
      public DateTime EnrollmentDate { get; set; }
      
      [Display(Name = "Full Name")]
      public string FullName { get  {  return LastName + ", " + FirstMidName; }}
   }
}