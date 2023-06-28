using System;
using System.Collections.Generic;

namespace openAPI.Models;

public partial class User
{
    public string UserId { get; set; } = null!;

    public string UserAccount { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public string UserPhone { get; set; } = null!;

    public string ApplicationId { get; set; } = null!;

    public virtual Application Application { get; set; } = null!;

    public virtual ICollection<Chat> Chats { get; set; } = new List<Chat>();
}
