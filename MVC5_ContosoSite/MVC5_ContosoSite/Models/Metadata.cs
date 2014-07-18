using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC5_ContosoSite.Models
{
   public class StudentMetadata
   {
      [StringLength(50)]
      public string LastName;

      [StringLength(50)]
      public string FirstName;

      [StringLength(50)]
      public string MiddleName;
   }

   public class EnrollmentMetadata
   {
      [Range(0, 4)]
      public Nullable<decimal> Grade;
   }
}