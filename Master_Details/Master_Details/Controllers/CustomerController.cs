﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Master_Details.Models;

namespace Master_Details.Controllers
{
   public class CustomerController : Controller
   {
      private NorthwindEntities db = new NorthwindEntities();

      // GET: Customer
      //public ActionResult Index() {
      //   return View(db.Customers.Take(5).ToList());
      //}

      public ActionResult Index(string id = null) {
         List<Customers> newCustomerist = db.Customers.Take(5).ToList();

         var model = new CustomerMasterDetailsModel();
         model.Customers = newCustomerist;
         if(id != null){
            model.SelectedCustomer = newCustomerist.Find(s=>s.CustomerID == id);
            model.SelectedCustomerID = id;
         }
         return View(model);
      }


      // GET: Customer/Details/5
      public ActionResult Details(string id) {
         if (id == null) {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         Customers customers = db.Customers.Find(id);
         if (customers == null) {
            return HttpNotFound();
         }
         return View(customers);
      }


      // GET: Customer/CustomerDetail/5
      public ActionResult CustomerDetail(string id = null) {

         Customers customers = db.Customers.Find(id);
         if (customers == null) {
            return HttpNotFound();
         }
         return PartialView("_CustomerDetail", customers);
      }




      // GET: Customer/Create
      public ActionResult Create() {
         return View();
      }

      // POST: Customer/Create
      // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
      // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Create([Bind(Include = "CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax")] Customers customers) {
         if (ModelState.IsValid) {
            db.Customers.Add(customers);
            db.SaveChanges();
            return RedirectToAction("Index");
         }

         return View(customers);
      }



      // GET: Customer/Edit/5
      public ActionResult Edit(string id) {
         if (id == null) {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         Customers customers = db.Customers.Find(id);
         if (customers == null) {
            return HttpNotFound();
         }
         return View(customers);
      }

      // POST: Customer/Edit/5
      // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
      // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
      [HttpPost]
      [ValidateAntiForgeryToken]
      public ActionResult Edit([Bind(Include = "CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax")] Customers customers) {
         if (ModelState.IsValid) {
            db.Entry(customers).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
         }
         return View(customers);
      }



      // GET: Customer/Delete/5
      public ActionResult Delete(string id) {
         if (id == null) {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
         }
         Customers customers = db.Customers.Find(id);
         if (customers == null) {
            return HttpNotFound();
         }
         return View(customers);
      }

      // POST: Customer/Delete/5
      [HttpPost, ActionName("Delete")]
      [ValidateAntiForgeryToken]
      public ActionResult DeleteConfirmed(string id) {
         Customers customers = db.Customers.Find(id);
         db.Customers.Remove(customers);
         db.SaveChanges();
         return RedirectToAction("Index");
      }

      
      
      
      protected override void Dispose(bool disposing) {
         if (disposing) {
            db.Dispose();
         }
         base.Dispose(disposing);
      }
   }
}
