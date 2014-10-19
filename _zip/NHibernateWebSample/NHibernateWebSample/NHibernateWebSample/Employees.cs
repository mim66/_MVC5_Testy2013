using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHibernateWebSample
{
    public class Employees
    {
        private int _EmpId;
        private string _FirstName;
        private string _SecondName;
        private string _DepId;
        private EmployeeInfos  empInfo = new EmployeeInfos();

        public virtual int EmpId
        {
            get { return _EmpId; }
            set 
            { 
                _EmpId = value;
                empInfo.EmpId = value;
            }
        }
        public virtual string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public virtual string SecondName
        {
            get { return _SecondName; }
            set { _SecondName = value; }
        }

        public virtual string DepId
        {
            get { return _DepId; }
            set { _DepId = value; }
        }

        //Properties of EmployeeInfos table
        public virtual string EmailId
        {
            get { return empInfo.EmailId; }
            set { empInfo.EmailId = value; }
        }
        public virtual string Address
        {
            get { return empInfo.Address; }
            set { empInfo.Address = value; }
        }
        public virtual DateTime DOJ
        {
            get { return empInfo.DOJ; }
            set { empInfo.DOJ = value; }
        }
    }
}
