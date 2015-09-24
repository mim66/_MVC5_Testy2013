﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _05_Hello.Models;

namespace _05_Hello.Controllers
{

   public class TestController : Controller
   {

      public ActionResult GetStronglyTypedView() {
         Employee emp = NewEmployee();
         ViewData["Employee"] = emp;
         return View("MyStronglyTypedView");
      }

      public ActionResult GetViewBag() {
         Employee emp = NewEmployee();
         ViewBag.Employee = emp;
         return View("MyViewBag");
      }

      public ActionResult GetViewData() {
         Employee emp = NewEmployee();
         ViewData["Employee"] = emp;
         return View("MyViewData");
      }

      private Employee NewEmployee() {
         Employee emp = new Employee();
         emp.FirstName = "Imie";
         emp.LastName = "Nazwisko";
         emp.Salary = 2000;
         return emp;
      }

      public Customer GetCustomer() {
         Customer c = new Customer();
         c.CustomerName = "Klient1";
         c.Address = "Adres1";
         return c;
      }

   }
}