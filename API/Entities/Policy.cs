using System;
using System.Collections.Generic;

namespace API.Entities
{
    public class Policy : CreatingInfo
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public ICollection<SubPolicy> SubPolices { get; set; }
        
    }
}