using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver.Linq;
using MongoDB.Driver;
using MongoDB.Bson;


namespace WA2_PatientData.Models
{
   public class Person
   {
      public ObjectId Id { get; set; }

      public string Name { get; set; }

      public int Age { get; set; }

      public string Profession { get; set; }
   }


}