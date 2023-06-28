using System;
using System.Collections.Generic;

namespace openAPI.Models;

public partial class Qahistory
{
    public string QahistoryId { get; set; } = null!;

    public string QahistoryQ { get; set; } = null!;

    public string QahistoryA { get; set; } = null!;

    public string QahistoryVectors { get; set; } = null!;

    public string ChatId { get; set; } = null!;

    public virtual Chat Chat { get; set; } = null!;
}
