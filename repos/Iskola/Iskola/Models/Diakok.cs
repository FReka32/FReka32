using System;
using System.Collections.Generic;

namespace Iskola.Models
{
    public partial class Diakok
    {
        public int Id { get; set; }
        public string Tanev { get; set; } = null!;
        public int IskolaId { get; set; }
        public string OktatasiAzonosito { get; set; } = null!;
        public string Nev { get; set; } = null!;
        public string Osztaly { get; set; } = null!;

        public virtual Iskolak Iskola { get; set; } = null!;
    }
}
