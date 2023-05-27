using System;
using System.Collections.Generic;

#nullable disable

namespace Iskola.Models
{
    public partial class Iskolalogok
    {
        public int Id { get; set; }
        public int IskolaId { get; set; }
        public byte[] Logo { get; set; }

        public virtual Iskolak Iskola { get; set; }
    }
}
