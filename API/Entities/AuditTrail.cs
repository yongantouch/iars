using System;

namespace API.Entities
{
    public class AuditTrail
    {
        public int Id { get; set; }
        public string Controller { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public AppUser User { get; set; }
        public DateTime ActionDate { get; set; } = DateTime.Now;
    }
}