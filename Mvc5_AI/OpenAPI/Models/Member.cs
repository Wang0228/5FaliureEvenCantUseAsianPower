﻿using System;
using System.Collections.Generic;

namespace openAPI.Models;

public partial class Member
{
    public string MemberId { get; set; } = null!;

    public string MemberName { get; set; } = null!;

    public string MemberEmail { get; set; } = null!;

    public string MemberPhone { get; set; } = null!;

    public string Apikey { get; set; } = null!;

    public string MemberAccount { get; set; } = null!;

    public string MemberPassword { get; set; } = null!;

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
}
