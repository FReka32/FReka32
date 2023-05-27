namespace FadokoBackendV4.Models.DTOs
{
    public class ProductRequestDto
    {
        public string PrName { get; set; }
        public string PrOther { get; set; }
        public string CoIds { get; set; }
        public string PrUrl { get; set; }
        public int PrActive { get; set; }
        public int PrPrice { get; set; }
    }
}
