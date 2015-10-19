using System.ComponentModel.DataAnnotations;

namespace _05_Hello.Models
{
   public class Uzytkownik
   {
      [StringLength(7, MinimumLength=2, ErrorMessage="Długośc nazwy użytkownika powinna być w przedziale od 2 do 7 znaków...")]
      public string NazwaUsera   { get; set; }
      public string Haslo        { get; set; }
   }
}