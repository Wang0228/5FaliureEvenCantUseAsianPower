using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HK_Database.Models
{
    public class UserRoles
    {
        [Key, Column(Order = 0)]
        public string UserId { get; set; }

        public User Users { get; set; } //Navigation property for Users

        [Key, Column(Order = 1)]
        public string RoleId { get; set; }
        public Role Roles { get; set; } //Navigation property for Roles
    }
}
