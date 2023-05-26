using System;

namespace FadokoBackendV4.Models.DTOs
{
    public class OrderRequestDto
    {
        public string OrData { get; set; }
        public int? AdId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public DateTime LogDate { get; set; }
    }
}
