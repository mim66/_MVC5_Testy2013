using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHibernateWebSample
{
   public class EmployeeInfos
   {
      private int _EmpId;
      private string _EmailId;
      private string _Address;
      private DateTime _DOJ;

      public virtual int EmpId
      {
         get { return _EmpId; }
         set { _EmpId = value; }
      }
      public virtual string EmailId
      {
         get { return _EmailId; }
         set { _EmailId = value; }
      }
      public virtual string Address
      {
         get { return _Address; }
         set { _Address = value; }
      }
      public virtual DateTime DOJ
      {
         get { return _DOJ; }
         set { _DOJ = value; }
      }
   }
}
