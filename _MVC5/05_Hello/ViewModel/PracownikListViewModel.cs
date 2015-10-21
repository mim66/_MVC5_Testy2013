using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _05_Hello.ViewModel
{
   //25
   public class PracownikListViewModel : PodstawowyViewModel
   {
      public List<PracownikViewModel> Pracownicy { get; set; }
   }


   //0-24 - komentujemy ponieważ zaimplementowaliśmy klasę PodstawowyViewModel
   //public class PracownikListViewModel
   //{
   //   public List<PracownikViewModel> Pracownicy { get; set; }
   //   public string NazwaUsera { get; set; }
   //   public StopkaViewModel StopkaDane { get; set; }
   //}

}