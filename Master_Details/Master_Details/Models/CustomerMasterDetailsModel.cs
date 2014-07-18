using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Master_Details.Models
{
   public class CustomerMasterDetailsModel
   {
      public Customers SelectedCustomer { get; set; }
      public string SelectedCustomerID { get; set; }

      public List<Customers> Customers { get; set; }
   }
}