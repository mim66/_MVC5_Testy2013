using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _05_Hello.ViewModel
{
   public class PracownikListViewModel
   {
      public List<PracownikViewModel> Pracownicy { get; set; }
 
      public string NazwaUsera { get; set; }

      public StopkaViewModel StopkaDane { get; set; }
   }
}