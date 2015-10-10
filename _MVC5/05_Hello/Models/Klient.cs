
namespace _05_Hello.Models
{
   public class Klient
   {
      public string KlientNazwa { get; set; }
      public Adres Addres { get; set; }
   }

   public class Adres
   {
      public string Miasto { get; set; }
      public string Powiat { get; set; }
   }
}