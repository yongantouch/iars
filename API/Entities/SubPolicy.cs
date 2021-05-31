using System.Collections.Generic;

namespace API.Entities
{
    public class SubPolicy : CreatingInfo
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string ReleaseLetterNo { get; set; }
        public string Content { get; set; }
        public string ApprovedBy { get; set; }
        public string ReviewedBy { get; set; }
        public int PolicyId { get; set; }
        public Policy Policy { get; set; }
    }
}