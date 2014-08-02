using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoPl.Models
{
    public class Kurs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Tytul { get; set; }
        public int Zaliczenia { get; set; }
        
        public virtual ICollection<Nabor> Nabory { get; set; }
    }
}