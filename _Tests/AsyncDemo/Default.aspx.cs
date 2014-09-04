using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.Entity;
using System.Threading.Tasks;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void SynchProgram_Click(object sender, EventArgs e) {
        Literal1.Text = "";
        SyncPerformDatabaseOperations();

        Literal1.Text += "Quote of the day <br/>";
        Literal1.Text += " Don't worry about the world coming to an end today...  <br/>";
        Literal1.Text += " It's already tomorrow in Australia. <br/>";
        Literal1.Text += " <br/>";
    }

    protected void AsynchProgram_Click(object sender, EventArgs e) {
        Literal1.Text = "";
        var task = AsyncPerformDatabaseOperations();

        Literal1.Text += "Quote of the day <br/>";
        Literal1.Text += " Don't worry about the world coming to an end today...  <br/>";
        Literal1.Text += " It's already tomorrow in Australia. <br/>";
        Literal1.Text += " <br/>";

        task.Wait();
    }

    public void SyncPerformDatabaseOperations() {
        using (var db = new Model.BloggingContext()) {
            // Create a new blog and save it 
            db.Blogs.Add(new Model.Blog {
                Name = "Test Blog #" + (db.Blogs.Count() + 1)
            });
            db.SaveChanges();

            // Query for all blogs ordered by name 
            var blogs = (from b in db.Blogs
                         orderby b.Name
                         select b).ToList();

            // Write all blogs out to Console 
            Literal1.Text += "All blogs:" + "<br/>";
            foreach (var blog in blogs) {
                Literal1.Text += " " + blog.Name + "<br/>";
            }
        }
    }

    public async Task AsyncPerformDatabaseOperations() {
        using (var db = new Model.BloggingContext()) {
            // Create a new blog and save it 
            db.Blogs.Add(new Model.Blog {
                Name = "Test Blog #" + (db.Blogs.Count() + 1)
            });
            Literal1.Text += "Calling SaveChanges." + "<br/>";
            await db.SaveChangesAsync();
            Literal1.Text += "SaveChanges completed." + "<br/>";

            // Query for all blogs ordered by name 
            Literal1.Text += "Executing query." + "<br/>";
            var blogs = await (from b in db.Blogs
                               orderby b.Name
                               select b).ToListAsync();

            // Write all blogs out to Console 
            Literal1.Text += "Query completed with following results:" + "<br/>";
            foreach (var blog in blogs) {
                Literal1.Text += " - " + blog.Name + "<br/>";
            }
        } 
    }


}