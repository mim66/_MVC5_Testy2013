using System;
using System.Collections.Generic;


namespace ContosoPolski.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Nazwisko { get; set; }
        public string PierwszeImie { get; set; }
        public DateTime DataNaboru { get; set; }

        public virtual ICollection<Nabor> Nabory { get; set; }
    }
}