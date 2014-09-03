using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ContosoPl.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nazwisko { get; set; }

        [Required]
        [Column("Imie")]
        [Display(Name = "Pierwsze Imię")]
        [StringLength(50, ErrorMessage = "Imię nie może być dłuższe niż 50 znaków.")]
        public string PierwszeImie { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data Naboru")]
        public DateTime DataNaboru { get; set; }

        [Display(Name = "Imię i Nazwisko")]
        public string ImieNazwisko {
            get {
                return Nazwisko + ", " + PierwszeImie;
            }
        }

        public virtual ICollection<Nabor> Nabory { get; set; }
    }
}