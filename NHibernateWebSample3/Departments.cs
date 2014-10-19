using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHibernateWebSample
{
   public class Departments
   {
      private string _DepId;
      private string _DepName;

      public virtual string DepId
      {
         get { return _DepId; }
         set { _DepId = value; }
      }
      public virtual string DepName
      {
         get { return _DepName; }
         set { _DepName = value; }
      }
   }
}


