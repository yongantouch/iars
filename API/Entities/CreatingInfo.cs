using System;

namespace API.Entities
{
    public class CreatingInfo
    {
        public AppUser CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? LastestUpdate { get; set; }
    }
}