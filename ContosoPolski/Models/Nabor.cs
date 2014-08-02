using System;
using System.Collections.Generic;

namespace ContosoPolski.Models
{
    public enum Ocena
    {
        A, B, C, D, F
    }

    public class Nabor
    {
        public int Id { get; set; }
        public int IdKursu { get; set; }
        public int IdStudenta { get; set; }
        public Ocena? Ocena { get; set; }

        public virtual Kurs Kurs { get; set; }
        public virtual Student Student { get; set; }
    }
}
