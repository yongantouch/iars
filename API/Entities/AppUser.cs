using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string Address { get; set; }
        public string StaffId { get; set; }
        public bool FirstLogin { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}