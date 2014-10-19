using NHibernate;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NHibernateWebSample.Models;

namespace NHibernateWebSample
{
   public partial class Default : System.Web.UI.Page
   {
      #region Loding EmpId and DepId into DropDownList
      protected void Page_Load(object sender, EventArgs e)
      {
         if (!IsPostBack) {
            NHibernate.Cfg.Configuration cfg = new NHibernate.Cfg.Configuration();
            cfg.AddAssembly("NHibernateWebSample");

            ISessionFactory factory = cfg.BuildSessionFactory();
            ISession session = factory.OpenSession();
            IList empIds = session.CreateCriteria(typeof(Employees)).List();
            IList depIds = session.CreateCriteria(typeof(Departments)).List();

            ddlDeptId.DataSource = depIds;
            ddlDeptId.DataTextField = "DepId";
            ddlDeptId.DataValueField = "DepId";
            ddlDeptId.DataBind();

            ddlEmpId.DataSource = empIds;
            ddlEmpId.DataTextField = "EmpId";
            ddlEmpId.DataValueField = "EmpId";
            ddlEmpId.DataBind();

            session.Close();
         }
      }
      #endregion

      #region Insert
      protected void btnInsert_Click(object sender, EventArgs e)
      {
         NHibernate.Cfg.Configuration cfg = new NHibernate.Cfg.Configuration();
         cfg.AddAssembly("NHibernateWebSample");

         ISessionFactory factory = cfg.BuildSessionFactory();
         ISession session = factory.OpenSession();
         ITransaction transaction = session.BeginTransaction();

         Employees newUser = new Employees();

         newUser.FirstName = txtFirstName.Text;
         newUser.SecondName = txtLastName.Text;
         newUser.DepId = "DD3"; //ddlDeptId.SelectedValue.ToString();

         // Tell NHibernate that this object should be saved
         session.Save(newUser);

         // commit all of the changes to the DB and close the ISession
         transaction.Commit();
         session.Close();
      }
      #endregion

      #region Loading Data into Gridview
      protected void btnLoad_Click(object sender, EventArgs e)
      {
         NHibernate.Cfg.Configuration cfg = new NHibernate.Cfg.Configuration();
         cfg.AddAssembly("NHibernateWebSample");

         ISessionFactory factory = cfg.BuildSessionFactory();
         ISession session = factory.OpenSession();

         IList dataEmployee = session.CreateCriteria(typeof(Employees)).List();

         grdEmployee.DataSource = dataEmployee;
         grdEmployee.DataBind();
         session.Close();
      }
      #endregion

      #region Updating the Data for two Tables(Employees, EmployeeInfos)
      protected void ddlEmpId_SelectedIndexChanged(object sender, EventArgs e)
      {
         string test = ddlEmpId.SelectedValue.ToString();
         NHibernate.Cfg.Configuration cfg = new NHibernate.Cfg.Configuration();
         cfg.AddAssembly("NHibernateWebSample");

         ISessionFactory factory = cfg.BuildSessionFactory();
         ISession session = factory.OpenSession();

         session = factory.OpenSession();
         Employees dataEmpId = (Employees)session.Load(typeof(Employees), Convert.ToInt32(test));
         EmployeeInfos dataEmpIdInfo = (EmployeeInfos)session.Load(typeof(EmployeeInfos), Convert.ToInt32(test));

         txtFirstUpdate.Text = dataEmpId.FirstName.ToString();
         txtLastUpdate.Text = dataEmpId.SecondName.ToString();
         txtUpdateEmail.Text = dataEmpIdInfo.EmailId.ToString();
         txtUpdateAddress.Text = dataEmpIdInfo.Address.ToString();
         txtUpdateDOJ.Text = dataEmpIdInfo.DOJ.ToString();
      }

      protected void btnUpdate_Click(object sender, EventArgs e)
      {
         string test = ddlEmpId.SelectedValue.ToString();
         NHibernate.Cfg.Configuration cfg = new NHibernate.Cfg.Configuration();
         cfg.AddAssembly("NHibernateWebSample");

         ISessionFactory factory = cfg.BuildSessionFactory();
         ISession session = factory.OpenSession();

         // set property
         Employees dataEmpId = (Employees)session.Load(typeof(Employees), Convert.ToInt32(test));
         EmployeeInfos dataEmpIdInfo = (EmployeeInfos)session.Load(typeof(EmployeeInfos), Convert.ToInt32(test));
         dataEmpId.FirstName = txtFirstUpdate.Text;
         dataEmpId.SecondName = txtLastUpdate.Text;

         dataEmpIdInfo.EmailId = txtUpdateEmail.Text;
         dataEmpIdInfo.Address = txtUpdateAddress.Text;
         dataEmpIdInfo.DOJ = Convert.ToDateTime(txtUpdateDOJ.Text);

         // flush the changes from the Session to the Database
         session.Flush();
      }
      #endregion

      #region Paging
      protected void grdEmployee_PageIndexChanging(object sender, GridViewPageEventArgs e)
      {
         grdEmployee.PageIndex = e.NewPageIndex;
         NHibernate.Cfg.Configuration cfg = new NHibernate.Cfg.Configuration();
         cfg.AddAssembly("NHibernateWebSample");

         ISessionFactory factory = cfg.BuildSessionFactory();
         ISession session = factory.OpenSession();

         IList dataEmployee = session.CreateCriteria(typeof(Employees)).List();

         grdEmployee.DataSource = dataEmployee;
         grdEmployee.DataBind();
      }
      #endregion


   }
}