namespace FadokoBackendV4.Models.DTOs
{
    public class AdminDto
    {
        public int AdId { get; set; }
        public string AdName { get; set; }
        public string AdPermission { get; set; }
        public string AdEmail { get; set; }
        public string AdPhone { get; set; }
        public int Active { get; set; }
    }
}
