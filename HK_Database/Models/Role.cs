using System.Collections.Generic;

namespace HK_Database.Models
{
    public class Role
    {
        public string RoleId { get; set; }
        public string Name { get; set; }

        // Navigation property for UserRoles
        public ICollection<UserRoles> UserRoles { get; set; }
    }
}
