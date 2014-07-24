using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.DAL;
using ContosoUniversity.Models;

namespace ContosoUniversity.Controllers
{
   public class StudentController : Controller
   {
      private SchoolContext db = new SchoolContext();


      // GET: Student
      public ActionResult Index(string sortOrder)
      {
         ViewBag.NameSortParm = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
         ViewBag.FirstSortParm = sortOrder == "FName" ? "fname_desc" : "FName";
         ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
         var students = from s in db.Students select s;
         switch (sortOrder) {
            case "name_desc":
               students = students.OrderByDescending(s => s.LastName);
               break;
            case "fname_desc":
               students = students.OrderBy(s => s.FirstMidName);
               break;
            case "FName":
               students = students.OrderByDescending(s => s.FirstMidName);
               break;
            case "date_desc":
               students = students.OrderBy(s => s.EnrollmentDate);
               break;
            case "Date":
               students = students.OrderByDescending(s => s.EnrollmentDate);
               break;
            default:
               students = students.OrderBy(s=>s.LastName);
               break;
         }
         return View(students.ToList());
      }


      // GET: Student/Details/5
      public ActionResult Details(int? id)
      {
         if (id == null)
         {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         Student student = db.Students.Find(id);
         if (student == null)
         {
            return HttpNotFound();
         }
         return View(student);
      }



      // GET: Student/Create
      public ActionResult Create()
      {
         return View();
      }

      // POST: Student/Create
      // To protect from overposting attacks, please enable the specific properties you want to bind to, for more details see http://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Create([Bind(Include = "ID,LastName,FirstMidName,EnrollmentDate")] Student student)
      {
         try
         {
            if (ModelState.IsValid)
            {
               db.Students.Add(student);
               db.SaveChanges();
               return RedirectToAction("Index");
            }
         }
         catch (DataException dex) {
            //Log the error (uncomment dex variable name and add a line here to write a log.
            ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
         }
         return View(student);
      }



      // GET: Student/Edit/5
      public ActionResult Edit(int? id)
      {
         if (id == null)
         {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         Student student = db.Students.Find(id);
         if (student == null)
         {
            return HttpNotFound();
         }
         return View(student);
      }

      // POST: Student/Edit/5
      // To protect from overposting attacks, please enable the specific roperties you want to bind to, for // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Edit([Bind(Include = "ID,LastName,FirstMidName,EnrollmentDate")] Student student)
      {
         try {
            if (ModelState.IsValid) {
               db.Entry(student).State = EntityState.Modified;
               db.SaveChanges();
               return RedirectToAction("Index");
            }
         }
         catch (DataException dev) {
            //Log the error (uncomment dex variable name and add a line here to write a log.
            ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
         }
         return View(student);
      }




      // GET: Student/Delete/5
      public ActionResult Delete(int? id, bool? saveChangesError=false)
      {
         if (id == null) {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         if (saveChangesError.GetValueOrDefault()) {
            ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";         
         }
         Student student = db.Students.Find(id);
         if (student == null) {
            return HttpNotFound();
         }
         return View(student);
      }

      // POST: Student/Delete/5
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Delete(int id)
      {
         try {
            //standard performance
            //Student student = db.Students.Find(id);
            //db.Students.Remove(student);
            //db.SaveChanges();

            //better performance only with promary key
            Student studentToDelete = new Student() { ID = id };
            db.Entry(studentToDelete).State = EntityState.Deleted;
            db.SaveChanges();
         }
         catch (DataException dev) {
            //Log the error (uncomment dex variable name and add a line here to write a log.
            return RedirectToAction("Delete", new { id = id, saveChangesError = true });
         }
         return RedirectToAction("Index");
      }





      protected override void Dispose(bool disposing)
      {
         if (disposing) {
            db.Dispose();
         }
         base.Dispose(disposing);
      }
   }
}
