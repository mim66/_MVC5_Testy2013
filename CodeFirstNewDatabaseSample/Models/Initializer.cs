using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace CodeFirstNewDatabaseSample.Models
{
    public class Initializer : DropCreateDatabaseIfModelChanges<Models.BloggingContext>
    {
        protected override void Seed(BloggingContext context) {
            // Seeding data here
            IList<Blog> blogi = new List<Blog>();

            blogi.Add(new Blog() { Name = "Aneta"});
            blogi.Add(new Blog() { Name = "Marek"});
            blogi.Add(new Blog() { Name = "Weroni"});

            foreach (Blog b in blogi)
                context.Blogs.Add(b);

            //All standards will
            //base.Seed(context);

            context.SaveChanges();
        }
    }
}


