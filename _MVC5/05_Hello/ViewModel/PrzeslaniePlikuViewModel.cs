using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _05_Hello.ViewModel
{
   // 27
   public class PrzeslaniePlikuViewModel : PodstawowyViewModel
   {
      public HttpPostedFileBase przeslijPlik { get; set; }  // fileUpload
   }
}