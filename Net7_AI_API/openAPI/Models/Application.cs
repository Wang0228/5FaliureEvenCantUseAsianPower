using System;
using System.Collections.Generic;

namespace openAPI.Models;

public partial class Application
{
    public string ApplicationId { get; set; } = null!;

    public string Model { get; set; } = null!;

    public string MemberId { get; set; } = null!;

    public virtual ICollection<Data> Data { get; set; } = new List<Data>();

    public virtual Member Member { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
