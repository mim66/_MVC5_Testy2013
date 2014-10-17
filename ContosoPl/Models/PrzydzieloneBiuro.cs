using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPl.Models
{
    public class PrzydzieloneBiuro
    {
        [Key]
        [ForeignKey("Instruktor")]
        public int IdInstruktora { get; set; }
        [StringLength(50)]
        [Display(Name = "Adres Biura")]
        public string Adres { get; set; }

        //public virtual Instruktor Instruktor { get; set; }
    }
}
