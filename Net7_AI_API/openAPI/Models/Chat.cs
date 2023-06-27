using System;
using System.Collections.Generic;

namespace openAPI.Models;

public partial class Chat
{
    public string ChatId { get; set; } = null!;

    public DateTime ChatData { get; set; }

    public string ChatName { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public virtual ICollection<Qahistory> Qahistories { get; set; } = new List<Qahistory>();

    public virtual User User { get; set; } = null!;
}
