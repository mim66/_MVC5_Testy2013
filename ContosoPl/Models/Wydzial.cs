

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ContosoPl.Models
{
    public class Wydzial
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Nazwa { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Budzet { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data Początkowa")]
        public DateTime DataPoczatkowa { get; set; }

        public int? IdInstruktora { get; set; }

        //public virtual Instruktor Administrator { get; set; }
        public virtual ICollection<Kurs> Kursy { get; set; }
    }
}
