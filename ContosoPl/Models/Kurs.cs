using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPl.Models
{
    public class Kurs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Numer")]
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Tytul { get; set; }


        [Range(0, 5)]
        public int Zaliczenia { get; set; }

        public int IdWydzialu { get; set; }

        public virtual Wydzial Wydzial { get; set; }
        public virtual ICollection<Nabor> Nabory { get; set; }
        public virtual ICollection<Instruktor> Instruktorzy { get; set; }
    }
}