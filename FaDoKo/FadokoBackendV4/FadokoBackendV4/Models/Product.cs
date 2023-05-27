using System;
using System.Collections.Generic;

#nullable disable

namespace FadokoBackendV4.Models
{
    public partial class Product
    {
        public int PrId { get; set; }
        public string PrName { get; set; }
        public string PrOther { get; set; }
        public string PrUrl { get; set; }
        public int PrActive { get; set; }
        public int PrPrice { get; set; }
    }
}
