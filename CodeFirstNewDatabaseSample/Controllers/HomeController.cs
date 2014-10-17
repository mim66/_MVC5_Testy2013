using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstNewDatabaseSample.Models;

namespace CodeFirstNewDatabaseSample.Controllers
{
    public class HomeController : Controller
    {
        BloggingContext db = new BloggingContext();

        public ActionResult Blog() {
            // Create and save a new Blog 
            //Console.Write("Enter a name for a new Blog: ");
            var name = "marek";
            var name2 = "darek";
            var blog = new Blog { Name = name };
            var blog2 = new Blog { Name = name2 };
            db.Blogs.Add(blog);
            db.Blogs.Add(blog2);
            db.SaveChanges();

            // Display all Blogs from the database 
            var query = from b in db.Blogs
                        orderby b.Name
                        select b;
            return View(query.ToList());
        }

        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}