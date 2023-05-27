namespace FadokoBackendV4.Models.DTOs
{
    public class AdminRequestDto
    {
        public string AdName { get; set; }
        public string AdPermission { get; set; }
        public string AdEmail { get; set; }
        public string AdPhone { get; set; }
        public int Active { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
    }
}
