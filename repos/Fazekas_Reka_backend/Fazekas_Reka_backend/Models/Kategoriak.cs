using System;
using System.Collections.Generic;

namespace Fazekas_Reka_backend.Models
{
    public partial class Kategoriak
    {
        public Kategoriak()
        {
            Ingatlanoks = new HashSet<Ingatlanok>();
        }

        public int Id { get; set; }
        public string Nev { get; set; } = null!;

        public virtual ICollection<Ingatlanok> Ingatlanoks { get; set; }
    }
}
