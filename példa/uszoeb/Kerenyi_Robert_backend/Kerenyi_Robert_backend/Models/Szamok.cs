using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Kerenyi_Robert_backend.Models
{
    public partial class Szamok
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public int VersenyzoId { get; set; }

        [JsonIgnore]
        public virtual Versenyzok Versenyzo { get; set; }
    }
}
