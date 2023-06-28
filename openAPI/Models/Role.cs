using System;
using System.Collections.Generic;

namespace openAPI.Models;

public partial class Role
{
    public string RoleId { get; set; } = null!;

    public string? Name { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
