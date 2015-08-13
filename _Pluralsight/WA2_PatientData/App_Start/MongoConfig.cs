using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WA2_PatientData.Models;
using MongoDB.Driver.Linq;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Core;

namespace WA2_PatientData
{
   public class MongoConfig
   {
      public void Seed() 
      {
         var client = new MongoClient();
         var db = client.GetDatabase("test");
         var collection = db.GetCollection<Person>("people");


         var jane = new Person { Name = "Jane McJane", Age = 24, Profession = "Hacker" };

         await collection.InsertOneAsync(jane);


         //PatientDb pat = new PatientDb();
         //var patients = pat.Open().Find


         //var builder = Builders<Patient>.Filter;
         //var filter = builder.AnyEq("_name", "Marek");

         //if ((!(FilterDefinitionBuilder<Patient>)filter).)
         //{
         //var data = null;
         //}

         //if (patients.Find( { age: { $gt: 18 } }, { name: 1, address: 1 } ).limit(5))
         //MongoCursor<Car> carsInDbCursor = CarRentalContext.Cars.FindAll();
         //IEnumerable<Car> cars = carsInDbCursor.AsQueryable().Where(c => c.NumberOfDoors > 3);


         //var client = new MongoClient("mongodb://localhost:27017");
         //var database = client.GetDatabase("foo");
         //var collection = database.GetCollection<Person>("bar");

         //await collection.InsertOneAsync(new Person { Name = "Jack" });

         //var list = await (pat.Open()).Find(x => x.Name == "Jack").ToListAsync();
         //if (list.co == 0) 
         //{ 
            
         //}

         //foreach (var person in list)
         //{
         //   Console.WriteLine(person.Name);
         //}

      }

   }
}